namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    partial class Admin_Sukurti_Grupe
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
            btn_atsaukti = new Button();
            btn_isaugoti = new Button();
            tb_grupesAdresas = new TextBox();
            tb_pavadinimas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbl_extra = new Label();
            SuspendLayout();
            // 
            // btn_atsaukti
            // 
            btn_atsaukti.Location = new Point(357, 225);
            btn_atsaukti.Name = "btn_atsaukti";
            btn_atsaukti.Size = new Size(130, 23);
            btn_atsaukti.TabIndex = 27;
            btn_atsaukti.Text = "Išeiti";
            btn_atsaukti.UseVisualStyleBackColor = true;
            btn_atsaukti.Click += btn_atsaukti_Click;
            // 
            // btn_isaugoti
            // 
            btn_isaugoti.Location = new Point(111, 225);
            btn_isaugoti.Name = "btn_isaugoti";
            btn_isaugoti.Size = new Size(130, 23);
            btn_isaugoti.TabIndex = 26;
            btn_isaugoti.Text = "Išsaugoti";
            btn_isaugoti.UseVisualStyleBackColor = true;
            btn_isaugoti.Click += btn_isaugoti_Click;
            // 
            // tb_grupesAdresas
            // 
            tb_grupesAdresas.Location = new Point(12, 90);
            tb_grupesAdresas.Name = "tb_grupesAdresas";
            tb_grupesAdresas.Size = new Size(240, 23);
            tb_grupesAdresas.TabIndex = 23;
            // 
            // tb_pavadinimas
            // 
            tb_pavadinimas.Location = new Point(12, 27);
            tb_pavadinimas.Name = "tb_pavadinimas";
            tb_pavadinimas.Size = new Size(240, 23);
            tb_pavadinimas.TabIndex = 22;
            tb_pavadinimas.TextChanged += tb_pavadinimas_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 20;
            label2.Text = "Grupės Adresas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 19;
            label1.Text = "Grupės Pavadinimas:";
            // 
            // lbl_extra
            // 
            lbl_extra.AutoSize = true;
            lbl_extra.Location = new Point(12, 134);
            lbl_extra.Name = "lbl_extra";
            lbl_extra.Size = new Size(38, 15);
            lbl_extra.TabIndex = 28;
            lbl_extra.Text = "label3";
            // 
            // Admin_Sukurti_Grupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 289);
            Controls.Add(lbl_extra);
            Controls.Add(btn_atsaukti);
            Controls.Add(btn_isaugoti);
            Controls.Add(tb_grupesAdresas);
            Controls.Add(tb_pavadinimas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Sukurti_Grupe";
            Text = "Admin_Sukurti_Grupe";
            Load += Admin_Sukurti_Grupe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_atsaukti;
        private Button btn_isaugoti;
        private TextBox tb_grupesAdresas;
        private TextBox tb_pavadinimas;
        private Label label2;
        private Label label1;
        private Label lbl_extra;
    }
}