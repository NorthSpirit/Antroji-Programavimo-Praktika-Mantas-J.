namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    partial class Paslaugos_Sukurimas
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
            lbl_klaida = new Label();
            tb_Ikaitis = new TextBox();
            tb_matoVienetas = new TextBox();
            tb_pavadinimas = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_atsaukti = new Button();
            btn_isaugoti = new Button();
            SuspendLayout();
            // 
            // lbl_klaida
            // 
            lbl_klaida.AutoSize = true;
            lbl_klaida.Location = new Point(111, 167);
            lbl_klaida.Name = "lbl_klaida";
            lbl_klaida.Size = new Size(0, 15);
            lbl_klaida.TabIndex = 16;
            // 
            // tb_Ikaitis
            // 
            tb_Ikaitis.Location = new Point(12, 159);
            tb_Ikaitis.Name = "tb_Ikaitis";
            tb_Ikaitis.Size = new Size(93, 23);
            tb_Ikaitis.TabIndex = 15;
            // 
            // tb_matoVienetas
            // 
            tb_matoVienetas.Location = new Point(12, 90);
            tb_matoVienetas.Name = "tb_matoVienetas";
            tb_matoVienetas.Size = new Size(240, 23);
            tb_matoVienetas.TabIndex = 14;
            // 
            // tb_pavadinimas
            // 
            tb_pavadinimas.Location = new Point(12, 27);
            tb_pavadinimas.Name = "tb_pavadinimas";
            tb_pavadinimas.Size = new Size(240, 23);
            tb_pavadinimas.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 12;
            label3.Text = "Paslaugos Ikainis (Eurais)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 11;
            label2.Text = "Paslaugos Mato Vienetas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 10;
            label1.Text = "Paslaugos Pavadinimas";
            // 
            // btn_atsaukti
            // 
            btn_atsaukti.Location = new Point(357, 225);
            btn_atsaukti.Name = "btn_atsaukti";
            btn_atsaukti.Size = new Size(130, 23);
            btn_atsaukti.TabIndex = 18;
            btn_atsaukti.Text = "Atšaukti";
            btn_atsaukti.UseVisualStyleBackColor = true;
            btn_atsaukti.Click += btn_atsaukti_Click;
            // 
            // btn_isaugoti
            // 
            btn_isaugoti.Location = new Point(111, 225);
            btn_isaugoti.Name = "btn_isaugoti";
            btn_isaugoti.Size = new Size(130, 23);
            btn_isaugoti.TabIndex = 17;
            btn_isaugoti.Text = "Išsaugoti";
            btn_isaugoti.UseVisualStyleBackColor = true;
            btn_isaugoti.Click += btn_isaugoti_Click;
            // 
            // Paslaugos_Sukurimas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 300);
            Controls.Add(btn_atsaukti);
            Controls.Add(btn_isaugoti);
            Controls.Add(lbl_klaida);
            Controls.Add(tb_Ikaitis);
            Controls.Add(tb_matoVienetas);
            Controls.Add(tb_pavadinimas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Paslaugos_Sukurimas";
            Text = "Paslaugos_Sukurimas";
            Load += Paslaugos_Sukurimas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_klaida;
        private TextBox tb_Ikaitis;
        private TextBox tb_matoVienetas;
        private TextBox tb_pavadinimas;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_atsaukti;
        private Button btn_isaugoti;
    }
}