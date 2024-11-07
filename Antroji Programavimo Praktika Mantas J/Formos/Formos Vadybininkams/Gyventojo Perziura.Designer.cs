namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    partial class Gyventojo_Perziura
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            dtgrd_mokejimai = new DataGridView();
            lbl_pasirinktasMokestis = new Label();
            btn_istrintiMokesti = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgrd_mokejimai).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 209);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 17;
            label9.Text = "Permoka:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 184);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 16;
            label8.Text = "Gimimo Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 157);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 15;
            label7.Text = "Gyvenamoji Vieta: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 131);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 14;
            label6.Text = "Telefono Nr.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 107);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "El. Paštas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 12;
            label4.Text = "Vartotojo Pavarde: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 11;
            label3.Text = "Vartoto Vardas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 10;
            label2.Text = "Vartotojo Paskyros Vardas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 9;
            label1.Text = "Vartotojo ID: ####";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 246);
            label10.Name = "label10";
            label10.Size = new Size(120, 15);
            label10.TabIndex = 18;
            label10.Text = "Gyventojo Mokesciai:";
            // 
            // dtgrd_mokejimai
            // 
            dtgrd_mokejimai.AllowUserToOrderColumns = true;
            dtgrd_mokejimai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgrd_mokejimai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrd_mokejimai.Location = new Point(13, 264);
            dtgrd_mokejimai.Name = "dtgrd_mokejimai";
            dtgrd_mokejimai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrd_mokejimai.Size = new Size(1127, 322);
            dtgrd_mokejimai.TabIndex = 19;
            dtgrd_mokejimai.CellContentClick += dtgrd_mokejimai_CellContentClick;
            // 
            // lbl_pasirinktasMokestis
            // 
            lbl_pasirinktasMokestis.AutoSize = true;
            lbl_pasirinktasMokestis.Location = new Point(408, 246);
            lbl_pasirinktasMokestis.Name = "lbl_pasirinktasMokestis";
            lbl_pasirinktasMokestis.Size = new Size(119, 15);
            lbl_pasirinktasMokestis.TabIndex = 20;
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            // 
            // btn_istrintiMokesti
            // 
            btn_istrintiMokesti.Location = new Point(1022, 235);
            btn_istrintiMokesti.Name = "btn_istrintiMokesti";
            btn_istrintiMokesti.Size = new Size(118, 23);
            btn_istrintiMokesti.TabIndex = 21;
            btn_istrintiMokesti.Text = "Ištrinti Mokestį";
            btn_istrintiMokesti.UseVisualStyleBackColor = true;
            btn_istrintiMokesti.Click += btn_istrintiMokesti_Click;
            // 
            // Gyventojo_Perziura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1145, 592);
            Controls.Add(btn_istrintiMokesti);
            Controls.Add(lbl_pasirinktasMokestis);
            Controls.Add(dtgrd_mokejimai);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gyventojo_Perziura";
            Text = "Gyventojo_Perziura";
            Load += Gyventojo_Perziura_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrd_mokejimai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private DataGridView dtgrd_mokejimai;
        private Label lbl_pasirinktasMokestis;
        private Button btn_istrintiMokesti;
    }
}