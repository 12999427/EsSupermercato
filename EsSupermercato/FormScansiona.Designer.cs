namespace EsSupermercato
{
    partial class FormScansiona
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
            lbl_NumProdotti = new Label();
            nmr_NumCassa = new NumericUpDown();
            cmb_TipiProdotti = new ComboBox();
            dtg_Prodotti = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Prezzo = new DataGridViewTextBoxColumn();
            Quantità = new DataGridViewTextBoxColumn();
            btn_Seleziona = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_NumCassa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titolo
            // 
            lbl_Titolo.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titolo.Location = new Point(12, 12);
            lbl_Titolo.Name = "lbl_Titolo";
            lbl_Titolo.Size = new Size(226, 73);
            lbl_Titolo.TabIndex = 22;
            lbl_Titolo.Text = "Scansiona Prodotto";
            lbl_Titolo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Conferma
            // 
            btn_Conferma.Location = new Point(12, 321);
            btn_Conferma.Name = "btn_Conferma";
            btn_Conferma.Size = new Size(245, 51);
            btn_Conferma.TabIndex = 21;
            btn_Conferma.Text = "CONFERMA";
            btn_Conferma.UseVisualStyleBackColor = true;
            btn_Conferma.Click += btn_Conferma_Click;
            // 
            // lbl_NumProdotti
            // 
            lbl_NumProdotti.Location = new Point(12, 138);
            lbl_NumProdotti.Name = "lbl_NumProdotti";
            lbl_NumProdotti.Size = new Size(138, 87);
            lbl_NumProdotti.TabIndex = 20;
            lbl_NumProdotti.Text = "Numero Prodotti: \r\n\r\nNome:\r\n";
            // 
            // nmr_NumCassa
            // 
            nmr_NumCassa.Location = new Point(156, 138);
            nmr_NumCassa.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nmr_NumCassa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_NumCassa.Name = "nmr_NumCassa";
            nmr_NumCassa.Size = new Size(101, 23);
            nmr_NumCassa.TabIndex = 19;
            nmr_NumCassa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmb_TipiProdotti
            // 
            cmb_TipiProdotti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TipiProdotti.FormattingEnabled = true;
            cmb_TipiProdotti.Location = new Point(12, 191);
            cmb_TipiProdotti.Name = "cmb_TipiProdotti";
            cmb_TipiProdotti.Size = new Size(245, 23);
            cmb_TipiProdotti.TabIndex = 24;
            // 
            // dtg_Prodotti
            // 
            dtg_Prodotti.AllowUserToAddRows = false;
            dtg_Prodotti.AllowUserToDeleteRows = false;
            dtg_Prodotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Prodotti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Prodotti.Columns.AddRange(new DataGridViewColumn[] { Nome, Prezzo, Quantità });
            dtg_Prodotti.Location = new Point(280, 12);
            dtg_Prodotti.MultiSelect = false;
            dtg_Prodotti.Name = "dtg_Prodotti";
            dtg_Prodotti.ReadOnly = true;
            dtg_Prodotti.RowTemplate.Height = 25;
            dtg_Prodotti.Size = new Size(311, 299);
            dtg_Prodotti.TabIndex = 25;
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
            // btn_Seleziona
            // 
            btn_Seleziona.Location = new Point(323, 328);
            btn_Seleziona.Name = "btn_Seleziona";
            btn_Seleziona.Size = new Size(233, 36);
            btn_Seleziona.TabIndex = 26;
            btn_Seleziona.Text = "SELEZIONA";
            btn_Seleziona.UseVisualStyleBackColor = true;
            btn_Seleziona.Click += btn_Seleziona_Click;
            // 
            // FormScansiona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 384);
            Controls.Add(btn_Seleziona);
            Controls.Add(dtg_Prodotti);
            Controls.Add(cmb_TipiProdotti);
            Controls.Add(lbl_Titolo);
            Controls.Add(btn_Conferma);
            Controls.Add(lbl_NumProdotti);
            Controls.Add(nmr_NumCassa);
            Name = "FormScansiona";
            Text = "FormScansiona";
            ((System.ComponentModel.ISupportInitialize)nmr_NumCassa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Titolo;
        private Button btn_Conferma;
        private Label lbl_NumProdotti;
        private NumericUpDown nmr_NumCassa;
        private ComboBox cmb_TipiProdotti;
        private DataGridView dtg_Prodotti;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Prezzo;
        private DataGridViewTextBoxColumn Quantità;
        private Button btn_Seleziona;
    }
}