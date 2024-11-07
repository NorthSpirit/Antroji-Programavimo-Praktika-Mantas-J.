namespace Antroji_Programavimo_Praktika_Mantas_J_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl_UserName = new Label();
            Lbl_Password = new Label();
            tb_userName = new TextBox();
            tb_password = new TextBox();
            btn_logIn = new Button();
            btn_test = new Button();
            lbl_extra = new Label();
            SuspendLayout();
            // 
            // Lbl_UserName
            // 
            Lbl_UserName.AutoSize = true;
            Lbl_UserName.Location = new Point(178, 144);
            Lbl_UserName.Name = "Lbl_UserName";
            Lbl_UserName.Size = new Size(68, 15);
            Lbl_UserName.TabIndex = 0;
            Lbl_UserName.Text = "User Name:";
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Location = new Point(186, 173);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(60, 15);
            Lbl_Password.TabIndex = 1;
            Lbl_Password.Text = "Password:";
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(262, 141);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(212, 23);
            tb_userName.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(262, 170);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(212, 23);
            tb_password.TabIndex = 3;
            // 
            // btn_logIn
            // 
            btn_logIn.BackColor = Color.DodgerBlue;
            btn_logIn.ForeColor = SystemColors.ActiveCaptionText;
            btn_logIn.Location = new Point(355, 213);
            btn_logIn.Name = "btn_logIn";
            btn_logIn.Size = new Size(119, 36);
            btn_logIn.TabIndex = 5;
            btn_logIn.Text = "Log In";
            btn_logIn.UseVisualStyleBackColor = false;
            btn_logIn.Click += btn_logIn_Click;
            // 
            // btn_test
            // 
            btn_test.Location = new Point(12, 12);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(26, 22);
            btn_test.TabIndex = 6;
            btn_test.Text = "D";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // lbl_extra
            // 
            lbl_extra.AutoSize = true;
            lbl_extra.Location = new Point(178, 261);
            lbl_extra.Name = "lbl_extra";
            lbl_extra.Size = new Size(38, 15);
            lbl_extra.TabIndex = 7;
            lbl_extra.Text = "label1";
            lbl_extra.Click += lbl_extra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 378);
            Controls.Add(lbl_extra);
            Controls.Add(btn_test);
            Controls.Add(btn_logIn);
            Controls.Add(tb_password);
            Controls.Add(tb_userName);
            Controls.Add(Lbl_Password);
            Controls.Add(Lbl_UserName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_UserName;
        private Label Lbl_Password;
        private TextBox tb_userName;
        private TextBox tb_password;
        private Button btn_logIn;
        private Button btn_test;
        private Label lbl_extra;
    }
}
