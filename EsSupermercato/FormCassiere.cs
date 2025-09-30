using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            lbl_ParzialeSconto.Text = chk_ClienteFidelizzato.Checked ? $"Totale (fidelizzato): {prezzo * 0.9}\nTotale senza fidelizzazione: {prezzo}" : $"Totale (fidelizzato): {prezzo}";
            if (chk_ClienteFidelizzato.Checked)
                prezzo *= 0.9f;

            return prezzo;

        }

        private void btn_Scansiona_Click(object sender, EventArgs e)
        {
            if (nmr_NumCassa.Enabled)
            {
                nmr_NumCassa.Enabled = false;
                chk_ClienteFidelizzato.Enabled = false;
                Spese[^1].numCassa = (int)nmr_NumCassa.Value;
            }
            using (FormScansiona fs = new(catalogo, OttieniValore))
            {
                //fs.gatherProduct += OttieniValore;
                fs.ShowDialog();

            }
        }

        public void OttieniValore(object sender, (Prodotto prodotto, int quantita) scansionato)
        {
            Spese[^1].AggiungiProdotto(scansionato.prodotto, scansionato.quantita);
            UpdateDGV();
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            float tot = UpdateDGV();

        }

        private string GeneraScontrino ()
        {
            string val = "-----------------SCONTRINO-----------------\n"; //17, 9, 17
            val += $"    NUM CASSA: {nmr_NumCassa.Value}\n";
            val += $"    FIDELIZZATO ?: {(chk_ClienteFidelizzato.Checked ? "SI" : "NO")}\n";
            val += $"    DATA: {DateTime.Now.ToString("dd MM yyyy HH mm ss")}\n";
            val += "-------------------------------------------\n";
            val += "NOME:                 QUANTITA  PREZZO  TOT\n"; //22, 10

            float prezzo = 0;
            foreach (KeyValuePair<Prodotto, int> pair in Spese[^1].Prodotti)
            {
                val += $"{pair.Key.Nome.PadRight(22)} {pair.Key.Prezzo.ToString().PadRight(10)} {pair.Value.ToString().PadRight(8)} {(pair.Key.Prezzo * pair.Value).ToString()}";
                prezzo += pair.Key.Prezzo * pair.Value;
            }
            if (chk_ClienteFidelizzato.Checked)
                prezzo *= 0.9f;

            ...

            return (val);
        }
    }
}
