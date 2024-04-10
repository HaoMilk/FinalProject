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
            this.menuStrip_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_ViecLam = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DanhSachCongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ChinhSuaCongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DanhSachUngVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ChinhSuaUngVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TaiKhoanUngVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DanhSachCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ChinhSuaCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TaiKhoanMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsM_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.ucMenuCard_UngVien = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_CongViec = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_XetDuyet = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ThongKe = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_CongTy = new FinalProject.UC.UCMenuCard();
            this.menuStrip_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_MenuStrip
            // 
            this.menuStrip_MenuStrip.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip_MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ViecLam,
            this.menu_HoSo,
            this.menu_CongTy,
            this.tsM_ThongKe,
            this.toolStripMenuItem1});
            this.menuStrip_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MenuStrip.Name = "menuStrip_MenuStrip";
            this.menuStrip_MenuStrip.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip_MenuStrip.Size = new System.Drawing.Size(872, 35);
            this.menuStrip_MenuStrip.TabIndex = 3;
            this.menuStrip_MenuStrip.Text = "menuStrip1";
            // 
            // menu_ViecLam
            // 
            this.menu_ViecLam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DanhSachCongViec,
            this.menu_ChinhSuaCongViec});
            this.menu_ViecLam.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ViecLam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ViecLam.Name = "menu_ViecLam";
            this.menu_ViecLam.Size = new System.Drawing.Size(172, 27);
            this.menu_ViecLam.Text = "Quản lý công việc";
            // 
            // menu_DanhSachCongViec
            // 
            this.menu_DanhSachCongViec.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_DanhSachCongViec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_DanhSachCongViec.Name = "menu_DanhSachCongViec";
            this.menu_DanhSachCongViec.Size = new System.Drawing.Size(265, 28);
            this.menu_DanhSachCongViec.Text = "Danh sách công việc";
            this.menu_DanhSachCongViec.Click += new System.EventHandler(this.menu_DanhSachCongViec_Click);
            // 
            // menu_ChinhSuaCongViec
            // 
            this.menu_ChinhSuaCongViec.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_ChinhSuaCongViec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ChinhSuaCongViec.Name = "menu_ChinhSuaCongViec";
            this.menu_ChinhSuaCongViec.Size = new System.Drawing.Size(265, 28);
            this.menu_ChinhSuaCongViec.Text = "Chỉnh sửa công việc";
            this.menu_ChinhSuaCongViec.Click += new System.EventHandler(this.menu_ChinhSuaCongViec_Click);
            // 
            // menu_HoSo
            // 
            this.menu_HoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DanhSachUngVien,
            this.menu_ChinhSuaUngVien,
            this.menu_TaiKhoanUngVien});
            this.menu_HoSo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_HoSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_HoSo.Name = "menu_HoSo";
            this.menu_HoSo.Size = new System.Drawing.Size(167, 27);
            this.menu_HoSo.Text = "Quản lý ứng viên";
            // 
            // menu_DanhSachUngVien
            // 
            this.menu_DanhSachUngVien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_DanhSachUngVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_DanhSachUngVien.Name = "menu_DanhSachUngVien";
            this.menu_DanhSachUngVien.Size = new System.Drawing.Size(286, 28);
            this.menu_DanhSachUngVien.Text = "Danh sách ứng viên";
            this.menu_DanhSachUngVien.Click += new System.EventHandler(this.menu_DanhSachUngVien_Click);
            // 
            // menu_ChinhSuaUngVien
            // 
            this.menu_ChinhSuaUngVien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_ChinhSuaUngVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ChinhSuaUngVien.Name = "menu_ChinhSuaUngVien";
            this.menu_ChinhSuaUngVien.Size = new System.Drawing.Size(286, 28);
            this.menu_ChinhSuaUngVien.Text = "Chỉnh sửa ứng viên";
            this.menu_ChinhSuaUngVien.Click += new System.EventHandler(this.menu_ChinhSuaUngVien_Click);
            // 
            // menu_TaiKhoanUngVien
            // 
            this.menu_TaiKhoanUngVien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_TaiKhoanUngVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_TaiKhoanUngVien.Name = "menu_TaiKhoanUngVien";
            this.menu_TaiKhoanUngVien.Size = new System.Drawing.Size(286, 28);
            this.menu_TaiKhoanUngVien.Text = "Tài khoản và mật khẩu";
            this.menu_TaiKhoanUngVien.Click += new System.EventHandler(this.menu_TaiKhoanUngVien_Click_1);
            // 
            // menu_CongTy
            // 
            this.menu_CongTy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DanhSachCongTy,
            this.menu_ChinhSuaCongTy,
            this.menu_TaiKhoanMatKhau});
            this.menu_CongTy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_CongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_CongTy.Name = "menu_CongTy";
            this.menu_CongTy.Size = new System.Drawing.Size(158, 27);
            this.menu_CongTy.Text = "Quản lý Công ty";
            // 
            // menu_DanhSachCongTy
            // 
            this.menu_DanhSachCongTy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_DanhSachCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_DanhSachCongTy.Name = "menu_DanhSachCongTy";
            this.menu_DanhSachCongTy.Size = new System.Drawing.Size(286, 28);
            this.menu_DanhSachCongTy.Text = "Danh sách công ty";
            this.menu_DanhSachCongTy.Click += new System.EventHandler(this.menu_DanhSachCongTy_Click);
            // 
            // menu_ChinhSuaCongTy
            // 
            this.menu_ChinhSuaCongTy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_ChinhSuaCongTy.ForeColor = System.Drawing.SystemColors.Control;
            this.menu_ChinhSuaCongTy.Name = "menu_ChinhSuaCongTy";
            this.menu_ChinhSuaCongTy.Size = new System.Drawing.Size(286, 28);
            this.menu_ChinhSuaCongTy.Text = "Chỉnh sửa công ty";
            this.menu_ChinhSuaCongTy.Click += new System.EventHandler(this.menu_ChinhSuaCongTy_Click);
            // 
            // menu_TaiKhoanMatKhau
            // 
            this.menu_TaiKhoanMatKhau.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_TaiKhoanMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_TaiKhoanMatKhau.Name = "menu_TaiKhoanMatKhau";
            this.menu_TaiKhoanMatKhau.Size = new System.Drawing.Size(286, 28);
            this.menu_TaiKhoanMatKhau.Text = "Tài khoản và mật khẩu";
            this.menu_TaiKhoanMatKhau.Click += new System.EventHandler(this.menu_TaiKhoanMatKhau_Click);
            // 
            // tsM_ThongKe
            // 
            this.tsM_ThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsM_ThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsM_ThongKe.Name = "tsM_ThongKe";
            this.tsM_ThongKe.Size = new System.Drawing.Size(102, 27);
            this.tsM_ThongKe.Text = "Thống kê";
            this.tsM_ThongKe.Click += new System.EventHandler(this.tsM_ThongKe_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 27);
            this.toolStripMenuItem1.Text = "Xét duyệt";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tSM_XetDuyet);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 35);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(872, 349);
            this.pictureBox_Image.TabIndex = 4;
            this.pictureBox_Image.TabStop = false;
            // 
            // ucMenuCard_UngVien
            // 
            this.ucMenuCard_UngVien.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_UngVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_UngVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_UngVien.ButtonBackColor = System.Drawing.Color.AntiqueWhite;
            this.ucMenuCard_UngVien.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_UngVien.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_UngVien.Id = 0;
            this.ucMenuCard_UngVien.Location = new System.Drawing.Point(665, 71);
            this.ucMenuCard_UngVien.Margin = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_UngVien.MenuImage = global::FinalProject.Properties.Resources.daily_resumes_of_candidates_for_recruitment;
            this.ucMenuCard_UngVien.MenuName = "ỨNG VIÊN";
            this.ucMenuCard_UngVien.Name = "ucMenuCard_UngVien";
            this.ucMenuCard_UngVien.Padding = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_UngVien.Size = new System.Drawing.Size(182, 137);
            this.ucMenuCard_UngVien.TabIndex = 9;
            this.ucMenuCard_UngVien.MenuClick += new System.EventHandler(this.ucMenuCard_UngVien_MenuClick);
            // 
            // ucMenuCard_CongViec
            // 
            this.ucMenuCard_CongViec.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_CongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_CongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_CongViec.ButtonBackColor = System.Drawing.Color.AntiqueWhite;
            this.ucMenuCard_CongViec.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_CongViec.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_CongViec.Id = 0;
            this.ucMenuCard_CongViec.Location = new System.Drawing.Point(457, 71);
            this.ucMenuCard_CongViec.Margin = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_CongViec.MenuImage = global::FinalProject.Properties.Resources.work;
            this.ucMenuCard_CongViec.MenuName = "CÔNG VIỆC";
            this.ucMenuCard_CongViec.Name = "ucMenuCard_CongViec";
            this.ucMenuCard_CongViec.Padding = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_CongViec.Size = new System.Drawing.Size(182, 137);
            this.ucMenuCard_CongViec.TabIndex = 8;
            this.ucMenuCard_CongViec.MenuClick += new System.EventHandler(this.ucMenuCard_CongViec_MenuClick);
            // 
            // ucMenuCard_XetDuyet
            // 
            this.ucMenuCard_XetDuyet.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_XetDuyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_XetDuyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_XetDuyet.ButtonBackColor = System.Drawing.Color.AntiqueWhite;
            this.ucMenuCard_XetDuyet.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_XetDuyet.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_XetDuyet.Id = 0;
            this.ucMenuCard_XetDuyet.Location = new System.Drawing.Point(249, 71);
            this.ucMenuCard_XetDuyet.Margin = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_XetDuyet.MenuImage = global::FinalProject.Properties.Resources.icons8_profiles_96;
            this.ucMenuCard_XetDuyet.MenuName = "XÉT DUYỆT";
            this.ucMenuCard_XetDuyet.Name = "ucMenuCard_XetDuyet";
            this.ucMenuCard_XetDuyet.Padding = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_XetDuyet.Size = new System.Drawing.Size(182, 137);
            this.ucMenuCard_XetDuyet.TabIndex = 7;
            this.ucMenuCard_XetDuyet.MenuClick += new System.EventHandler(this.ucMenuCard_XetDuyet_MenuClick);
            // 
            // ucMenuCard_ThongKe
            // 
            this.ucMenuCard_ThongKe.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_ThongKe.ButtonBackColor = System.Drawing.Color.AntiqueWhite;
            this.ucMenuCard_ThongKe.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_ThongKe.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_ThongKe.Id = 0;
            this.ucMenuCard_ThongKe.Location = new System.Drawing.Point(41, 71);
            this.ucMenuCard_ThongKe.Margin = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_ThongKe.MenuImage = global::FinalProject.Properties.Resources.char_icon;
            this.ucMenuCard_ThongKe.MenuName = "THỐNG KÊ";
            this.ucMenuCard_ThongKe.Name = "ucMenuCard_ThongKe";
            this.ucMenuCard_ThongKe.Padding = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_ThongKe.Size = new System.Drawing.Size(182, 137);
            this.ucMenuCard_ThongKe.TabIndex = 6;
            this.ucMenuCard_ThongKe.MenuClick += new System.EventHandler(this.ucMenuCard_ThongKe_MenuClick);
            // 
            // ucMenuCard_CongTy
            // 
            this.ucMenuCard_CongTy.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_CongTy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_CongTy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_CongTy.ButtonBackColor = System.Drawing.Color.AntiqueWhite;
            this.ucMenuCard_CongTy.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_CongTy.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_CongTy.Id = 0;
            this.ucMenuCard_CongTy.Location = new System.Drawing.Point(41, 234);
            this.ucMenuCard_CongTy.Margin = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_CongTy.MenuImage = global::FinalProject.Properties.Resources.icons8_company_100;
            this.ucMenuCard_CongTy.MenuName = "CÔNG TY";
            this.ucMenuCard_CongTy.Name = "ucMenuCard_CongTy";
            this.ucMenuCard_CongTy.Padding = new System.Windows.Forms.Padding(13);
            this.ucMenuCard_CongTy.Size = new System.Drawing.Size(182, 137);
            this.ucMenuCard_CongTy.TabIndex = 10;
            this.ucMenuCard_CongTy.MenuClick += new System.EventHandler(this.ucMenuCard_CongTy_MenuClick);
            // 
            // FAdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 412);
            this.Controls.Add(this.ucMenuCard_CongTy);
            this.Controls.Add(this.ucMenuCard_UngVien);
            this.Controls.Add(this.ucMenuCard_CongViec);
            this.Controls.Add(this.ucMenuCard_XetDuyet);
            this.Controls.Add(this.ucMenuCard_ThongKe);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.menuStrip_MenuStrip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdminHomePage";
            this.menuStrip_MenuStrip.ResumeLayout(false);
            this.menuStrip_MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.MenuStrip menuStrip_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_ViecLam;
        private System.Windows.Forms.ToolStripMenuItem menu_HoSo;
        private System.Windows.Forms.ToolStripMenuItem menu_CongTy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menu_DanhSachCongViec;
        private System.Windows.Forms.ToolStripMenuItem menu_ChinhSuaCongViec;
        private System.Windows.Forms.ToolStripMenuItem menu_DanhSachUngVien;
        private System.Windows.Forms.ToolStripMenuItem menu_ChinhSuaUngVien;
        private System.Windows.Forms.ToolStripMenuItem menu_DanhSachCongTy;
        private System.Windows.Forms.ToolStripMenuItem menu_ChinhSuaCongTy;
        private System.Windows.Forms.ToolStripMenuItem menu_TaiKhoanUngVien;
        private System.Windows.Forms.ToolStripMenuItem menu_TaiKhoanMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tsM_ThongKe;
        private UC.UCMenuCard ucMenuCard_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private UC.UCMenuCard ucMenuCard_XetDuyet;
        private UC.UCMenuCard ucMenuCard_CongViec;
        private UC.UCMenuCard ucMenuCard_UngVien;
        private UC.UCMenuCard ucMenuCard_CongTy;
    }
}