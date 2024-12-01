namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    partial class Admin_Redaguoti_Grupe
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
            dtgrd_Paslaugos = new DataGridView();
            lbl_pasirinktaGrupeID = new Label();
            lbl_pasirinktaGrupeAdresas = new Label();
            lbl_grupesPav = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btn_issaugoti = new Button();
            btn_atstatyti = new Button();
            lbl_mokesciai = new Label();
            btn_sukurtiNauja = new Button();
            btb_istrintiMokesti = new Button();
            btn_keistiMokesti = new Button();
            lbl_pasirinktasMokestis = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgrd_Paslaugos).BeginInit();
            SuspendLayout();
            // 
            // dtgrd_Paslaugos
            // 
            dtgrd_Paslaugos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrd_Paslaugos.Location = new Point(12, 116);
            dtgrd_Paslaugos.Name = "dtgrd_Paslaugos";
            dtgrd_Paslaugos.Size = new Size(994, 322);
            dtgrd_Paslaugos.TabIndex = 0;
            dtgrd_Paslaugos.CellContentClick += dtgrd_Paslaugos_CellContentClick;
            // 
            // lbl_pasirinktaGrupeID
            // 
            lbl_pasirinktaGrupeID.AutoSize = true;
            lbl_pasirinktaGrupeID.Location = new Point(12, 9);
            lbl_pasirinktaGrupeID.Name = "lbl_pasirinktaGrupeID";
            lbl_pasirinktaGrupeID.Size = new Size(24, 15);
            lbl_pasirinktaGrupeID.TabIndex = 10;
            lbl_pasirinktaGrupeID.Text = "ID: ";
            lbl_pasirinktaGrupeID.Click += lbl_pasirinktaGrupeID_Click;
            // 
            // lbl_pasirinktaGrupeAdresas
            // 
            lbl_pasirinktaGrupeAdresas.AutoSize = true;
            lbl_pasirinktaGrupeAdresas.Location = new Point(179, 38);
            lbl_pasirinktaGrupeAdresas.Name = "lbl_pasirinktaGrupeAdresas";
            lbl_pasirinktaGrupeAdresas.Size = new Size(51, 15);
            lbl_pasirinktaGrupeAdresas.TabIndex = 9;
            lbl_pasirinktaGrupeAdresas.Text = "Adresas:";
            // 
            // lbl_grupesPav
            // 
            lbl_grupesPav.AutoSize = true;
            lbl_grupesPav.Location = new Point(110, 9);
            lbl_grupesPav.Name = "lbl_grupesPav";
            lbl_grupesPav.Size = new Size(120, 15);
            lbl_grupesPav.TabIndex = 8;
            lbl_grupesPav.Text = "Grupės Pavadinimas: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(236, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 23);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btn_issaugoti
            // 
            btn_issaugoti.Location = new Point(897, 9);
            btn_issaugoti.Name = "btn_issaugoti";
            btn_issaugoti.Size = new Size(109, 23);
            btn_issaugoti.TabIndex = 14;
            btn_issaugoti.Text = "Išsaugoti";
            btn_issaugoti.UseVisualStyleBackColor = true;
            btn_issaugoti.Click += btn_issaugoti_Click;
            // 
            // btn_atstatyti
            // 
            btn_atstatyti.Location = new Point(725, 9);
            btn_atstatyti.Name = "btn_atstatyti";
            btn_atstatyti.Size = new Size(109, 23);
            btn_atstatyti.TabIndex = 15;
            btn_atstatyti.Text = "Atstatyti";
            btn_atstatyti.UseVisualStyleBackColor = true;
            btn_atstatyti.Click += btn_atstatyti_Click;
            // 
            // lbl_mokesciai
            // 
            lbl_mokesciai.AutoSize = true;
            lbl_mokesciai.Location = new Point(12, 76);
            lbl_mokesciai.Name = "lbl_mokesciai";
            lbl_mokesciai.Size = new Size(103, 15);
            lbl_mokesciai.TabIndex = 16;
            lbl_mokesciai.Text = "Grupės Mokesčiai:";
            // 
            // btn_sukurtiNauja
            // 
            btn_sukurtiNauja.Location = new Point(851, 90);
            btn_sukurtiNauja.Name = "btn_sukurtiNauja";
            btn_sukurtiNauja.Size = new Size(155, 23);
            btn_sukurtiNauja.TabIndex = 20;
            btn_sukurtiNauja.Text = "Sukurti naują mokestį";
            btn_sukurtiNauja.UseVisualStyleBackColor = true;
            btn_sukurtiNauja.Click += btn_sukurtiNauja_Click;
            // 
            // btb_istrintiMokesti
            // 
            btb_istrintiMokesti.Location = new Point(686, 90);
            btb_istrintiMokesti.Name = "btb_istrintiMokesti";
            btb_istrintiMokesti.Size = new Size(159, 23);
            btb_istrintiMokesti.TabIndex = 19;
            btb_istrintiMokesti.Text = "Ištrinti Mokestį";
            btb_istrintiMokesti.UseVisualStyleBackColor = true;
            btb_istrintiMokesti.Click += btb_istrintiMokesti_Click;
            // 
            // btn_keistiMokesti
            // 
            btn_keistiMokesti.Location = new Point(513, 90);
            btn_keistiMokesti.Name = "btn_keistiMokesti";
            btn_keistiMokesti.Size = new Size(167, 23);
            btn_keistiMokesti.TabIndex = 18;
            btn_keistiMokesti.Text = "Keisti Mokestį";
            btn_keistiMokesti.UseVisualStyleBackColor = true;
            btn_keistiMokesti.Click += btn_keistiMokesti_Click;
            // 
            // lbl_pasirinktasMokestis
            // 
            lbl_pasirinktasMokestis.AutoSize = true;
            lbl_pasirinktasMokestis.Location = new Point(12, 94);
            lbl_pasirinktasMokestis.Name = "lbl_pasirinktasMokestis";
            lbl_pasirinktasMokestis.Size = new Size(116, 15);
            lbl_pasirinktasMokestis.TabIndex = 22;
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 23;
            label1.Text = "label1";
            // 
            // Admin_Redaguoti_Grupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(label1);
            Controls.Add(lbl_pasirinktasMokestis);
            Controls.Add(btn_sukurtiNauja);
            Controls.Add(btb_istrintiMokesti);
            Controls.Add(btn_keistiMokesti);
            Controls.Add(lbl_mokesciai);
            Controls.Add(btn_atstatyti);
            Controls.Add(btn_issaugoti);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbl_pasirinktaGrupeID);
            Controls.Add(lbl_pasirinktaGrupeAdresas);
            Controls.Add(lbl_grupesPav);
            Controls.Add(dtgrd_Paslaugos);
            Name = "Admin_Redaguoti_Grupe";
            Text = "Admin_Redaguoti_Grupe";
            Load += Admin_Redaguoti_Grupe_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrd_Paslaugos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgrd_Paslaugos;
        private Label lbl_pasirinktaGrupeID;
        private Label lbl_pasirinktaGrupeAdresas;
        private Label lbl_grupesPav;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_issaugoti;
        private Button btn_atstatyti;
        private Label lbl_mokesciai;
        private Button btn_sukurtiNauja;
        private Button btb_istrintiMokesti;
        private Button btn_keistiMokesti;
        private Label lbl_pasirinktasMokestis;
        private Label label1;
    }
}