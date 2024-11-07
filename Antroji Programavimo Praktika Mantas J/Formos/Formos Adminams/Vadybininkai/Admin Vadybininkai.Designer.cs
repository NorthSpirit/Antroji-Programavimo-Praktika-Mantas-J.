namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    partial class Admin_Vadybininkai
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
            btn_atskirti = new Button();
            btn_kurti = new Button();
            btn_priskirti = new Button();
            btn_istrinti = new Button();
            btn_redaguoti = new Button();
            btn_rodytiNepriskirtus = new Button();
            lbl_pasirinktasGyventojas = new Label();
            dtgrd_gyventojai = new DataGridView();
            btn_rodytiGrupes = new Button();
            btn_rodytiVisus = new Button();
            lbl_Gyventojai = new Label();
            lbl_pasirinktaGrupeID = new Label();
            lbl_pasirinktaGrupeAdresas = new Label();
            lbl_pasirinktaGrupe = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgrd_gyventojai).BeginInit();
            SuspendLayout();
            // 
            // btn_atskirti
            // 
            btn_atskirti.Location = new Point(714, 73);
            btn_atskirti.Name = "btn_atskirti";
            btn_atskirti.Size = new Size(119, 23);
            btn_atskirti.TabIndex = 35;
            btn_atskirti.Text = "Atskirti";
            btn_atskirti.UseVisualStyleBackColor = true;
            btn_atskirti.Click += btn_atskirti_Click;
            // 
            // btn_kurti
            // 
            btn_kurti.Location = new Point(964, 72);
            btn_kurti.Name = "btn_kurti";
            btn_kurti.Size = new Size(119, 23);
            btn_kurti.TabIndex = 34;
            btn_kurti.Text = "Kurti Naują";
            btn_kurti.UseVisualStyleBackColor = true;
            btn_kurti.Click += btn_kurti_Click;
            // 
            // btn_priskirti
            // 
            btn_priskirti.Location = new Point(589, 73);
            btn_priskirti.Name = "btn_priskirti";
            btn_priskirti.Size = new Size(119, 23);
            btn_priskirti.TabIndex = 33;
            btn_priskirti.Text = "Priskirti";
            btn_priskirti.UseVisualStyleBackColor = true;
            btn_priskirti.Click += btn_priskirti_Click;
            // 
            // btn_istrinti
            // 
            btn_istrinti.Location = new Point(1124, 73);
            btn_istrinti.Name = "btn_istrinti";
            btn_istrinti.Size = new Size(119, 23);
            btn_istrinti.TabIndex = 32;
            btn_istrinti.Text = "Ištrinti";
            btn_istrinti.UseVisualStyleBackColor = true;
            btn_istrinti.Click += btn_istrinti_Click;
            // 
            // btn_redaguoti
            // 
            btn_redaguoti.Location = new Point(839, 73);
            btn_redaguoti.Name = "btn_redaguoti";
            btn_redaguoti.Size = new Size(119, 23);
            btn_redaguoti.TabIndex = 31;
            btn_redaguoti.Text = "Redaguoti";
            btn_redaguoti.UseVisualStyleBackColor = true;
            btn_redaguoti.Click += btn_redaguoti_Click;
            // 
            // btn_rodytiNepriskirtus
            // 
            btn_rodytiNepriskirtus.Location = new Point(431, 73);
            btn_rodytiNepriskirtus.Name = "btn_rodytiNepriskirtus";
            btn_rodytiNepriskirtus.Size = new Size(119, 23);
            btn_rodytiNepriskirtus.TabIndex = 30;
            btn_rodytiNepriskirtus.Text = "Rodyti Nepriskirtus";
            btn_rodytiNepriskirtus.UseVisualStyleBackColor = true;
            btn_rodytiNepriskirtus.Click += btn_rodytiNepriskirtus_Click;
            // 
            // lbl_pasirinktasGyventojas
            // 
            lbl_pasirinktasGyventojas.AutoSize = true;
            lbl_pasirinktasGyventojas.Location = new Point(589, 47);
            lbl_pasirinktasGyventojas.Name = "lbl_pasirinktasGyventojas";
            lbl_pasirinktasGyventojas.Size = new Size(130, 15);
            lbl_pasirinktasGyventojas.TabIndex = 29;
            lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
            // 
            // dtgrd_gyventojai
            // 
            dtgrd_gyventojai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrd_gyventojai.Location = new Point(12, 102);
            dtgrd_gyventojai.Name = "dtgrd_gyventojai";
            dtgrd_gyventojai.Size = new Size(1231, 400);
            dtgrd_gyventojai.TabIndex = 28;
            dtgrd_gyventojai.CellContentClick += dtgrd_gyventojai_CellContentClick_1;
            // 
            // btn_rodytiGrupes
            // 
            btn_rodytiGrupes.Location = new Point(181, 73);
            btn_rodytiGrupes.Name = "btn_rodytiGrupes";
            btn_rodytiGrupes.Size = new Size(119, 23);
            btn_rodytiGrupes.TabIndex = 27;
            btn_rodytiGrupes.Text = "Rodyti Grupės";
            btn_rodytiGrupes.UseVisualStyleBackColor = true;
            btn_rodytiGrupes.Click += btn_rodytiGrupes_Click;
            // 
            // btn_rodytiVisus
            // 
            btn_rodytiVisus.Location = new Point(306, 73);
            btn_rodytiVisus.Name = "btn_rodytiVisus";
            btn_rodytiVisus.Size = new Size(119, 23);
            btn_rodytiVisus.TabIndex = 26;
            btn_rodytiVisus.Text = "Rodyti Visus";
            btn_rodytiVisus.UseVisualStyleBackColor = true;
            btn_rodytiVisus.Click += btn_rodytiVisus_Click;
            // 
            // lbl_Gyventojai
            // 
            lbl_Gyventojai.AutoSize = true;
            lbl_Gyventojai.Location = new Point(12, 77);
            lbl_Gyventojai.Name = "lbl_Gyventojai";
            lbl_Gyventojai.Size = new Size(66, 15);
            lbl_Gyventojai.TabIndex = 25;
            lbl_Gyventojai.Text = "Gyventojai:";
            // 
            // lbl_pasirinktaGrupeID
            // 
            lbl_pasirinktaGrupeID.AutoSize = true;
            lbl_pasirinktaGrupeID.Location = new Point(12, 24);
            lbl_pasirinktaGrupeID.Name = "lbl_pasirinktaGrupeID";
            lbl_pasirinktaGrupeID.Size = new Size(24, 15);
            lbl_pasirinktaGrupeID.TabIndex = 24;
            lbl_pasirinktaGrupeID.Text = "ID: ";
            // 
            // lbl_pasirinktaGrupeAdresas
            // 
            lbl_pasirinktaGrupeAdresas.AutoSize = true;
            lbl_pasirinktaGrupeAdresas.Location = new Point(12, 47);
            lbl_pasirinktaGrupeAdresas.Name = "lbl_pasirinktaGrupeAdresas";
            lbl_pasirinktaGrupeAdresas.Size = new Size(51, 15);
            lbl_pasirinktaGrupeAdresas.TabIndex = 23;
            lbl_pasirinktaGrupeAdresas.Text = "Adresas:";
            // 
            // lbl_pasirinktaGrupe
            // 
            lbl_pasirinktaGrupe.AutoSize = true;
            lbl_pasirinktaGrupe.Location = new Point(12, 9);
            lbl_pasirinktaGrupe.Name = "lbl_pasirinktaGrupe";
            lbl_pasirinktaGrupe.Size = new Size(99, 15);
            lbl_pasirinktaGrupe.TabIndex = 22;
            lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: ";
            // 
            // Admin_Vadybininkai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 510);
            Controls.Add(btn_atskirti);
            Controls.Add(btn_kurti);
            Controls.Add(btn_priskirti);
            Controls.Add(btn_istrinti);
            Controls.Add(btn_redaguoti);
            Controls.Add(btn_rodytiNepriskirtus);
            Controls.Add(lbl_pasirinktasGyventojas);
            Controls.Add(dtgrd_gyventojai);
            Controls.Add(btn_rodytiGrupes);
            Controls.Add(btn_rodytiVisus);
            Controls.Add(lbl_Gyventojai);
            Controls.Add(lbl_pasirinktaGrupeID);
            Controls.Add(lbl_pasirinktaGrupeAdresas);
            Controls.Add(lbl_pasirinktaGrupe);
            Name = "Admin_Vadybininkai";
            Text = "Admin_Vadybininkai";
            Load += Admin_Vadybininkai_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrd_gyventojai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_atskirti;
        private Button btn_kurti;
        private Button btn_priskirti;
        private Button btn_istrinti;
        private Button btn_redaguoti;
        private Button btn_rodytiNepriskirtus;
        private Label lbl_pasirinktasGyventojas;
        private DataGridView dtgrd_gyventojai;
        private Button btn_rodytiGrupes;
        private Button btn_rodytiVisus;
        private Label lbl_Gyventojai;
        private Label lbl_pasirinktaGrupeID;
        private Label lbl_pasirinktaGrupeAdresas;
        private Label lbl_pasirinktaGrupe;
    }
}