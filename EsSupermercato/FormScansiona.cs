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
    public partial class FormScansiona : Form
    {
        private Catalogo catalogo;
        public event EventHandler<(Prodotto prodotto, int quantita)> gatherProduct;
        public FormScansiona(Catalogo c, EventHandler<(Prodotto prodotto, int quantita)> gatherEvent)
        {
            InitializeComponent();
            catalogo = c;
            gatherProduct += gatherEvent;
            SetupComboBoxValues();
            UpdateDGV();
        }

        [Obsolete("FormScansiona(Catalogo) is deprecated, please use FormScansiona(Catalogo, EventHandler) instead.")]
        public FormScansiona(Catalogo c) // consigliare l'uso del costrutttore che richede l'eveneto per evitare che possa essere null
        {
            InitializeComponent();
            catalogo = c;
            SetupComboBoxValues();
            UpdateDGV();
        }
        public void SetupComboBoxValues ()
        {
            foreach (Prodotto p in catalogo.Prodotti.Keys)
            {
                cmb_TipiProdotti.Items.Add(p.Nome);
            }
        }

        public void UpdateDGV()
        {
            //dtg_Prodotti.DataSource = catalogo.Prodotti;
            dtg_Prodotti.Rows.Clear();
            foreach (KeyValuePair<Prodotto, int> pair in catalogo.Prodotti)
            {
                dtg_Prodotti.Rows.Add(pair.Key.Nome, pair.Key.Prezzo, pair.Value);
            }
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            if (cmb_TipiProdotti.SelectedItem != null)
            {
                Prodotto? p = catalogo.OttieniProdottoPerNome(cmb_TipiProdotti.SelectedItem.ToString());
                if (p != null)
                {
                    gatherProduct(this, (p, (int)nmr_NumCassa.Value));
                    Close();
                    return;
                }                    
            }
            MessageBox.Show("Nome Prodotto invalido");
        }

        private void btn_Seleziona_Click(object sender, EventArgs e)
        {
            if (dtg_Prodotti.SelectedCells.Count > 0 && catalogo.OttieniProdottoPerNome(dtg_Prodotti.SelectedCells[0].Value.ToString()) != null)
                cmb_TipiProdotti.SelectedItem = dtg_Prodotti.SelectedCells[0].Value;
        }
    }
}
