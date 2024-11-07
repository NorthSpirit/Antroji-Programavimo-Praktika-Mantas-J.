namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    partial class Admin_Perziureti_Grupes
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
            lbl_pasirinktaGrupe = new Label();
            btb_redaguoti = new Button();
            btb_istrintiGrupe = new Button();
            btn_sukurtiGrupe = new Button();
            dtgrd_vartGrupes = new DataGridView();
            btb_atnaujinti = new Button();
            lbl_pasirinktaGrupeAdresas = new Label();
            lbl_pasirinktaGrupeID = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgrd_vartGrupes).BeginInit();
            SuspendLayout();
            // 
            // lbl_pasirinktaGrupe
            // 
            lbl_pasirinktaGrupe.AutoSize = true;
            lbl_pasirinktaGrupe.Location = new Point(21, 21);
            lbl_pasirinktaGrupe.Name = "lbl_pasirinktaGrupe";
            lbl_pasirinktaGrupe.Size = new Size(99, 15);
            lbl_pasirinktaGrupe.TabIndex = 0;
            lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: ";
            // 
            // btb_redaguoti
            // 
            btb_redaguoti.Location = new Point(614, 17);
            btb_redaguoti.Name = "btb_redaguoti";
            btb_redaguoti.Size = new Size(108, 23);
            btb_redaguoti.TabIndex = 1;
            btb_redaguoti.Text = "Redaguoti Grupę";
            btb_redaguoti.UseVisualStyleBackColor = true;
            btb_redaguoti.Click += btb_redaguoti_Click;
            // 
            // btb_istrintiGrupe
            // 
            btb_istrintiGrupe.Location = new Point(728, 17);
            btb_istrintiGrupe.Name = "btb_istrintiGrupe";
            btb_istrintiGrupe.Size = new Size(108, 23);
            btb_istrintiGrupe.TabIndex = 2;
            btb_istrintiGrupe.Text = "Ištrinti Grupę";
            btb_istrintiGrupe.UseVisualStyleBackColor = true;
            btb_istrintiGrupe.Click += btb_istrintiGrupe_Click;
            // 
            // btn_sukurtiGrupe
            // 
            btn_sukurtiGrupe.Location = new Point(842, 17);
            btn_sukurtiGrupe.Name = "btn_sukurtiGrupe";
            btn_sukurtiGrupe.Size = new Size(108, 23);
            btn_sukurtiGrupe.TabIndex = 3;
            btn_sukurtiGrupe.Text = "Sukurti Grupę";
            btn_sukurtiGrupe.UseVisualStyleBackColor = true;
            btn_sukurtiGrupe.Click += btn_sukurtiGrupe_Click;
            // 
            // dtgrd_vartGrupes
            // 
            dtgrd_vartGrupes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgrd_vartGrupes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrd_vartGrupes.Location = new Point(21, 100);
            dtgrd_vartGrupes.Name = "dtgrd_vartGrupes";
            dtgrd_vartGrupes.Size = new Size(929, 338);
            dtgrd_vartGrupes.TabIndex = 4;
            dtgrd_vartGrupes.CellContentClick += dtgrd_vartGrupes_CellContentClick;
            // 
            // btb_atnaujinti
            // 
            btb_atnaujinti.Location = new Point(842, 59);
            btb_atnaujinti.Name = "btb_atnaujinti";
            btb_atnaujinti.Size = new Size(108, 23);
            btb_atnaujinti.TabIndex = 5;
            btb_atnaujinti.Text = "Atnaujinti";
            btb_atnaujinti.UseVisualStyleBackColor = true;
            btb_atnaujinti.Click += btb_atnaujinti_Click;
            // 
            // lbl_pasirinktaGrupeAdresas
            // 
            lbl_pasirinktaGrupeAdresas.AutoSize = true;
            lbl_pasirinktaGrupeAdresas.Location = new Point(21, 59);
            lbl_pasirinktaGrupeAdresas.Name = "lbl_pasirinktaGrupeAdresas";
            lbl_pasirinktaGrupeAdresas.Size = new Size(51, 15);
            lbl_pasirinktaGrupeAdresas.TabIndex = 6;
            lbl_pasirinktaGrupeAdresas.Text = "Adresas:";
            // 
            // lbl_pasirinktaGrupeID
            // 
            lbl_pasirinktaGrupeID.AutoSize = true;
            lbl_pasirinktaGrupeID.Location = new Point(21, 36);
            lbl_pasirinktaGrupeID.Name = "lbl_pasirinktaGrupeID";
            lbl_pasirinktaGrupeID.Size = new Size(24, 15);
            lbl_pasirinktaGrupeID.TabIndex = 7;
            lbl_pasirinktaGrupeID.Text = "ID: ";
            // 
            // Admin_Perziureti_Grupes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 450);
            Controls.Add(lbl_pasirinktaGrupeID);
            Controls.Add(lbl_pasirinktaGrupeAdresas);
            Controls.Add(btb_atnaujinti);
            Controls.Add(dtgrd_vartGrupes);
            Controls.Add(btn_sukurtiGrupe);
            Controls.Add(btb_istrintiGrupe);
            Controls.Add(btb_redaguoti);
            Controls.Add(lbl_pasirinktaGrupe);
            Name = "Admin_Perziureti_Grupes";
            Text = "Admin_Perziureti_Grupes";
            Load += Admin_Perziureti_Grupes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrd_vartGrupes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_pasirinktaGrupe;
        private Button btb_redaguoti;
        private Button btb_istrintiGrupe;
        private Button btn_sukurtiGrupe;
        private DataGridView dtgrd_vartGrupes;
        private Button btb_atnaujinti;
        private Label lbl_pasirinktaGrupeAdresas;
        private Label lbl_pasirinktaGrupeID;
    }
}