﻿namespace FinalProject.Company
{
    partial class FCompanyHomePage
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
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucMenuCard_TaoViecLam = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DSViecLam = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_HSChuaDuyet = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCty = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ThongTin = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DoiMatKhau = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DangXuat = new FinalProject.UC.UCMenuCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(1191, 625);
            this.pictureBox_Image.TabIndex = 7;
            this.pictureBox_Image.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_TaoViecLam);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DSViecLam);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_HSChuaDuyet);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCty);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ThongTin);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DoiMatKhau);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DangXuat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(9);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1191, 625);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // ucMenuCard_TaoViecLam
            // 
            this.ucMenuCard_TaoViecLam.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_TaoViecLam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_TaoViecLam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_TaoViecLam.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_TaoViecLam.ButtonTextColor = System.Drawing.Color.Coral;
            this.ucMenuCard_TaoViecLam.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_TaoViecLam.Id = 0;
            this.ucMenuCard_TaoViecLam.Location = new System.Drawing.Point(21, 21);
            this.ucMenuCard_TaoViecLam.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_TaoViecLam.MenuImage = global::FinalProject.Properties.Resources.create_job;
            this.ucMenuCard_TaoViecLam.MenuName = "Tạo công việc";
            this.ucMenuCard_TaoViecLam.Name = "ucMenuCard_TaoViecLam";
            this.ucMenuCard_TaoViecLam.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_TaoViecLam.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_TaoViecLam.TabIndex = 0;
            this.ucMenuCard_TaoViecLam.MenuClick += new System.EventHandler(this.ucMenuCard_TaoViecLam_MenuClick);
            // 
            // ucMenuCard_DSViecLam
            // 
            this.ucMenuCard_DSViecLam.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DSViecLam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DSViecLam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DSViecLam.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_DSViecLam.ButtonTextColor = System.Drawing.Color.Coral;
            this.ucMenuCard_DSViecLam.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DSViecLam.Id = 0;
            this.ucMenuCard_DSViecLam.Location = new System.Drawing.Point(311, 21);
            this.ucMenuCard_DSViecLam.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DSViecLam.MenuImage = global::FinalProject.Properties.Resources.icons8_list_64;
            this.ucMenuCard_DSViecLam.MenuName = "Danh sách công việc";
            this.ucMenuCard_DSViecLam.Name = "ucMenuCard_DSViecLam";
            this.ucMenuCard_DSViecLam.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DSViecLam.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_DSViecLam.TabIndex = 1;
            this.ucMenuCard_DSViecLam.MenuClick += new System.EventHandler(this.ucMenuCard_DSViecLam_MenuClick);
            // 
            // ucMenuCard_DsCV
            // 
            this.ucMenuCard_DsCV.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DsCV.ButtonBackColor = System.Drawing.Color.CadetBlue;
            this.ucMenuCard_DsCV.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCV.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DsCV.Id = 0;
            this.ucMenuCard_DsCV.Location = new System.Drawing.Point(601, 21);
            this.ucMenuCard_DsCV.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCV.MenuImage = global::FinalProject.Properties.Resources.icons8_profile_check_64;
            this.ucMenuCard_DsCV.MenuName = "Hồ sơ đã duyệt";
            this.ucMenuCard_DsCV.Name = "ucMenuCard_DsCV";
            this.ucMenuCard_DsCV.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCV.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_DsCV.TabIndex = 2;
            // 
            // ucMenuCard_HSChuaDuyet
            // 
            this.ucMenuCard_HSChuaDuyet.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_HSChuaDuyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_HSChuaDuyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_HSChuaDuyet.ButtonBackColor = System.Drawing.Color.CadetBlue;
            this.ucMenuCard_HSChuaDuyet.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_HSChuaDuyet.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_HSChuaDuyet.Id = 0;
            this.ucMenuCard_HSChuaDuyet.Location = new System.Drawing.Point(891, 21);
            this.ucMenuCard_HSChuaDuyet.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_HSChuaDuyet.MenuImage = global::FinalProject.Properties.Resources.icons8_data_pending_64;
            this.ucMenuCard_HSChuaDuyet.MenuName = "Hồ sơ chưa duyệt";
            this.ucMenuCard_HSChuaDuyet.Name = "ucMenuCard_HSChuaDuyet";
            this.ucMenuCard_HSChuaDuyet.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_HSChuaDuyet.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_HSChuaDuyet.TabIndex = 3;
            this.ucMenuCard_HSChuaDuyet.MenuClick += new System.EventHandler(this.ucMenuCard_HSChuaDuyet_MenuClick);
            // 
            // ucMenuCard_DsCty
            // 
            this.ucMenuCard_DsCty.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsCty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DsCty.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_DsCty.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_DsCty.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DsCty.Id = 0;
            this.ucMenuCard_DsCty.Location = new System.Drawing.Point(21, 287);
            this.ucMenuCard_DsCty.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCty.MenuImage = global::FinalProject.Properties.Resources.icons8_history_64;
            this.ucMenuCard_DsCty.MenuName = "Lịch sử tuyển dụng";
            this.ucMenuCard_DsCty.Name = "ucMenuCard_DsCty";
            this.ucMenuCard_DsCty.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCty.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_DsCty.TabIndex = 4;
            this.ucMenuCard_DsCty.MenuClick += new System.EventHandler(this.ucMenuCard_DsCty_MenuClick);
            // 
            // ucMenuCard_ThongTin
            // 
            this.ucMenuCard_ThongTin.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_ThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_ThongTin.ButtonBackColor = System.Drawing.Color.Goldenrod;
            this.ucMenuCard_ThongTin.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ThongTin.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_ThongTin.Id = 0;
            this.ucMenuCard_ThongTin.Location = new System.Drawing.Point(311, 287);
            this.ucMenuCard_ThongTin.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_ThongTin.MenuImage = global::FinalProject.Properties.Resources.icons8_company_96;
            this.ucMenuCard_ThongTin.MenuName = "Thông tin công ty";
            this.ucMenuCard_ThongTin.Name = "ucMenuCard_ThongTin";
            this.ucMenuCard_ThongTin.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_ThongTin.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_ThongTin.TabIndex = 5;
            this.ucMenuCard_ThongTin.MenuClick += new System.EventHandler(this.ucMenuCard_ThongTin_MenuClick);
            // 
            // ucMenuCard_DoiMatKhau
            // 
            this.ucMenuCard_DoiMatKhau.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DoiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DoiMatKhau.ButtonBackColor = System.Drawing.Color.Goldenrod;
            this.ucMenuCard_DoiMatKhau.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DoiMatKhau.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DoiMatKhau.Id = 0;
            this.ucMenuCard_DoiMatKhau.Location = new System.Drawing.Point(601, 287);
            this.ucMenuCard_DoiMatKhau.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DoiMatKhau.MenuImage = global::FinalProject.Properties.Resources.icons8_password_144;
            this.ucMenuCard_DoiMatKhau.MenuName = "Đổi mật khẩu";
            this.ucMenuCard_DoiMatKhau.Name = "ucMenuCard_DoiMatKhau";
            this.ucMenuCard_DoiMatKhau.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DoiMatKhau.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_DoiMatKhau.TabIndex = 6;
            this.ucMenuCard_DoiMatKhau.MenuClick += new System.EventHandler(this.ucMenuCard_DoiMatKhau_MenuClick);
            // 
            // ucMenuCard_DangXuat
            // 
            this.ucMenuCard_DangXuat.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DangXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DangXuat.ButtonBackColor = System.Drawing.Color.Tomato;
            this.ucMenuCard_DangXuat.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DangXuat.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DangXuat.Id = 0;
            this.ucMenuCard_DangXuat.Location = new System.Drawing.Point(891, 287);
            this.ucMenuCard_DangXuat.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DangXuat.MenuImage = global::FinalProject.Properties.Resources.icons8_log_out_96;
            this.ucMenuCard_DangXuat.MenuName = "Đăng xuất";
            this.ucMenuCard_DangXuat.Name = "ucMenuCard_DangXuat";
            this.ucMenuCard_DangXuat.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DangXuat.Size = new System.Drawing.Size(266, 242);
            this.ucMenuCard_DangXuat.TabIndex = 7;
            this.ucMenuCard_DangXuat.MenuClick += new System.EventHandler(this.ucMenuCard_DangXuat_MenuClick);
            // 
            // FCompanyHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 625);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox_Image);
            this.MaximizeBox = false;
            this.Name = "FCompanyHomePage";
            this.Text = "FCompanyHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UC.UCMenuCard ucMenuCard_TaoViecLam;
        private UC.UCMenuCard ucMenuCard_DSViecLam;
        private UC.UCMenuCard ucMenuCard_DsCV;
        private UC.UCMenuCard ucMenuCard_HSChuaDuyet;
        private UC.UCMenuCard ucMenuCard_DsCty;
        private UC.UCMenuCard ucMenuCard_ThongTin;
        private UC.UCMenuCard ucMenuCard_DoiMatKhau;
        private UC.UCMenuCard ucMenuCard_DangXuat;
    }
}