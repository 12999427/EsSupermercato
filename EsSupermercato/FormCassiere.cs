using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsSupermercato
{
    public partial class FormCassiere : Form
    {
        private List<Spesa> Spese = new();
        private string FilePath;
        private Catalogo catalogo = new();
        public FormCassiere()
        {
            InitializeComponent();
            SetupFilePath();
            readJSON();
            Spese.Add(new Spesa());
            UpdateDGV();
        }

        private void SetupFilePath()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\", "output JSON");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


            FilePath = Path.Combine(path, "Catalogo.json");

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
                writeJSON();
            }

        }

        private void readJSON()
        {
            try
            {
                string serial = File.ReadAllText(FilePath);
                var listaTuple = JsonConvert.DeserializeObject<List<(Prodotto prodotto, int quantita)>>(serial);
                catalogo = new Catalogo(listaTuple);
            }
            catch
            {
                MessageBox.Show("Errore lettura");
            }
        }

        private void writeJSON()
        {
            string serial = JsonConvert.SerializeObject(catalogo.ConvertiAListaTuple(), Formatting.Indented);
            File.WriteAllText(FilePath, serial);
        }

        private void btn_GestisciCatalogo_Click(object sender, EventArgs e)
        {
            using (FormGestioneCatalogo fgc = new(catalogo))
            {
                if (fgc.ShowDialog() == DialogResult.OK)
                {
                    writeJSON();
                    UpdateDGV();
                }
            }
        }

        public float UpdateDGV()
        {
            float prezzo = 0;
            dtg_Prodotti.Rows.Clear();
            foreach (KeyValuePair<Prodotto, int> pair in Spese[^1].Prodotti)
            {
                dtg_Prodotti.Rows.Add(pair.Key.Nome, pair.Key.Prezzo, pair.Value);
                prezzo += pair.Key.Prezzo * pair.Value;
            }
            lbl_ParzialeSconto.Text = chk_ClienteFidelizzato.Checked ? $"Totale (fidelizzato): {prezzo * 0.9}\nTotale senza fidelizzazione: {prezzo}" : $"Totale (non fidelizzato): {prezzo}";
            if (chk_ClienteFidelizzato.Checked)
                prezzo *= 0.9f;

            return prezzo;

        }

        private void btn_Scansiona_Click(object sender, EventArgs e)
        {

            using (FormScansiona fs = new(catalogo, OttieniValore))
            {
                //fs.gatherProduct += OttieniValore;

                if (fs.ShowDialog() == DialogResult.OK)
                {
                    if (nmr_NumCassa.Enabled)
                    {
                        nmr_NumCassa.Enabled = false;
                        chk_ClienteFidelizzato.Enabled = false;
                        Spese[^1].numCassa = (int)nmr_NumCassa.Value;
                    }
                }

            }
        }

        public void OttieniValore(object sender, (Prodotto prodotto, int quantita) scansionato)
        {
            try
            {
                catalogo.AggiungiProdotto(scansionato.prodotto, -scansionato.quantita);
                Spese[^1].AggiungiProdotto(scansionato.prodotto, scansionato.quantita);
                UpdateDGV();
            }
            catch
            {
                MessageBox.Show("Non ci sono abbastanza prodotti");
            }

        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            if (Spese[^1].Prodotti.Count == 0)
            {
                MessageBox.Show("Nessun Prodotto");
                return;
            }
            if (Stampa())
            {
                NuovaSpesa();
            }
        }

        private string GeneraScontrino()
        {
            string val = "-------------------------------------------\n"; //17, 9, 17
            val += $"    NUM CASSA: {nmr_NumCassa.Value}\n";
            val += $"    FIDELIZZATO ?: {(chk_ClienteFidelizzato.Checked ? "SI" : "NO")}\n";
            val += $"    DATA: {DateTime.Now.ToString("dd MM yyyy HH mm ss")}\n";
            val += "-------------------------------------------\n";
            val += "NOME:                 QUANTITA  PREZZO  TOT\n"; //22, 10

            float prezzo = 0;
            foreach (KeyValuePair<Prodotto, int> pair in Spese[^1].Prodotti)
            {
                val += $"{pair.Key.Nome.PadRight(21)} {pair.Key.Prezzo.ToString().PadRight(9)} {pair.Value.ToString().PadRight(7)} {(pair.Key.Prezzo * pair.Value).ToString()}\n";
                prezzo += pair.Key.Prezzo * pair.Value;
            }
            val += "-------------------------------------------\n";
            val += chk_ClienteFidelizzato.Checked ? $"Totale (fidelizzato): {prezzo * 0.9}\nTotale senza fidelizzazione: {prezzo}\n" : $"Totale (non fidelizzato): {prezzo}\n";

            return (val);
        }

        private bool Stampa()
        {
            PrintDocument ptrDoc = new PrintDocument();

            ptrDoc.DocumentName = $"Scontrino_{nmr_NumCassa.Value} {DateTime.Now:yyyy-MM-dd_HH-mm}";

            ptrDoc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("SCONTRINO", new Font("Arial", 26), Brushes.Black, 165, 20);
                ev.Graphics.DrawString(GeneraScontrino(), new Font("Consolas", 15), Brushes.Black, 20, 100);
            };

            PrintDialog ptrDialog = new PrintDialog();
            ptrDialog.Document = ptrDoc;

            if (ptrDialog.ShowDialog() == DialogResult.OK)
            {
                ptrDoc.Print();

                DialogResult result = MessageBox.Show(
                                    "Passare a una nuova spesa?\n",
                                    "Conferma",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question
                                );
                return (result == DialogResult.OK);
            }
            return false;
        }

        private void NuovaSpesa()
        {
            nmr_NumCassa.Enabled = true;
            chk_ClienteFidelizzato.Enabled = true;
            Spese.Add(new Spesa());
            UpdateDGV();
            chk_ClienteFidelizzato.Checked = false;
        }

        private void btn_Rimuovi_Click_2(object sender, EventArgs e)
        {
            if (dtg_Prodotti.SelectedCells.Count > 0)
            {
                Prodotto p = catalogo.OttieniProdottoPerNome(dtg_Prodotti.SelectedCells[0].Value.ToString());
                if (p != null)
                {
                    int q = Spese[^1].OttieniQuantitaProdotto(p);
                    catalogo.AggiungiProdotto(p, q);
                    Spese[^1].AggiungiProdotto(p, -q);
                    UpdateDGV();
                }
            }
        }
    }
}
