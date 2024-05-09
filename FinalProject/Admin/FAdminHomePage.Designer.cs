namespace FinalProject.Admin
{
    partial class FAdminHomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.ucMenuCard_ViecLamUT = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_UngVien = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DashBoard = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DangXuat = new FinalProject.UC.UCMenuCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(770, 468);
            this.pictureBox_Image.TabIndex = 4;
            this.pictureBox_Image.TabStop = false;
            // 
            // ucMenuCard_ViecLamUT
            // 
            this.ucMenuCard_ViecLamUT.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_ViecLamUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_ViecLamUT.BorderRadious = 20;
            this.ucMenuCard_ViecLamUT.ButtonBackColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_ViecLamUT.ButtonTextColor = System.Drawing.SystemColors.Control;
            this.ucMenuCard_ViecLamUT.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_ViecLamUT.Id = 0;
            this.ucMenuCard_ViecLamUT.Location = new System.Drawing.Point(269, 58);
            this.ucMenuCard_ViecLamUT.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ViecLamUT.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ViecLamUT.MenuImage = global::FinalProject.Properties.Resources.icons8_resume_website_96;
            this.ucMenuCard_ViecLamUT.MenuName = "THỐNG KÊ CÔNG VIỆC";
            this.ucMenuCard_ViecLamUT.Name = "ucMenuCard_ViecLamUT";
            this.ucMenuCard_ViecLamUT.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ViecLamUT.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_ViecLamUT.TabIndex = 11;
            this.ucMenuCard_ViecLamUT.MenuClick += new System.EventHandler(this.ucMenuCard_ViecLamUT_MenuClick);
            // 
            // ucMenuCard_UngVien
            // 
            this.ucMenuCard_UngVien.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_UngVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_UngVien.BorderRadious = 20;
            this.ucMenuCard_UngVien.ButtonBackColor = System.Drawing.Color.Tomato;
            this.ucMenuCard_UngVien.ButtonTextColor = System.Drawing.SystemColors.Control;
            this.ucMenuCard_UngVien.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_UngVien.Id = 0;
            this.ucMenuCard_UngVien.Location = new System.Drawing.Point(526, 58);
            this.ucMenuCard_UngVien.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_UngVien.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_UngVien.MenuImage = global::FinalProject.Properties.Resources.daily_resumes_of_candidates_for_recruitment;
            this.ucMenuCard_UngVien.MenuName = "THỐNG KÊ ỨNG VIÊN";
            this.ucMenuCard_UngVien.Name = "ucMenuCard_UngVien";
            this.ucMenuCard_UngVien.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_UngVien.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_UngVien.TabIndex = 13;
            this.ucMenuCard_UngVien.MenuClick += new System.EventHandler(this.ucMenuCard_UngVien_MenuClick);
            // 
            // ucMenuCard_DashBoard
            // 
            this.ucMenuCard_DashBoard.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DashBoard.BorderRadious = 20;
            this.ucMenuCard_DashBoard.ButtonBackColor = System.Drawing.Color.Crimson;
            this.ucMenuCard_DashBoard.ButtonTextColor = System.Drawing.SystemColors.Control;
            this.ucMenuCard_DashBoard.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DashBoard.Id = 0;
            this.ucMenuCard_DashBoard.Location = new System.Drawing.Point(21, 58);
            this.ucMenuCard_DashBoard.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DashBoard.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DashBoard.MenuImage = global::FinalProject.Properties.Resources.char_icon;
            this.ucMenuCard_DashBoard.MenuName = "DASHBOARD";
            this.ucMenuCard_DashBoard.Name = "ucMenuCard_DashBoard";
            this.ucMenuCard_DashBoard.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DashBoard.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DashBoard.TabIndex = 14;
            this.ucMenuCard_DashBoard.MenuClick += new System.EventHandler(this.ucMenuCard_DashBoard_MenuClick);
            // 
            // ucMenuCard_DangXuat
            // 
            this.ucMenuCard_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DangXuat.BorderRadious = 20;
            this.ucMenuCard_DangXuat.ButtonBackColor = System.Drawing.Color.Red;
            this.ucMenuCard_DangXuat.ButtonTextColor = System.Drawing.SystemColors.Control;
            this.ucMenuCard_DangXuat.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DangXuat.Id = 0;
            this.ucMenuCard_DangXuat.Location = new System.Drawing.Point(21, 243);
            this.ucMenuCard_DangXuat.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DangXuat.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DangXuat.MenuImage = global::FinalProject.Properties.Resources.icons8_log_out_96;
            this.ucMenuCard_DangXuat.MenuName = "ĐĂNG XUẤT";
            this.ucMenuCard_DangXuat.Name = "ucMenuCard_DangXuat";
            this.ucMenuCard_DangXuat.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DangXuat.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DangXuat.TabIndex = 17;
            this.ucMenuCard_DangXuat.MenuClick += new System.EventHandler(this.ucMenuCard_DangXuat_MenuClick);
            // 
            // FAdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 496);
            this.Controls.Add(this.ucMenuCard_DangXuat);
            this.Controls.Add(this.ucMenuCard_DashBoard);
            this.Controls.Add(this.ucMenuCard_UngVien);
            this.Controls.Add(this.ucMenuCard_ViecLamUT);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label1;
        private UC.UCMenuCard ucMenuCard_ViecLamUT;
        private UC.UCMenuCard ucMenuCard_UngVien;
        private UC.UCMenuCard ucMenuCard_DashBoard;
        private UC.UCMenuCard ucMenuCard_DangXuat;
    }
}