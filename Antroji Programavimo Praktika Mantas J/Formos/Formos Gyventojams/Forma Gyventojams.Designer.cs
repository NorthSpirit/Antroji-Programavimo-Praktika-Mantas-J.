namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
{
    partial class Forma_Gyventojams
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
            lbl_vartVardas = new Label();
            lbl_sveiki = new Label();
            lbl_priskirtas = new Label();
            btn_apieVartotoja = new Button();
            lbl_grupesAdresas = new Label();
            dtgrd_mokejimai = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgrd_mokejimai).BeginInit();
            SuspendLayout();
            // 
            // lbl_vartVardas
            // 
            lbl_vartVardas.AutoSize = true;
            lbl_vartVardas.Location = new Point(91, 13);
            lbl_vartVardas.Name = "lbl_vartVardas";
            lbl_vartVardas.Size = new Size(162, 15);
            lbl_vartVardas.TabIndex = 0;
            lbl_vartVardas.Text = "Vardasvardas PavardePavarde";
            // 
            // lbl_sveiki
            // 
            lbl_sveiki.AutoSize = true;
            lbl_sveiki.Location = new Point(12, 13);
            lbl_sveiki.Name = "lbl_sveiki";
            lbl_sveiki.Size = new Size(73, 15);
            lbl_sveiki.TabIndex = 1;
            lbl_sveiki.Text = "Sveiki, gerb. ";
            // 
            // lbl_priskirtas
            // 
            lbl_priskirtas.AutoSize = true;
            lbl_priskirtas.Location = new Point(12, 57);
            lbl_priskirtas.Name = "lbl_priskirtas";
            lbl_priskirtas.Size = new Size(221, 15);
            lbl_priskirtas.TabIndex = 2;
            lbl_priskirtas.Text = "Esate priskirtas prie: GRUPEGRUPEGRUPE";
            lbl_priskirtas.Click += lbl_priskirtas_Click;
            // 
            // btn_apieVartotoja
            // 
            btn_apieVartotoja.Location = new Point(429, 9);
            btn_apieVartotoja.Name = "btn_apieVartotoja";
            btn_apieVartotoja.Size = new Size(147, 23);
            btn_apieVartotoja.TabIndex = 3;
            btn_apieVartotoja.Text = "Asmeninė Informacija";
            btn_apieVartotoja.UseVisualStyleBackColor = true;
            btn_apieVartotoja.Click += btn_apieVartotoja_Click;
            // 
            // lbl_grupesAdresas
            // 
            lbl_grupesAdresas.AutoSize = true;
            lbl_grupesAdresas.Location = new Point(12, 82);
            lbl_grupesAdresas.Name = "lbl_grupesAdresas";
            lbl_grupesAdresas.Size = new Size(214, 15);
            lbl_grupesAdresas.TabIndex = 4;
            lbl_grupesAdresas.Text = "Adresu: AdresasAdresasAdresasAdresas";
            // 
            // dtgrd_mokejimai
            // 
            dtgrd_mokejimai.AllowUserToOrderColumns = true;
            dtgrd_mokejimai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgrd_mokejimai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrd_mokejimai.Location = new Point(12, 116);
            dtgrd_mokejimai.Name = "dtgrd_mokejimai";
            dtgrd_mokejimai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrd_mokejimai.Size = new Size(843, 322);
            dtgrd_mokejimai.TabIndex = 5;
            dtgrd_mokejimai.CellContentClick += dtgrd_mokejimai_CellContentClick;
            // 
            // Forma_Gyventojams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(dtgrd_mokejimai);
            Controls.Add(lbl_grupesAdresas);
            Controls.Add(btn_apieVartotoja);
            Controls.Add(lbl_priskirtas);
            Controls.Add(lbl_sveiki);
            Controls.Add(lbl_vartVardas);
            Name = "Forma_Gyventojams";
            Text = "Forma_Gyventojams";
            Load += Forma_Gyventojams_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrd_mokejimai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_vartVardas;
        private Label lbl_sveiki;
        private Label lbl_priskirtas;
        private Button btn_apieVartotoja;
        private Label lbl_grupesAdresas;
        private DataGridView dtgrd_mokejimai;
    }
}