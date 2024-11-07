namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    partial class Forma_Adminams
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
            lbl_ID = new Label();
            lbl_prisijunges = new Label();
            lbl_vartVardas = new Label();
            btn_perziuretiGyv = new Button();
            btn_perziuretiVad = new Button();
            btn_perziuretiAdmin = new Button();
            btn_perziuretiGrupes = new Button();
            lbl_pasirinktaGrupe = new Label();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(12, 33);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(24, 15);
            lbl_ID.TabIndex = 13;
            lbl_ID.Text = "ID: ";
            lbl_ID.Click += lbl_ID_Click;
            // 
            // lbl_prisijunges
            // 
            lbl_prisijunges.AutoSize = true;
            lbl_prisijunges.Location = new Point(12, 9);
            lbl_prisijunges.Name = "lbl_prisijunges";
            lbl_prisijunges.Size = new Size(139, 15);
            lbl_prisijunges.TabIndex = 12;
            lbl_prisijunges.Text = "Prisijungęs Vadybininkas:";
            lbl_prisijunges.Click += lbl_prisijunges_Click_1;
            // 
            // lbl_vartVardas
            // 
            lbl_vartVardas.AutoSize = true;
            lbl_vartVardas.Location = new Point(157, 9);
            lbl_vartVardas.Name = "lbl_vartVardas";
            lbl_vartVardas.Size = new Size(0, 15);
            lbl_vartVardas.TabIndex = 11;
            // 
            // btn_perziuretiGyv
            // 
            btn_perziuretiGyv.Location = new Point(12, 125);
            btn_perziuretiGyv.Name = "btn_perziuretiGyv";
            btn_perziuretiGyv.Size = new Size(162, 23);
            btn_perziuretiGyv.TabIndex = 14;
            btn_perziuretiGyv.Text = "Peržiūrėti Gyventojus";
            btn_perziuretiGyv.UseVisualStyleBackColor = true;
            btn_perziuretiGyv.Click += btn_perziuretiGyv_Click;
            // 
            // btn_perziuretiVad
            // 
            btn_perziuretiVad.Location = new Point(12, 154);
            btn_perziuretiVad.Name = "btn_perziuretiVad";
            btn_perziuretiVad.Size = new Size(162, 23);
            btn_perziuretiVad.TabIndex = 15;
            btn_perziuretiVad.Text = "Peržiūrėti Vadybininkus";
            btn_perziuretiVad.UseVisualStyleBackColor = true;
            btn_perziuretiVad.Click += btn_perziuretiVad_Click;
            // 
            // btn_perziuretiAdmin
            // 
            btn_perziuretiAdmin.Location = new Point(12, 183);
            btn_perziuretiAdmin.Name = "btn_perziuretiAdmin";
            btn_perziuretiAdmin.Size = new Size(162, 23);
            btn_perziuretiAdmin.TabIndex = 16;
            btn_perziuretiAdmin.Text = "Peržiūrėti Administratorius";
            btn_perziuretiAdmin.UseVisualStyleBackColor = true;
            btn_perziuretiAdmin.Click += btn_perziuretiAdmin_Click;
            // 
            // btn_perziuretiGrupes
            // 
            btn_perziuretiGrupes.Location = new Point(12, 60);
            btn_perziuretiGrupes.Name = "btn_perziuretiGrupes";
            btn_perziuretiGrupes.Size = new Size(162, 23);
            btn_perziuretiGrupes.TabIndex = 17;
            btn_perziuretiGrupes.Text = "Peržiūrėti Vart. Grupes";
            btn_perziuretiGrupes.UseVisualStyleBackColor = true;
            btn_perziuretiGrupes.Click += btn_perziuretiGrupes_Click;
            // 
            // lbl_pasirinktaGrupe
            // 
            lbl_pasirinktaGrupe.AutoSize = true;
            lbl_pasirinktaGrupe.Location = new Point(180, 64);
            lbl_pasirinktaGrupe.Name = "lbl_pasirinktaGrupe";
            lbl_pasirinktaGrupe.Size = new Size(168, 15);
            lbl_pasirinktaGrupe.TabIndex = 18;
            lbl_pasirinktaGrupe.Text = "Pasirinkta Grupe: TEXTTEXTEXT";
            // 
            // Forma_Adminams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_pasirinktaGrupe);
            Controls.Add(btn_perziuretiGrupes);
            Controls.Add(btn_perziuretiAdmin);
            Controls.Add(btn_perziuretiVad);
            Controls.Add(btn_perziuretiGyv);
            Controls.Add(lbl_ID);
            Controls.Add(lbl_prisijunges);
            Controls.Add(lbl_vartVardas);
            Name = "Forma_Adminams";
            Text = "Forma_Adminams";
            Load += Forma_Adminams_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ID;
        private Label lbl_prisijunges;
        private Label lbl_vartVardas;
        private Button btn_perziuretiGyv;
        private Button btn_perziuretiVad;
        private Button btn_perziuretiAdmin;
        private Button btn_perziuretiGrupes;
        private Label lbl_pasirinktaGrupe;
    }
}