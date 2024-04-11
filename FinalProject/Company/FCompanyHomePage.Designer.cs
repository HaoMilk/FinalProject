namespace FinalProject.Company
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
            this.menuStrip_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_ViecLam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Dsvl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ChinhSuaCongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LichSuTuyenDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_HoSoDaDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_HoSoChuaDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TrangCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ThongTinCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucMenuCard_TaoViecLam = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ViecLamUT = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_MauCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCty = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ThongTin = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DoiMatKhau = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DangXuat = new FinalProject.UC.UCMenuCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.menuStrip_MenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 36);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(983, 456);
            this.pictureBox_Image.TabIndex = 7;
            this.pictureBox_Image.TabStop = false;
            // 
            // menuStrip_MenuStrip
            // 
            this.menuStrip_MenuStrip.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip_MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ViecLam,
            this.menu_HoSo,
            this.menu_TrangCaNhan});
            this.menuStrip_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MenuStrip.Name = "menuStrip_MenuStrip";
            this.menuStrip_MenuStrip.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip_MenuStrip.Size = new System.Drawing.Size(983, 36);
            this.menuStrip_MenuStrip.TabIndex = 6;
            this.menuStrip_MenuStrip.Text = "menuStrip1";
            // 
            // menu_ViecLam
            // 
            this.menu_ViecLam.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_ViecLam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Dsvl,
            this.ToolStripMenuItem_ChinhSuaCongViec,
            this.menuItem_LichSuTuyenDung});
            this.menu_ViecLam.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ViecLam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ViecLam.Name = "menu_ViecLam";
            this.menu_ViecLam.Size = new System.Drawing.Size(197, 28);
            this.menu_ViecLam.Text = "Quản lý ứng tuyển";
            // 
            // menuItem_Dsvl
            // 
            this.menuItem_Dsvl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_Dsvl.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_Dsvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_Dsvl.Name = "menuItem_Dsvl";
            this.menuItem_Dsvl.Size = new System.Drawing.Size(344, 28);
            this.menuItem_Dsvl.Text = "Tạo và chỉnh sửa công việc";
            this.menuItem_Dsvl.Click += new System.EventHandler(this.menuItem_Dsvl_Click);
            // 
            // ToolStripMenuItem_ChinhSuaCongViec
            // 
            this.ToolStripMenuItem_ChinhSuaCongViec.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ToolStripMenuItem_ChinhSuaCongViec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolStripMenuItem_ChinhSuaCongViec.Name = "ToolStripMenuItem_ChinhSuaCongViec";
            this.ToolStripMenuItem_ChinhSuaCongViec.Size = new System.Drawing.Size(344, 28);
            this.ToolStripMenuItem_ChinhSuaCongViec.Text = "Danh sách công việc";
            this.ToolStripMenuItem_ChinhSuaCongViec.Click += new System.EventHandler(this.ToolStripMenuItem_ChinhSuaCongViec_Click);
            // 
            // menuItem_LichSuTuyenDung
            // 
            this.menuItem_LichSuTuyenDung.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_LichSuTuyenDung.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_LichSuTuyenDung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_LichSuTuyenDung.Name = "menuItem_LichSuTuyenDung";
            this.menuItem_LichSuTuyenDung.Size = new System.Drawing.Size(344, 28);
            this.menuItem_LichSuTuyenDung.Text = "Lịch sử tuyển dụng";
            // 
            // menu_HoSo
            // 
            this.menu_HoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_HoSoDaDuyet,
            this.menuItem_HoSoChuaDuyet});
            this.menu_HoSo.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_HoSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_HoSo.Name = "menu_HoSo";
            this.menu_HoSo.Size = new System.Drawing.Size(182, 28);
            this.menu_HoSo.Text = "Hồ sơ ứng tuyển";
            // 
            // menuItem_HoSoDaDuyet
            // 
            this.menuItem_HoSoDaDuyet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_HoSoDaDuyet.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_HoSoDaDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_HoSoDaDuyet.Name = "menuItem_HoSoDaDuyet";
            this.menuItem_HoSoDaDuyet.Size = new System.Drawing.Size(263, 28);
            this.menuItem_HoSoDaDuyet.Text = "Hồ sơ đã duyệt";
            // 
            // menuItem_HoSoChuaDuyet
            // 
            this.menuItem_HoSoChuaDuyet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_HoSoChuaDuyet.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_HoSoChuaDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_HoSoChuaDuyet.Name = "menuItem_HoSoChuaDuyet";
            this.menuItem_HoSoChuaDuyet.Size = new System.Drawing.Size(263, 28);
            this.menuItem_HoSoChuaDuyet.Text = "Hồ sơ chưa duyệt";
            // 
            // menu_TrangCaNhan
            // 
            this.menu_TrangCaNhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ThongTinCongTy,
            this.menuItem_DoiMatKhau,
            this.menuItem_DangXuat});
            this.menu_TrangCaNhan.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_TrangCaNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_TrangCaNhan.Name = "menu_TrangCaNhan";
            this.menu_TrangCaNhan.Size = new System.Drawing.Size(188, 28);
            this.menu_TrangCaNhan.Text = "Quản lý thông tin";
            // 
            // menuItem_ThongTinCongTy
            // 
            this.menuItem_ThongTinCongTy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_ThongTinCongTy.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_ThongTinCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_ThongTinCongTy.Name = "menuItem_ThongTinCongTy";
            this.menuItem_ThongTinCongTy.Size = new System.Drawing.Size(257, 28);
            this.menuItem_ThongTinCongTy.Text = "Thông tin công ty";
            this.menuItem_ThongTinCongTy.Click += new System.EventHandler(this.menuItem_ThongTinCaNhan_Click);
            // 
            // menuItem_DoiMatKhau
            // 
            this.menuItem_DoiMatKhau.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_DoiMatKhau.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_DoiMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DoiMatKhau.Name = "menuItem_DoiMatKhau";
            this.menuItem_DoiMatKhau.Size = new System.Drawing.Size(257, 28);
            this.menuItem_DoiMatKhau.Text = "Đổi mật khẩu";
            this.menuItem_DoiMatKhau.Click += new System.EventHandler(this.menuItem_DoiMatKhau_Click);
            // 
            // menuItem_DangXuat
            // 
            this.menuItem_DangXuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuItem_DangXuat.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_DangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DangXuat.Name = "menuItem_DangXuat";
            this.menuItem_DangXuat.Size = new System.Drawing.Size(257, 28);
            this.menuItem_DangXuat.Text = "Đăng xuất";
            this.menuItem_DangXuat.Click += new System.EventHandler(this.menuItem_DangXuat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_TaoViecLam);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ViecLamUT);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_MauCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCty);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ThongTin);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DoiMatKhau);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DangXuat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(9);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(983, 456);
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
            this.ucMenuCard_TaoViecLam.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_TaoViecLam.TabIndex = 0;
            this.ucMenuCard_TaoViecLam.MenuClick += new System.EventHandler(this.ucMenuCard_TaoViecLam_MenuClick);
            // 
            // ucMenuCard_ViecLamUT
            // 
            this.ucMenuCard_ViecLamUT.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ViecLamUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_ViecLamUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_ViecLamUT.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_ViecLamUT.ButtonTextColor = System.Drawing.Color.Coral;
            this.ucMenuCard_ViecLamUT.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_ViecLamUT.Id = 0;
            this.ucMenuCard_ViecLamUT.Location = new System.Drawing.Point(257, 21);
            this.ucMenuCard_ViecLamUT.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_ViecLamUT.MenuImage = global::FinalProject.Properties.Resources.icons8_list_64;
            this.ucMenuCard_ViecLamUT.MenuName = "Danh sách công việc";
            this.ucMenuCard_ViecLamUT.Name = "ucMenuCard_ViecLamUT";
            this.ucMenuCard_ViecLamUT.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_ViecLamUT.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_ViecLamUT.TabIndex = 1;
            this.ucMenuCard_ViecLamUT.MenuClick += new System.EventHandler(this.ucMenuCard_ViecLamUT_MenuClick);
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
            this.ucMenuCard_DsCV.Location = new System.Drawing.Point(493, 21);
            this.ucMenuCard_DsCV.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCV.MenuImage = global::FinalProject.Properties.Resources.icons8_profile_check_64;
            this.ucMenuCard_DsCV.MenuName = "Hồ sơ đã duyệt";
            this.ucMenuCard_DsCV.Name = "ucMenuCard_DsCV";
            this.ucMenuCard_DsCV.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCV.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_DsCV.TabIndex = 2;
            // 
            // ucMenuCard_MauCV
            // 
            this.ucMenuCard_MauCV.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_MauCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_MauCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_MauCV.ButtonBackColor = System.Drawing.Color.CadetBlue;
            this.ucMenuCard_MauCV.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_MauCV.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCard_MauCV.Id = 0;
            this.ucMenuCard_MauCV.Location = new System.Drawing.Point(729, 21);
            this.ucMenuCard_MauCV.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_MauCV.MenuImage = global::FinalProject.Properties.Resources.icons8_data_pending_64;
            this.ucMenuCard_MauCV.MenuName = "Hồ sơ chưa duyệt";
            this.ucMenuCard_MauCV.Name = "ucMenuCard_MauCV";
            this.ucMenuCard_MauCV.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_MauCV.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_MauCV.TabIndex = 3;
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
            this.ucMenuCard_DsCty.Location = new System.Drawing.Point(21, 207);
            this.ucMenuCard_DsCty.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCty.MenuImage = global::FinalProject.Properties.Resources.icons8_history_64;
            this.ucMenuCard_DsCty.MenuName = "Lịch sử tuyển dụng";
            this.ucMenuCard_DsCty.Name = "ucMenuCard_DsCty";
            this.ucMenuCard_DsCty.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DsCty.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_DsCty.TabIndex = 4;
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
            this.ucMenuCard_ThongTin.Location = new System.Drawing.Point(257, 207);
            this.ucMenuCard_ThongTin.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_ThongTin.MenuImage = global::FinalProject.Properties.Resources.icons8_company_96;
            this.ucMenuCard_ThongTin.MenuName = "Thông tin công ty";
            this.ucMenuCard_ThongTin.Name = "ucMenuCard_ThongTin";
            this.ucMenuCard_ThongTin.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_ThongTin.Size = new System.Drawing.Size(212, 162);
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
            this.ucMenuCard_DoiMatKhau.Location = new System.Drawing.Point(493, 207);
            this.ucMenuCard_DoiMatKhau.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DoiMatKhau.MenuImage = global::FinalProject.Properties.Resources.icons8_password_144;
            this.ucMenuCard_DoiMatKhau.MenuName = "Đổi mật khẩu";
            this.ucMenuCard_DoiMatKhau.Name = "ucMenuCard_DoiMatKhau";
            this.ucMenuCard_DoiMatKhau.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DoiMatKhau.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_DoiMatKhau.TabIndex = 6;
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
            this.ucMenuCard_DangXuat.Location = new System.Drawing.Point(729, 207);
            this.ucMenuCard_DangXuat.Margin = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DangXuat.MenuImage = global::FinalProject.Properties.Resources.icons8_log_out_96;
            this.ucMenuCard_DangXuat.MenuName = "Đăng xuất";
            this.ucMenuCard_DangXuat.Name = "ucMenuCard_DangXuat";
            this.ucMenuCard_DangXuat.Padding = new System.Windows.Forms.Padding(12);
            this.ucMenuCard_DangXuat.Size = new System.Drawing.Size(212, 162);
            this.ucMenuCard_DangXuat.TabIndex = 7;
            this.ucMenuCard_DangXuat.MenuClick += new System.EventHandler(this.ucMenuCard_DangXuat_MenuClick);
            // 
            // FCompanyHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 492);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.menuStrip_MenuStrip);
            this.MaximizeBox = false;
            this.Name = "FCompanyHomePage";
            this.Text = "FCompanyHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.menuStrip_MenuStrip.ResumeLayout(false);
            this.menuStrip_MenuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.MenuStrip menuStrip_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_ViecLam;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Dsvl;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LichSuTuyenDung;
        private System.Windows.Forms.ToolStripMenuItem menu_HoSo;
        private System.Windows.Forms.ToolStripMenuItem menuItem_HoSoDaDuyet;
        private System.Windows.Forms.ToolStripMenuItem menuItem_HoSoChuaDuyet;
        private System.Windows.Forms.ToolStripMenuItem menu_TrangCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ThongTinCongTy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ChinhSuaCongViec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UC.UCMenuCard ucMenuCard_TaoViecLam;
        private UC.UCMenuCard ucMenuCard_ViecLamUT;
        private UC.UCMenuCard ucMenuCard_DsCV;
        private UC.UCMenuCard ucMenuCard_MauCV;
        private UC.UCMenuCard ucMenuCard_DsCty;
        private UC.UCMenuCard ucMenuCard_ThongTin;
        private UC.UCMenuCard ucMenuCard_DoiMatKhau;
        private UC.UCMenuCard ucMenuCard_DangXuat;
    }
}