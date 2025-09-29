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
            try //è necessario boh guardo esempio prof
            {
                string serial = File.ReadAllText(FilePath);
                catalogo = JsonConvert.DeserializeObject<Catalogo>(serial);
            }
            catch
            {
                MessageBox.Show("Errore lettura");
            }
        }

        private void writeJSON()
        {
            string serial = JsonConvert.SerializeObject(catalogo);
            File.WriteAllText(FilePath, serial);
        }

        private void btn_GestisciCatalogo_Click(object sender, EventArgs e)
        {
            using (FormGestioneCatalogo fgc = new(catalogo))
            {
                if (fgc.ShowDialog() == DialogResult.OK)
                {
                    readJSON();
                }
            }
        }

        private void btn_Scansiona_Click(object sender, EventArgs e)
        {
            using (FormScansiona fs = new(catalogo))
            {
                fs.gatherProduct += OttieniValore;
            }
        }

        public void OttieniValore (object sender, EventArgs e)
        {

        }
    }
}
