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
            dtg_Prodotti = new DataGridView();
            lbl_Titolo = new Label();
            btn_Conferma = new Button();
            lbl_NumProdotti = new Label();
            nmr_NumCassa = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_NumCassa).BeginInit();
            SuspendLayout();
            // 
            // dtg_Prodotti
            // 
            dtg_Prodotti.AllowUserToAddRows = false;
            dtg_Prodotti.AllowUserToDeleteRows = false;
            dtg_Prodotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Prodotti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Prodotti.Location = new Point(271, 10);
            dtg_Prodotti.Name = "dtg_Prodotti";
            dtg_Prodotti.ReadOnly = true;
            dtg_Prodotti.RowTemplate.Height = 25;
            dtg_Prodotti.Size = new Size(320, 362);
            dtg_Prodotti.TabIndex = 23;
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
            nmr_NumCassa.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmr_NumCassa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_NumCassa.Name = "nmr_NumCassa";
            nmr_NumCassa.Size = new Size(101, 23);
            nmr_NumCassa.TabIndex = 19;
            nmr_NumCassa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 24;
            // 
            // FormScansiona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 384);
            Controls.Add(comboBox1);
            Controls.Add(dtg_Prodotti);
            Controls.Add(lbl_Titolo);
            Controls.Add(btn_Conferma);
            Controls.Add(lbl_NumProdotti);
            Controls.Add(nmr_NumCassa);
            Name = "FormScansiona";
            Text = "FormScansiona";
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_NumCassa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Prodotti;
        private Label lbl_Titolo;
        private Button btn_Conferma;
        private Label lbl_NumProdotti;
        private NumericUpDown nmr_NumCassa;
        private ComboBox comboBox1;
    }
}