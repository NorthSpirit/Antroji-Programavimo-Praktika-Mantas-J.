namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    partial class Admin_Redaguoti_Vady
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
            tb_elPastas = new TextBox();
            tb_pavarde = new TextBox();
            tb_vardas = new TextBox();
            tb_paskyrosVardas = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_telNr = new TextBox();
            label6 = new Label();
            lbl_error = new Label();
            btn_atstatyti = new Button();
            btn_issaugoti = new Button();
            btn_slaptazodis = new Button();
            SuspendLayout();
            // 
            // tb_elPastas
            // 
            tb_elPastas.Location = new Point(162, 117);
            tb_elPastas.Name = "tb_elPastas";
            tb_elPastas.Size = new Size(329, 23);
            tb_elPastas.TabIndex = 31;
            // 
            // tb_pavarde
            // 
            tb_pavarde.Location = new Point(162, 88);
            tb_pavarde.Name = "tb_pavarde";
            tb_pavarde.Size = new Size(329, 23);
            tb_pavarde.TabIndex = 30;
            // 
            // tb_vardas
            // 
            tb_vardas.Location = new Point(162, 59);
            tb_vardas.Name = "tb_vardas";
            tb_vardas.Size = new Size(329, 23);
            tb_vardas.TabIndex = 29;
            // 
            // tb_paskyrosVardas
            // 
            tb_paskyrosVardas.Location = new Point(162, 30);
            tb_paskyrosVardas.Name = "tb_paskyrosVardas";
            tb_paskyrosVardas.Size = new Size(329, 23);
            tb_paskyrosVardas.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 120);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 27;
            label5.Text = "El. Paštas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 91);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 26;
            label4.Text = "Vartotojo Pavarde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 62);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 25;
            label3.Text = "Vartoto Vardas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 24;
            label2.Text = "Vartotojo Paskyros Vardas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 23;
            label1.Text = "Vartotojo ID: ####";
            // 
            // tb_telNr
            // 
            tb_telNr.Location = new Point(162, 146);
            tb_telNr.Name = "tb_telNr";
            tb_telNr.Size = new Size(329, 23);
            tb_telNr.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 149);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 32;
            label6.Text = "Telefono Nr.:";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(31, 224);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(46, 15);
            lbl_error.TabIndex = 36;
            lbl_error.Text = "ERROR:";
            // 
            // btn_atstatyti
            // 
            btn_atstatyti.Location = new Point(117, 191);
            btn_atstatyti.Name = "btn_atstatyti";
            btn_atstatyti.Size = new Size(75, 23);
            btn_atstatyti.TabIndex = 35;
            btn_atstatyti.Text = "atstatyti";
            btn_atstatyti.UseVisualStyleBackColor = true;
            btn_atstatyti.Click += btn_atstatyti_Click;
            // 
            // btn_issaugoti
            // 
            btn_issaugoti.Location = new Point(31, 191);
            btn_issaugoti.Name = "btn_issaugoti";
            btn_issaugoti.Size = new Size(75, 23);
            btn_issaugoti.TabIndex = 34;
            btn_issaugoti.Text = "Issaugoti";
            btn_issaugoti.UseVisualStyleBackColor = true;
            btn_issaugoti.Click += btn_issaugoti_Click;
            // 
            // btn_slaptazodis
            // 
            btn_slaptazodis.Location = new Point(334, 187);
            btn_slaptazodis.Name = "btn_slaptazodis";
            btn_slaptazodis.Size = new Size(157, 23);
            btn_slaptazodis.TabIndex = 38;
            btn_slaptazodis.Text = "Atstatyti Slaptažodį";
            btn_slaptazodis.UseVisualStyleBackColor = true;
            btn_slaptazodis.Click += btn_slaptazodis_Click;
            // 
            // Admin_Redaguoti_Vady
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 258);
            Controls.Add(btn_slaptazodis);
            Controls.Add(lbl_error);
            Controls.Add(btn_atstatyti);
            Controls.Add(btn_issaugoti);
            Controls.Add(tb_telNr);
            Controls.Add(label6);
            Controls.Add(tb_elPastas);
            Controls.Add(tb_pavarde);
            Controls.Add(tb_vardas);
            Controls.Add(tb_paskyrosVardas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Redaguoti_Vady";
            Text = "Admin_Redaguoti_Vady";
            Load += Admin_Redaguoti_Vady_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_elPastas;
        private TextBox tb_pavarde;
        private TextBox tb_vardas;
        private TextBox tb_paskyrosVardas;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_telNr;
        private Label label6;
        private Label lbl_error;
        private Button btn_atstatyti;
        private Button btn_issaugoti;
        private Button btn_slaptazodis;
    }
}