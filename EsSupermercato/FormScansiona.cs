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
            gatherProduct = gatherEvent;
        }

        public FormScansiona(Catalogo c)
        {
            InitializeComponent();
            catalogo = c;
        }


    }
}
