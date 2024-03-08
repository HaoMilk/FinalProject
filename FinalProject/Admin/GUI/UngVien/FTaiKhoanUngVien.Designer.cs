namespace FinalProject.Admin
{
    partial class FTaiKhoanUngVien
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
            this.label_Name = new System.Windows.Forms.Label();
            this.ucDanhSach1 = new FinalProject.UC.UCDanhSach();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Name.Location = new System.Drawing.Point(0, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(1004, 43);
            this.label_Name.TabIndex = 9;
            this.label_Name.Text = "DANH SÁCH TÀI KHOẢN ỨNG VIÊN";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Name.UseCompatibleTextRendering = true;
            // 
            // ucDanhSach1
            // 
            this.ucDanhSach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDanhSach1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDanhSach1.Location = new System.Drawing.Point(0, 43);
            this.ucDanhSach1.Margin = new System.Windows.Forms.Padding(4);
            this.ucDanhSach1.Name = "ucDanhSach1";
            this.ucDanhSach1.Size = new System.Drawing.Size(1004, 617);
            this.ucDanhSach1.TabIndex = 10;
            // 
            // FTaiKhoanUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 660);
            this.Controls.Add(this.ucDanhSach1);
            this.Controls.Add(this.label_Name);
            this.Name = "FTaiKhoanUngVien";
            this.Text = "FTaiKhoanUngVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private UC.UCDanhSach ucDanhSach1;
    }
}