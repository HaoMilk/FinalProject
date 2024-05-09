namespace FinalProject.Candidate.GUI
{
    partial class FCandidateHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCandidateHomePage));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucMenuCard_DsViecLam = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ViecLamUT = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_MauCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCty = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ThongTin = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DoiMatKhau = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DangXuat = new FinalProject.UC.UCMenuCard();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsViecLam);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ViecLamUT);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_MauCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCty);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ThongTin);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DoiMatKhau);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DangXuat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1048, 503);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ucMenuCard_DsViecLam
            // 
            this.ucMenuCard_DsViecLam.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DsViecLam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsViecLam.BorderRadious = 20;
            this.ucMenuCard_DsViecLam.ButtonBackColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_DsViecLam.ButtonTextColor = System.Drawing.SystemColors.Control;
            this.ucMenuCard_DsViecLam.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DsViecLam.Id = 0;
            this.ucMenuCard_DsViecLam.Location = new System.Drawing.Point(25, 24);
            this.ucMenuCard_DsViecLam.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsViecLam.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsViecLam.MenuImage = global::FinalProject.Properties.Resources.icons8_job_seeker_96;
            this.ucMenuCard_DsViecLam.MenuName = "Danh sách việc làm";
            this.ucMenuCard_DsViecLam.Name = "ucMenuCard_DsViecLam";
            this.ucMenuCard_DsViecLam.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsViecLam.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DsViecLam.TabIndex = 0;
            this.ucMenuCard_DsViecLam.MenuClick += new System.EventHandler(this.ucMenuCard_DsViecLam_MenuClick);
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
            this.ucMenuCard_ViecLamUT.Location = new System.Drawing.Point(273, 24);
            this.ucMenuCard_ViecLamUT.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ViecLamUT.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ViecLamUT.MenuImage = global::FinalProject.Properties.Resources.icons8_resume_website_96;
            this.ucMenuCard_ViecLamUT.MenuName = "Việc làm đã ứng tuyển";
            this.ucMenuCard_ViecLamUT.Name = "ucMenuCard_ViecLamUT";
            this.ucMenuCard_ViecLamUT.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ViecLamUT.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_ViecLamUT.TabIndex = 1;
            this.ucMenuCard_ViecLamUT.MenuClick += new System.EventHandler(this.ucMenuCard_ViecLamUT_MenuClick);
            // 
            // ucMenuCard_DsCV
            // 
            this.ucMenuCard_DsCV.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DsCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsCV.BorderRadious = 20;
            this.ucMenuCard_DsCV.ButtonBackColor = System.Drawing.Color.CadetBlue;
            this.ucMenuCard_DsCV.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCV.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DsCV.Id = 0;
            this.ucMenuCard_DsCV.Location = new System.Drawing.Point(521, 24);
            this.ucMenuCard_DsCV.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCV.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCV.MenuImage = global::FinalProject.Properties.Resources.icons8_profiles_96;
            this.ucMenuCard_DsCV.MenuName = "CV của tôi";
            this.ucMenuCard_DsCV.Name = "ucMenuCard_DsCV";
            this.ucMenuCard_DsCV.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCV.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DsCV.TabIndex = 2;
            this.ucMenuCard_DsCV.MenuClick += new System.EventHandler(this.ucMenuCard_DsCV_MenuClick);
            // 
            // ucMenuCard_MauCV
            // 
            this.ucMenuCard_MauCV.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_MauCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_MauCV.BorderRadious = 20;
            this.ucMenuCard_MauCV.ButtonBackColor = System.Drawing.Color.CadetBlue;
            this.ucMenuCard_MauCV.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_MauCV.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_MauCV.Id = 0;
            this.ucMenuCard_MauCV.Location = new System.Drawing.Point(769, 24);
            this.ucMenuCard_MauCV.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_MauCV.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_MauCV.MenuImage = global::FinalProject.Properties.Resources.icons8_cv_96;
            this.ucMenuCard_MauCV.MenuName = "Mẫu CV";
            this.ucMenuCard_MauCV.Name = "ucMenuCard_MauCV";
            this.ucMenuCard_MauCV.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_MauCV.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_MauCV.TabIndex = 3;
            this.ucMenuCard_MauCV.MenuClick += new System.EventHandler(this.ucMenuCard_MauCV_MenuClick);
            // 
            // ucMenuCard_DsCty
            // 
            this.ucMenuCard_DsCty.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DsCty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsCty.BorderRadious = 20;
            this.ucMenuCard_DsCty.ButtonBackColor = System.Drawing.Color.DeepPink;
            this.ucMenuCard_DsCty.ButtonTextColor = System.Drawing.SystemColors.Control;
            this.ucMenuCard_DsCty.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DsCty.Id = 0;
            this.ucMenuCard_DsCty.Location = new System.Drawing.Point(25, 232);
            this.ucMenuCard_DsCty.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCty.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCty.MenuImage = global::FinalProject.Properties.Resources.icons8_company_96;
            this.ucMenuCard_DsCty.MenuName = "Danh sách công ty";
            this.ucMenuCard_DsCty.Name = "ucMenuCard_DsCty";
            this.ucMenuCard_DsCty.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCty.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DsCty.TabIndex = 4;
            this.ucMenuCard_DsCty.MenuClick += new System.EventHandler(this.ucMenuCard_DsCty_MenuClick);
            // 
            // ucMenuCard_ThongTin
            // 
            this.ucMenuCard_ThongTin.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_ThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_ThongTin.BorderRadious = 20;
            this.ucMenuCard_ThongTin.ButtonBackColor = System.Drawing.Color.Goldenrod;
            this.ucMenuCard_ThongTin.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ThongTin.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_ThongTin.Id = 0;
            this.ucMenuCard_ThongTin.Location = new System.Drawing.Point(273, 232);
            this.ucMenuCard_ThongTin.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ThongTin.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ThongTin.MenuImage = global::FinalProject.Properties.Resources.icons8_name_96;
            this.ucMenuCard_ThongTin.MenuName = "Thông tin cá nhân";
            this.ucMenuCard_ThongTin.Name = "ucMenuCard_ThongTin";
            this.ucMenuCard_ThongTin.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ThongTin.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_ThongTin.TabIndex = 5;
            this.ucMenuCard_ThongTin.MenuClick += new System.EventHandler(this.ucMenuCard_ThongTin_MenuClick);
            // 
            // ucMenuCard_DoiMatKhau
            // 
            this.ucMenuCard_DoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DoiMatKhau.BorderRadious = 20;
            this.ucMenuCard_DoiMatKhau.ButtonBackColor = System.Drawing.Color.Goldenrod;
            this.ucMenuCard_DoiMatKhau.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DoiMatKhau.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DoiMatKhau.Id = 0;
            this.ucMenuCard_DoiMatKhau.Location = new System.Drawing.Point(521, 232);
            this.ucMenuCard_DoiMatKhau.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DoiMatKhau.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DoiMatKhau.MenuImage = global::FinalProject.Properties.Resources.icons8_password_144;
            this.ucMenuCard_DoiMatKhau.MenuName = "Đổi mật khẩu";
            this.ucMenuCard_DoiMatKhau.Name = "ucMenuCard_DoiMatKhau";
            this.ucMenuCard_DoiMatKhau.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DoiMatKhau.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DoiMatKhau.TabIndex = 6;
            this.ucMenuCard_DoiMatKhau.MenuClick += new System.EventHandler(this.ucMenuCard_DoiMatKhau_MenuClick);
            // 
            // ucMenuCard_DangXuat
            // 
            this.ucMenuCard_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCard_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DangXuat.BorderRadious = 20;
            this.ucMenuCard_DangXuat.ButtonBackColor = System.Drawing.Color.Tomato;
            this.ucMenuCard_DangXuat.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DangXuat.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_DangXuat.Id = 0;
            this.ucMenuCard_DangXuat.Location = new System.Drawing.Point(769, 232);
            this.ucMenuCard_DangXuat.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DangXuat.MenuBackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DangXuat.MenuImage = global::FinalProject.Properties.Resources.icons8_log_out_96;
            this.ucMenuCard_DangXuat.MenuName = "Đăng xuất";
            this.ucMenuCard_DangXuat.Name = "ucMenuCard_DangXuat";
            this.ucMenuCard_DangXuat.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DangXuat.Size = new System.Drawing.Size(220, 180);
            this.ucMenuCard_DangXuat.TabIndex = 7;
            this.ucMenuCard_DangXuat.MenuClick += new System.EventHandler(this.ucMenuCard_DangXuat_MenuClick);
            // 
            // FCandidateHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Constantia", 12F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FCandidateHomePage";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "FCandidateHomePage";
            this.Load += new System.EventHandler(this.FCandidateHomePage_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FinalProject.UC.UCMenuCard ucMenuCard_DsViecLam;
        private FinalProject.UC.UCMenuCard ucMenuCard_ViecLamUT;
        private FinalProject.UC.UCMenuCard ucMenuCard_DsCV;
        private FinalProject.UC.UCMenuCard ucMenuCard_MauCV;
        private FinalProject.UC.UCMenuCard ucMenuCard_DsCty;
        private FinalProject.UC.UCMenuCard ucMenuCard_ThongTin;
        private FinalProject.UC.UCMenuCard ucMenuCard_DoiMatKhau;
        private FinalProject.UC.UCMenuCard ucMenuCard_DangXuat;
    }
}