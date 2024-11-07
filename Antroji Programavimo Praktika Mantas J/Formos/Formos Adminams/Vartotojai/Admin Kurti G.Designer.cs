namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai
{
    partial class Admin_Kurti_G
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tb_vardas = new TextBox();
            tb_pavarde = new TextBox();
            tb_pastas = new TextBox();
            tb_telNr = new TextBox();
            tb_vieta = new TextBox();
            tb_data = new TextBox();
            lbl_extra = new Label();
            btn_sukurti = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 165);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 14;
            label8.Text = "Gimimo Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 136);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 13;
            label7.Text = "Gyvenamoji Vieta: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 107);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefono Nr.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 78);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 11;
            label5.Text = "El. Paštas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 49);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 10;
            label4.Text = "Vartotojo Pavarde: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 20);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 9;
            label3.Text = "Vartoto Vardas:";
            // 
            // tb_vardas
            // 
            tb_vardas.Location = new Point(125, 17);
            tb_vardas.Name = "tb_vardas";
            tb_vardas.Size = new Size(252, 23);
            tb_vardas.TabIndex = 15;
            // 
            // tb_pavarde
            // 
            tb_pavarde.Location = new Point(125, 46);
            tb_pavarde.Name = "tb_pavarde";
            tb_pavarde.Size = new Size(252, 23);
            tb_pavarde.TabIndex = 16;
            // 
            // tb_pastas
            // 
            tb_pastas.Location = new Point(125, 75);
            tb_pastas.Name = "tb_pastas";
            tb_pastas.Size = new Size(252, 23);
            tb_pastas.TabIndex = 17;
            // 
            // tb_telNr
            // 
            tb_telNr.Location = new Point(125, 104);
            tb_telNr.Name = "tb_telNr";
            tb_telNr.Size = new Size(252, 23);
            tb_telNr.TabIndex = 18;
            // 
            // tb_vieta
            // 
            tb_vieta.Location = new Point(125, 133);
            tb_vieta.Name = "tb_vieta";
            tb_vieta.Size = new Size(252, 23);
            tb_vieta.TabIndex = 19;
            // 
            // tb_data
            // 
            tb_data.Location = new Point(125, 162);
            tb_data.Name = "tb_data";
            tb_data.Size = new Size(252, 23);
            tb_data.TabIndex = 20;
            // 
            // lbl_extra
            // 
            lbl_extra.AutoSize = true;
            lbl_extra.Location = new Point(125, 210);
            lbl_extra.Name = "lbl_extra";
            lbl_extra.Size = new Size(46, 15);
            lbl_extra.TabIndex = 21;
            lbl_extra.Text = "ERROR!";
            // 
            // btn_sukurti
            // 
            btn_sukurti.Location = new Point(14, 206);
            btn_sukurti.Name = "btn_sukurti";
            btn_sukurti.Size = new Size(105, 23);
            btn_sukurti.TabIndex = 22;
            btn_sukurti.Text = "Sukurti";
            btn_sukurti.UseVisualStyleBackColor = true;
            btn_sukurti.Click += btn_sukurti_Click;
            // 
            // Admin_Kurti_G
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 260);
            Controls.Add(btn_sukurti);
            Controls.Add(lbl_extra);
            Controls.Add(tb_data);
            Controls.Add(tb_vieta);
            Controls.Add(tb_telNr);
            Controls.Add(tb_pastas);
            Controls.Add(tb_pavarde);
            Controls.Add(tb_vardas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Admin_Kurti_G";
            Text = "Admin_Kurti_G";
            Load += Admin_Kurti_G_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tb_vardas;
        private TextBox tb_pavarde;
        private TextBox tb_pastas;
        private TextBox tb_telNr;
        private TextBox tb_vieta;
        private TextBox tb_data;
        private Label lbl_extra;
        private Button btn_sukurti;
    }
}