namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    partial class Admin_Kurti_Vady
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
            tb_telNr = new TextBox();
            tb_pastas = new TextBox();
            tb_pavarde = new TextBox();
            tb_vardas = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_sukurti = new Button();
            lbl_extra = new Label();
            SuspendLayout();
            // 
            // tb_telNr
            // 
            tb_telNr.Location = new Point(126, 104);
            tb_telNr.Name = "tb_telNr";
            tb_telNr.Size = new Size(252, 23);
            tb_telNr.TabIndex = 26;
            // 
            // tb_pastas
            // 
            tb_pastas.Location = new Point(126, 75);
            tb_pastas.Name = "tb_pastas";
            tb_pastas.Size = new Size(252, 23);
            tb_pastas.TabIndex = 25;
            // 
            // tb_pavarde
            // 
            tb_pavarde.Location = new Point(126, 46);
            tb_pavarde.Name = "tb_pavarde";
            tb_pavarde.Size = new Size(252, 23);
            tb_pavarde.TabIndex = 24;
            // 
            // tb_vardas
            // 
            tb_vardas.Location = new Point(126, 17);
            tb_vardas.Name = "tb_vardas";
            tb_vardas.Size = new Size(252, 23);
            tb_vardas.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 107);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 22;
            label6.Text = "Telefono Nr.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 78);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 21;
            label5.Text = "El. Paštas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 49);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 20;
            label4.Text = "Vartotojo Pavarde: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 20);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 19;
            label3.Text = "Vartoto Vardas:";
            // 
            // btn_sukurti
            // 
            btn_sukurti.Location = new Point(16, 138);
            btn_sukurti.Name = "btn_sukurti";
            btn_sukurti.Size = new Size(105, 23);
            btn_sukurti.TabIndex = 27;
            btn_sukurti.Text = "Sukurti";
            btn_sukurti.UseVisualStyleBackColor = true;
            btn_sukurti.Click += btn_sukurti_Click;
            // 
            // lbl_extra
            // 
            lbl_extra.AutoSize = true;
            lbl_extra.Location = new Point(127, 142);
            lbl_extra.Name = "lbl_extra";
            lbl_extra.Size = new Size(46, 15);
            lbl_extra.TabIndex = 28;
            lbl_extra.Text = "ERROR!";
            // 
            // Admin_Kurti_Vady
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 186);
            Controls.Add(lbl_extra);
            Controls.Add(btn_sukurti);
            Controls.Add(tb_telNr);
            Controls.Add(tb_pastas);
            Controls.Add(tb_pavarde);
            Controls.Add(tb_vardas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Admin_Kurti_Vady";
            Text = "Admin_Kurti_Vady";
            Load += Admin_Kurti_Vady_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_telNr;
        private TextBox tb_pastas;
        private TextBox tb_pavarde;
        private TextBox tb_vardas;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_sukurti;
        private Label lbl_extra;
    }
}