namespace EsSupermercato
{
    partial class FormGestioneCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Titolo = new Label();
            btn_Conferma = new Button();
            btn_Rimuovi = new Button();
            btn_Aggiungi = new Button();
            lbl_NumProdotti = new Label();
            nmr_NumProdotti = new NumericUpDown();
            txt_Nome = new TextBox();
            dtg_Prodotti = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Prezzo = new DataGridViewTextBoxColumn();
            Quantità = new DataGridViewTextBoxColumn();
            nmr_Prezzo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmr_NumProdotti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Prezzo).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titolo
            // 
            lbl_Titolo.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titolo.Location = new Point(12, 9);
            lbl_Titolo.Name = "lbl_Titolo";
            lbl_Titolo.Size = new Size(247, 73);
            lbl_Titolo.TabIndex = 16;
            lbl_Titolo.Text = "Gestione Catalogo";
            lbl_Titolo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Conferma
            // 
            btn_Conferma.Location = new Point(12, 387);
            btn_Conferma.Name = "btn_Conferma";
            btn_Conferma.Size = new Size(247, 51);
            btn_Conferma.TabIndex = 14;
            btn_Conferma.Text = "CONFERMA";
            btn_Conferma.UseVisualStyleBackColor = true;
            btn_Conferma.Click += btn_Conferma_Click;
            // 
            // btn_Rimuovi
            // 
            btn_Rimuovi.Location = new Point(12, 297);
            btn_Rimuovi.Name = "btn_Rimuovi";
            btn_Rimuovi.Size = new Size(247, 40);
            btn_Rimuovi.TabIndex = 13;
            btn_Rimuovi.Text = "RIUMOVI";
            btn_Rimuovi.UseVisualStyleBackColor = true;
            btn_Rimuovi.Click += btn_Rimuovi_Click;
            // 
            // btn_Aggiungi
            // 
            btn_Aggiungi.Location = new Point(12, 225);
            btn_Aggiungi.Name = "btn_Aggiungi";
            btn_Aggiungi.Size = new Size(247, 40);
            btn_Aggiungi.TabIndex = 12;
            btn_Aggiungi.Text = "AGGIUNGI";
            btn_Aggiungi.UseVisualStyleBackColor = true;
            btn_Aggiungi.Click += btn_Aggiungi_Click;
            // 
            // lbl_NumProdotti
            // 
            lbl_NumProdotti.Location = new Point(12, 135);
            lbl_NumProdotti.Name = "lbl_NumProdotti";
            lbl_NumProdotti.Size = new Size(138, 87);
            lbl_NumProdotti.TabIndex = 11;
            lbl_NumProdotti.Text = "Numero Prodotti: \r\n\r\nNome:\r\n\r\nPrezzo:\r\n";
            // 
            // nmr_NumProdotti
            // 
            nmr_NumProdotti.Location = new Point(156, 132);
            nmr_NumProdotti.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nmr_NumProdotti.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_NumProdotti.Name = "nmr_NumProdotti";
            nmr_NumProdotti.Size = new Size(103, 23);
            nmr_NumProdotti.TabIndex = 10;
            nmr_NumProdotti.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(62, 161);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(197, 23);
            txt_Nome.TabIndex = 17;
            // 
            // dtg_Prodotti
            // 
            dtg_Prodotti.AllowUserToAddRows = false;
            dtg_Prodotti.AllowUserToDeleteRows = false;
            dtg_Prodotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Prodotti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Prodotti.Columns.AddRange(new DataGridViewColumn[] { Nome, Prezzo, Quantità });
            dtg_Prodotti.Location = new Point(271, 7);
            dtg_Prodotti.Name = "dtg_Prodotti";
            dtg_Prodotti.ReadOnly = true;
            dtg_Prodotti.RowTemplate.Height = 25;
            dtg_Prodotti.Size = new Size(517, 431);
            dtg_Prodotti.TabIndex = 18;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Prezzo
            // 
            Prezzo.HeaderText = "Prezzo";
            Prezzo.Name = "Prezzo";
            Prezzo.ReadOnly = true;
            // 
            // Quantità
            // 
            Quantità.HeaderText = "Quantità";
            Quantità.Name = "Quantità";
            Quantità.ReadOnly = true;
            // 
            // nmr_Prezzo
            // 
            nmr_Prezzo.DecimalPlaces = 2;
            nmr_Prezzo.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            nmr_Prezzo.Location = new Point(156, 190);
            nmr_Prezzo.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmr_Prezzo.Name = "nmr_Prezzo";
            nmr_Prezzo.Size = new Size(103, 23);
            nmr_Prezzo.TabIndex = 19;
            nmr_Prezzo.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // FormGestioneCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtg_Prodotti);
            Controls.Add(nmr_Prezzo);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Titolo);
            Controls.Add(btn_Conferma);
            Controls.Add(btn_Rimuovi);
            Controls.Add(btn_Aggiungi);
            Controls.Add(lbl_NumProdotti);
            Controls.Add(nmr_NumProdotti);
            Name = "FormGestioneCatalogo";
            Text = "FormGestioneCatalogo";
            ((System.ComponentModel.ISupportInitialize)nmr_NumProdotti).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_Prezzo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titolo;
        private Button btn_Conferma;
        private Button btn_Rimuovi;
        private Button btn_Aggiungi;
        private Label lbl_NumProdotti;
        private NumericUpDown nmr_NumProdotti;
        private TextBox txt_Nome;
        private DataGridView dtg_Prodotti;
        private NumericUpDown nmr_Prezzo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Prezzo;
        private DataGridViewTextBoxColumn Quantità;
    }
}