namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Adminai
{
    partial class Admin_Administratoriai
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
            dtgrd_administratoriai = new DataGridView();
            lbl_Administratoriai = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgrd_administratoriai).BeginInit();
            SuspendLayout();
            // 
            // dtgrd_administratoriai
            // 
            dtgrd_administratoriai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrd_administratoriai.Location = new Point(12, 38);
            dtgrd_administratoriai.Name = "dtgrd_administratoriai";
            dtgrd_administratoriai.Size = new Size(1231, 400);
            dtgrd_administratoriai.TabIndex = 30;
            // 
            // lbl_Administratoriai
            // 
            lbl_Administratoriai.AutoSize = true;
            lbl_Administratoriai.Location = new Point(12, 13);
            lbl_Administratoriai.Name = "lbl_Administratoriai";
            lbl_Administratoriai.Size = new Size(95, 15);
            lbl_Administratoriai.TabIndex = 29;
            lbl_Administratoriai.Text = "Administratoriai:";
            // 
            // Admin_Administratoriai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 449);
            Controls.Add(dtgrd_administratoriai);
            Controls.Add(lbl_Administratoriai);
            Name = "Admin_Administratoriai";
            Text = "Admin_Administratoriai";
            Load += Admin_Administratoriai_Load;
            ((System.ComponentModel.ISupportInitialize)dtgrd_administratoriai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgrd_administratoriai;
        private Label lbl_Administratoriai;
    }
}