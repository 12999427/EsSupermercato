using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsSupermercato
{
    public partial class FormGestioneCatalogo : Form
    {
        private Catalogo catalogo;
        public FormGestioneCatalogo(Catalogo c)
        {
            InitializeComponent();
            catalogo = c;
            UpdateDGV();
            nmr_Prezzo.DecimalPlaces = 2;
            nmr_Prezzo.Increment = 0.01M;
            nmr_Prezzo.Minimum = 0;
            nmr_Prezzo.Maximum = 100;
        }

        public void UpdateDGV ()
        {
            //dtg_Prodotti.DataSource = catalogo.Prodotti;
            dtg_Prodotti.Rows.Clear();
            foreach (KeyValuePair<Prodotto, int> pair in catalogo.Prodotti)
            {
                dtg_Prodotti.Rows.Add(pair.Key.Nome, pair.Key.Prezzo, pair.Value);
            }
        }

        private void btn_Aggiungi_Click(object sender, EventArgs e)
        {
            Prodotto? p = catalogo.OttieniProdottoPerNome(txt_Nome.Text);
            try
            {
                if (p == null)
                    catalogo.AggiungiProdotto(new Prodotto(txt_Nome.Text, (float)nmr_Prezzo.Value), (int)nmr_NumProdotti.Value);
                else
                {
                    if (p.Prezzo == (float)nmr_Prezzo.Value)
                        catalogo.AggiungiProdotto(p, (int)nmr_NumProdotti.Value);
                    else
                    {
                        MessageBox.Show("Prezzo non corrisonde al nome");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Input errati");
            }
            UpdateDGV();
        }

        private void btn_Rimuovi_Click(object sender, EventArgs e)
        {
            if (dtg_Prodotti.SelectedCells.Count == 0)
            {
                return;
            }

            Prodotto selezionato = catalogo.OttieniProdottoPerNome(dtg_Prodotti.SelectedCells[0].Value.ToString());

            catalogo.AggiungiProdotto(selezionato, -catalogo.OttieniQuantitaProdotto(selezionato));

            UpdateDGV();
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
