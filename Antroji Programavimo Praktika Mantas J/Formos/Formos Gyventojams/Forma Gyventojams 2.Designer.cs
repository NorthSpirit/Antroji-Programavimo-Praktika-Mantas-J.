namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
{
    partial class Forma_Gyventojams_2
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btb_pakeisti = new Button();
            lbl_pakeistiKa = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Vartotojo ID: ####";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 1;
            label2.Text = "Vartotojo Paskyros Vardas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Vartoto Vardas:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 3;
            label4.Text = "Vartotojo Pavarde: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "El. Paštas:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 147);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefono Nr.:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 173);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 6;
            label7.Text = "Gyvenamoji Vieta: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 200);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 7;
            label8.Text = "Gimimo Data:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 225);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 8;
            label9.Text = "Permoka:";
            // 
            // btb_pakeisti
            // 
            btb_pakeisti.Location = new Point(13, 339);
            btb_pakeisti.Name = "btb_pakeisti";
            btb_pakeisti.Size = new Size(75, 23);
            btb_pakeisti.TabIndex = 9;
            btb_pakeisti.Text = "Pakeisti";
            btb_pakeisti.UseVisualStyleBackColor = true;
            btb_pakeisti.Click += btb_pakeisti_Click;
            // 
            // lbl_pakeistiKa
            // 
            lbl_pakeistiKa.AutoSize = true;
            lbl_pakeistiKa.Location = new Point(12, 278);
            lbl_pakeistiKa.Name = "lbl_pakeistiKa";
            lbl_pakeistiKa.Size = new Size(83, 15);
            lbl_pakeistiKa.TabIndex = 10;
            lbl_pakeistiKa.Text = "Pakeisti tel. nr.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 11;
            // 
            // Forma_Gyventojams_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lbl_pakeistiKa);
            Controls.Add(btb_pakeisti);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Forma_Gyventojams_2";
            Text = "Forma_Gyventojams_2";
            Load += Forma_Gyventojams_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btb_pakeisti;
        private Label lbl_pakeistiKa;
        private TextBox textBox1;
    }
}