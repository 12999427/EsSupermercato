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
        private string filePath;
        public FormCassiere()
        {
            InitializeComponent();
            filePath = SetupFile();
        }

        private string SetupFile ()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "output JSON");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = Path.Combine(path, "Spese.json");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            return filePath;
        }

        private void readJSON ()
        {
            try //è necessario boh guardo esempio prof
            {
                string serial = File.ReadAllText(filePath);
                Spese = JsonConvert.DeserializeObject<List<Spesa>>(serial);
            }
            catch
            {
                MessageBox.Show("Errore lettura");
            }
            
        }

        private void btn_GestisciCatalogo_Click(object sender, EventArgs e)
        {
            using (FormGestioneCatalogo fgc = new())
            {
                if (fgc.ShowDialog() == DialogResult.OK)
                {
                    readJSON();
                }
            }
        }
    }
}
