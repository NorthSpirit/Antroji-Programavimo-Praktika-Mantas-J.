namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    partial class Paslaugos_Keitimas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_pavadinimas = new TextBox();
            tb_matoVienetas = new TextBox();
            tb_Ikaitis = new TextBox();
            btn_atstatyti = new Button();
            btn_isaugoti = new Button();
            btn_atsaukti = new Button();
            lbl_klaida = new Label();
            lbl_error = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Paslaugos Pavadinimas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Paslaugos Mato Vienetas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 156);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 2;
            label3.Text = "Paslaugos Ikainis (Eurais)";
            // 
            // tb_pavadinimas
            // 
            tb_pavadinimas.Location = new Point(23, 42);
            tb_pavadinimas.Name = "tb_pavadinimas";
            tb_pavadinimas.Size = new Size(240, 23);
            tb_pavadinimas.TabIndex = 3;
            // 
            // tb_matoVienetas
            // 
            tb_matoVienetas.Location = new Point(23, 105);
            tb_matoVienetas.Name = "tb_matoVienetas";
            tb_matoVienetas.Size = new Size(240, 23);
            tb_matoVienetas.TabIndex = 4;
            // 
            // tb_Ikaitis
            // 
            tb_Ikaitis.Location = new Point(23, 174);
            tb_Ikaitis.Name = "tb_Ikaitis";
            tb_Ikaitis.Size = new Size(93, 23);
            tb_Ikaitis.TabIndex = 5;
            // 
            // btn_atstatyti
            // 
            btn_atstatyti.Location = new Point(23, 227);
            btn_atstatyti.Name = "btn_atstatyti";
            btn_atstatyti.Size = new Size(130, 23);
            btn_atstatyti.TabIndex = 6;
            btn_atstatyti.Text = "Atstatyti";
            btn_atstatyti.UseVisualStyleBackColor = true;
            btn_atstatyti.Click += btn_atstatyti_Click;
            // 
            // btn_isaugoti
            // 
            btn_isaugoti.Location = new Point(266, 227);
            btn_isaugoti.Name = "btn_isaugoti";
            btn_isaugoti.Size = new Size(130, 23);
            btn_isaugoti.TabIndex = 7;
            btn_isaugoti.Text = "Išsaugoti";
            btn_isaugoti.UseVisualStyleBackColor = true;
            btn_isaugoti.Click += btn_isaugoti_Click;
            // 
            // btn_atsaukti
            // 
            btn_atsaukti.Location = new Point(418, 227);
            btn_atsaukti.Name = "btn_atsaukti";
            btn_atsaukti.Size = new Size(130, 23);
            btn_atsaukti.TabIndex = 8;
            btn_atsaukti.Text = "Atšaukti";
            btn_atsaukti.UseVisualStyleBackColor = true;
            btn_atsaukti.Click += btn_atsaukti_Click;
            // 
            // lbl_klaida
            // 
            lbl_klaida.AutoSize = true;
            lbl_klaida.Location = new Point(122, 182);
            lbl_klaida.Name = "lbl_klaida";
            lbl_klaida.Size = new Size(0, 15);
            lbl_klaida.TabIndex = 9;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(23, 253);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(38, 15);
            lbl_error.TabIndex = 10;
            lbl_error.Text = "label4";
            // 
            // Paslaugos_Keitimas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 289);
            Controls.Add(lbl_error);
            Controls.Add(lbl_klaida);
            Controls.Add(btn_atsaukti);
            Controls.Add(btn_isaugoti);
            Controls.Add(btn_atstatyti);
            Controls.Add(tb_Ikaitis);
            Controls.Add(tb_matoVienetas);
            Controls.Add(tb_pavadinimas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Paslaugos_Keitimas";
            Text = "Paslaugos_Keitimas";
            Load += Paslaugos_Keitimas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_pavadinimas;
        private TextBox tb_matoVienetas;
        private TextBox tb_Ikaitis;
        private Button btn_atstatyti;
        private Button btn_isaugoti;
        private Button btn_atsaukti;
        private Label lbl_klaida;
        private Label lbl_error;
    }
}