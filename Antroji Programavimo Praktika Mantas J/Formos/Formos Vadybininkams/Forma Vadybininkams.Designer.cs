namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
{
    partial class Forma_Vadybininkams
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
            lbl_grupesAdresas = new Label();
            btn_apieVartotoja = new Button();
            lbl_priskirtas = new Label();
            lbl_prisijunges = new Label();
            lbl_vartVardas = new Label();
            lbl_ID = new Label();
            lbl_grupesMokesciai = new Label();
            dtgrdMokesciai = new DataGridView();
            label1 = new Label();
            dtgrdGyventojai = new DataGridView();
            btn_keistiMokesti = new Button();
            btb_istrintiMokesti = new Button();
            btn_sukurtiNauja = new Button();
            btb_priskirtiVisiems = new Button();
            btn_priskirtiVienam = new Button();
            btn_atnaujinti = new Button();
            lbl_pasirinktasMokestis = new Label();
            lbl_pasirinktasGyventojas = new Label();
            btb_perziuretiVartotoja = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgrdMokesciai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrdGyventojai).BeginInit();
            SuspendLayout();
            // 
            // lbl_grupesAdresas
            // 
            lbl_grupesAdresas.AutoSize = true;
            lbl_grupesAdresas.Location = new Point(9, 78);
            lbl_grupesAdresas.Name = "lbl_grupesAdresas";
            lbl_grupesAdresas.Size = new Size(214, 15);
            lbl_grupesAdresas.TabIndex = 9;
            lbl_grupesAdresas.Text = "Adresu: AdresasAdresasAdresasAdresas";
            // 
            // btn_apieVartotoja
            // 
            btn_apieVartotoja.Location = new Point(426, 5);
            btn_apieVartotoja.Name = "btn_apieVartotoja";
            btn_apieVartotoja.Size = new Size(147, 23);
            btn_apieVartotoja.TabIndex = 8;
            btn_apieVartotoja.Text = "Asmeninė Informacija";
            btn_apieVartotoja.UseVisualStyleBackColor = true;
            btn_apieVartotoja.Click += btn_apieVartotoja_Click;
            // 
            // lbl_priskirtas
            // 
            lbl_priskirtas.AutoSize = true;
            lbl_priskirtas.Location = new Point(9, 53);
            lbl_priskirtas.Name = "lbl_priskirtas";
            lbl_priskirtas.Size = new Size(221, 15);
            lbl_priskirtas.TabIndex = 7;
            lbl_priskirtas.Text = "Esate priskirtas prie: GRUPEGRUPEGRUPE";
            // 
            // lbl_prisijunges
            // 
            lbl_prisijunges.AutoSize = true;
            lbl_prisijunges.Location = new Point(9, 9);
            lbl_prisijunges.Name = "lbl_prisijunges";
            lbl_prisijunges.Size = new Size(139, 15);
            lbl_prisijunges.TabIndex = 6;
            lbl_prisijunges.Text = "Prisijungęs Vadybininkas:";
            // 
            // lbl_vartVardas
            // 
            lbl_vartVardas.AutoSize = true;
            lbl_vartVardas.Location = new Point(154, 9);
            lbl_vartVardas.Name = "lbl_vartVardas";
            lbl_vartVardas.Size = new Size(162, 15);
            lbl_vartVardas.TabIndex = 5;
            lbl_vartVardas.Text = "Vardasvardas PavardePavarde";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(12, 24);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(24, 15);
            lbl_ID.TabIndex = 10;
            lbl_ID.Text = "ID: ";
            // 
            // lbl_grupesMokesciai
            // 
            lbl_grupesMokesciai.AutoSize = true;
            lbl_grupesMokesciai.Location = new Point(9, 93);
            lbl_grupesMokesciai.Name = "lbl_grupesMokesciai";
            lbl_grupesMokesciai.Size = new Size(154, 15);
            lbl_grupesMokesciai.TabIndex = 11;
            lbl_grupesMokesciai.Text = "Vartotojų Grupės Mokesčiai:";
            // 
            // dataGridView1
            // 
            dtgrdMokesciai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgrdMokesciai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdMokesciai.Location = new Point(9, 111);
            dtgrdMokesciai.Name = "dataGridView1";
            dtgrdMokesciai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrdMokesciai.Size = new Size(1256, 276);
            dtgrdMokesciai.TabIndex = 12;
            dtgrdMokesciai.CellContentClick += dtgrdMokesciai_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 424);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 13;
            label1.Text = "Vartotojų Grupės Gyventojai:";
            label1.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dtgrdGyventojai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgrdGyventojai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdGyventojai.Location = new Point(12, 442);
            dtgrdGyventojai.Name = "dataGridView2";
            dtgrdGyventojai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrdGyventojai.Size = new Size(1256, 276);
            dtgrdGyventojai.TabIndex = 14;
            dtgrdGyventojai.CellContentClick += dtgrdGyventojai_CellContentClick;
            // 
            // btn_keistiMokesti
            // 
            btn_keistiMokesti.Location = new Point(12, 398);
            btn_keistiMokesti.Name = "btn_keistiMokesti";
            btn_keistiMokesti.Size = new Size(167, 23);
            btn_keistiMokesti.TabIndex = 15;
            btn_keistiMokesti.Text = "Keisti Mokestį";
            btn_keistiMokesti.UseVisualStyleBackColor = true;
            btn_keistiMokesti.Click += btn_keistiMokesti_Click;
            // 
            // btb_istrintiMokesti
            // 
            btb_istrintiMokesti.Location = new Point(185, 398);
            btb_istrintiMokesti.Name = "btb_istrintiMokesti";
            btb_istrintiMokesti.Size = new Size(159, 23);
            btb_istrintiMokesti.TabIndex = 16;
            btb_istrintiMokesti.Text = "Ištrinti Mokestį";
            btb_istrintiMokesti.UseVisualStyleBackColor = true;
            btb_istrintiMokesti.Click += btb_istrintiMokesti_Click;
            // 
            // btn_sukurtiNauja
            // 
            btn_sukurtiNauja.Location = new Point(350, 398);
            btn_sukurtiNauja.Name = "btn_sukurtiNauja";
            btn_sukurtiNauja.Size = new Size(155, 23);
            btn_sukurtiNauja.TabIndex = 17;
            btn_sukurtiNauja.Text = "Sukurti naują mokestį";
            btn_sukurtiNauja.UseVisualStyleBackColor = true;
            btn_sukurtiNauja.Click += btn_sukurtiNauja_Click;
            // 
            // btb_priskirtiVisiems
            // 
            btb_priskirtiVisiems.Location = new Point(558, 398);
            btb_priskirtiVisiems.Name = "btb_priskirtiVisiems";
            btb_priskirtiVisiems.Size = new Size(155, 23);
            btb_priskirtiVisiems.TabIndex = 18;
            btb_priskirtiVisiems.Text = "Priskirti visiems";
            btb_priskirtiVisiems.UseVisualStyleBackColor = true;
            btb_priskirtiVisiems.Click += btb_priskirtiVisiems_Click;
            // 
            // btn_priskirtiVienam
            // 
            btn_priskirtiVienam.Location = new Point(719, 398);
            btn_priskirtiVienam.Name = "btn_priskirtiVienam";
            btn_priskirtiVienam.Size = new Size(155, 23);
            btn_priskirtiVienam.TabIndex = 19;
            btn_priskirtiVienam.Text = "Priskirti pasirinktam vart.";
            btn_priskirtiVienam.UseVisualStyleBackColor = true;
            btn_priskirtiVienam.Click += btn_priskirtiVienam_Click;
            // 
            // btn_atnaujinti
            // 
            btn_atnaujinti.Location = new Point(1110, 398);
            btn_atnaujinti.Name = "btn_atnaujinti";
            btn_atnaujinti.Size = new Size(155, 23);
            btn_atnaujinti.TabIndex = 20;
            btn_atnaujinti.Text = "Atnaujinti";
            btn_atnaujinti.UseVisualStyleBackColor = true;
            btn_atnaujinti.Click += btn_atnaujinti_Click;
            // 
            // lbl_pasirinktasMokestis
            // 
            lbl_pasirinktasMokestis.AutoSize = true;
            lbl_pasirinktasMokestis.Location = new Point(722, 24);
            lbl_pasirinktasMokestis.Name = "lbl_pasirinktasMokestis";
            lbl_pasirinktasMokestis.Size = new Size(116, 15);
            lbl_pasirinktasMokestis.TabIndex = 21;
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis:";
            // 
            // lbl_pasirinktasGyventojas
            // 
            lbl_pasirinktasGyventojas.AutoSize = true;
            lbl_pasirinktasGyventojas.Location = new Point(722, 53);
            lbl_pasirinktasGyventojas.Name = "lbl_pasirinktasGyventojas";
            lbl_pasirinktasGyventojas.Size = new Size(127, 15);
            lbl_pasirinktasGyventojas.TabIndex = 22;
            lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas:";
            // 
            // btb_perziuretiVartotoja
            // 
            btb_perziuretiVartotoja.Location = new Point(916, 398);
            btb_perziuretiVartotoja.Name = "btb_perziuretiVartotoja";
            btb_perziuretiVartotoja.Size = new Size(155, 23);
            btb_perziuretiVartotoja.TabIndex = 23;
            btb_perziuretiVartotoja.Text = "Peržiūrėti Vartotoją";
            btb_perziuretiVartotoja.UseVisualStyleBackColor = true;
            btb_perziuretiVartotoja.Click += btb_perziuretiVartotoja_Click;
            // 
            // Forma_Vadybininkams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1280, 766);
            Controls.Add(btb_perziuretiVartotoja);
            Controls.Add(lbl_pasirinktasGyventojas);
            Controls.Add(lbl_pasirinktasMokestis);
            Controls.Add(btn_atnaujinti);
            Controls.Add(btn_priskirtiVienam);
            Controls.Add(btb_priskirtiVisiems);
            Controls.Add(btn_sukurtiNauja);
            Controls.Add(btb_istrintiMokesti);
            Controls.Add(btn_keistiMokesti);
            Controls.Add(dtgrdGyventojai);
            Controls.Add(label1);
            Controls.Add(dtgrdMokesciai);
            Controls.Add(lbl_grupesMokesciai);
            Controls.Add(lbl_ID);
            Controls.Add(lbl_grupesAdresas);
            Controls.Add(btn_apieVartotoja);
            Controls.Add(lbl_priskirtas);
            Controls.Add(lbl_prisijunges);
            Controls.Add(lbl_vartVardas);
            Name = "Forma_Vadybininkams";
            Text = "Forma_Vadybininkams";
            Load += Forma_Vadybininkams_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrdMokesciai).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrdGyventojai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_grupesAdresas;
        private Button btn_apieVartotoja;
        private Label lbl_priskirtas;
        private Label lbl_prisijunges;
        private Label lbl_vartVardas;
        private Label lbl_ID;
        private Label lbl_grupesMokesciai;
        private DataGridView dtgrdMokesciai;
        private Label label1;
        private DataGridView dtgrdGyventojai;
        private Button btn_keistiMokesti;
        private Button btb_istrintiMokesti;
        private Button btn_sukurtiNauja;
        private Button btb_priskirtiVisiems;
        private Button btn_priskirtiVienam;
        private Button btn_atnaujinti;
        private Label lbl_pasirinktasMokestis;
        private Label lbl_pasirinktasGyventojas;
        private Button btb_perziuretiVartotoja;
    }
}