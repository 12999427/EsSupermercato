namespace EsSupermercato
{
    partial class FormCassiere
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
            chk_ClienteFidelizzato = new CheckBox();
            nmr_NumCassa = new NumericUpDown();
            lbl_NumCassa = new Label();
            dtg_Prodotti = new DataGridView();
            btn_Scansiona = new Button();
            btn_Rimuovi = new Button();
            btn_Conferma = new Button();
            lbl_ParzialeSconto = new Label();
            lbl_Titolo = new Label();
            btn_GestisciCatalogo = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_NumCassa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).BeginInit();
            SuspendLayout();
            // 
            // chk_ClienteFidelizzato
            // 
            chk_ClienteFidelizzato.Location = new Point(12, 184);
            chk_ClienteFidelizzato.Name = "chk_ClienteFidelizzato";
            chk_ClienteFidelizzato.Size = new Size(226, 24);
            chk_ClienteFidelizzato.TabIndex = 0;
            chk_ClienteFidelizzato.Text = "Cliente Fidelizzato?";
            chk_ClienteFidelizzato.UseVisualStyleBackColor = true;
            // 
            // nmr_NumCassa
            // 
            nmr_NumCassa.Location = new Point(152, 146);
            nmr_NumCassa.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmr_NumCassa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_NumCassa.Name = "nmr_NumCassa";
            nmr_NumCassa.Size = new Size(59, 23);
            nmr_NumCassa.TabIndex = 1;
            nmr_NumCassa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_NumCassa
            // 
            lbl_NumCassa.Location = new Point(55, 148);
            lbl_NumCassa.Name = "lbl_NumCassa";
            lbl_NumCassa.Size = new Size(91, 23);
            lbl_NumCassa.TabIndex = 2;
            lbl_NumCassa.Text = "Numero Cassa: ";
            // 
            // dtg_Prodotti
            // 
            dtg_Prodotti.AllowUserToAddRows = false;
            dtg_Prodotti.AllowUserToDeleteRows = false;
            dtg_Prodotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Prodotti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Prodotti.Location = new Point(271, 7);
            dtg_Prodotti.Name = "dtg_Prodotti";
            dtg_Prodotti.ReadOnly = true;
            dtg_Prodotti.RowTemplate.Height = 25;
            dtg_Prodotti.Size = new Size(517, 431);
            dtg_Prodotti.TabIndex = 3;
            // 
            // btn_Scansiona
            // 
            btn_Scansiona.Location = new Point(12, 225);
            btn_Scansiona.Name = "btn_Scansiona";
            btn_Scansiona.Size = new Size(244, 40);
            btn_Scansiona.TabIndex = 4;
            btn_Scansiona.Text = "SCANSIONA PRODOTTO";
            btn_Scansiona.UseVisualStyleBackColor = true;
            // 
            // btn_Rimuovi
            // 
            btn_Rimuovi.Location = new Point(12, 271);
            btn_Rimuovi.Name = "btn_Rimuovi";
            btn_Rimuovi.Size = new Size(244, 40);
            btn_Rimuovi.TabIndex = 5;
            btn_Rimuovi.Text = "RIMUOVI PRODOTTO";
            btn_Rimuovi.UseVisualStyleBackColor = true;
            // 
            // btn_Conferma
            // 
            btn_Conferma.Location = new Point(12, 387);
            btn_Conferma.Name = "btn_Conferma";
            btn_Conferma.Size = new Size(244, 51);
            btn_Conferma.TabIndex = 6;
            btn_Conferma.Text = "CONFERMA";
            btn_Conferma.UseVisualStyleBackColor = true;
            // 
            // lbl_ParzialeSconto
            // 
            lbl_ParzialeSconto.Location = new Point(12, 333);
            lbl_ParzialeSconto.Name = "lbl_ParzialeSconto";
            lbl_ParzialeSconto.Size = new Size(156, 23);
            lbl_ParzialeSconto.TabIndex = 7;
            lbl_ParzialeSconto.Text = "Parziale: Sconto:";
            // 
            // lbl_Titolo
            // 
            lbl_Titolo.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titolo.Location = new Point(12, 9);
            lbl_Titolo.Name = "lbl_Titolo";
            lbl_Titolo.Size = new Size(246, 73);
            lbl_Titolo.TabIndex = 8;
            lbl_Titolo.Text = "Programma Cassa";
            lbl_Titolo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_GestisciCatalogo
            // 
            btn_GestisciCatalogo.Location = new Point(12, 85);
            btn_GestisciCatalogo.Name = "btn_GestisciCatalogo";
            btn_GestisciCatalogo.Size = new Size(244, 40);
            btn_GestisciCatalogo.TabIndex = 9;
            btn_GestisciCatalogo.Text = "GESTISCI CATALOGO";
            btn_GestisciCatalogo.UseVisualStyleBackColor = true;
            btn_GestisciCatalogo.Click += btn_GestisciCatalogo_Click;
            // 
            // FormCassiere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_GestisciCatalogo);
            Controls.Add(lbl_Titolo);
            Controls.Add(lbl_ParzialeSconto);
            Controls.Add(btn_Conferma);
            Controls.Add(btn_Rimuovi);
            Controls.Add(btn_Scansiona);
            Controls.Add(dtg_Prodotti);
            Controls.Add(lbl_NumCassa);
            Controls.Add(nmr_NumCassa);
            Controls.Add(chk_ClienteFidelizzato);
            Name = "FormCassiere";
            Text = "FormCassiere";
            ((System.ComponentModel.ISupportInitialize)nmr_NumCassa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Prodotti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chk_ClienteFidelizzato;
        private NumericUpDown nmr_NumCassa;
        private Label lbl_NumCassa;
        private DataGridView dtg_Prodotti;
        private Button btn_Scansiona;
        private Button btn_Rimuovi;
        private Button btn_Conferma;
        private Label lbl_ParzialeSconto;
        private Label lbl_Titolo;
        private Button btn_GestisciCatalogo;
    }
}