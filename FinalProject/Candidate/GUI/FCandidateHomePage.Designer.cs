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
            this.menuStrip_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_ViecLam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Dsvl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_VieclamUT = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_QlyCv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_MauCv = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DsCty = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TrangCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucMenuCard_DsViecLam = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ViecLamUT = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_MauCV = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DsCty = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ThongTin = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DoiMatKhau = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_DangXuat = new FinalProject.UC.UCMenuCard();
            this.menuStrip_MenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_MenuStrip
            // 
            this.menuStrip_MenuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip_MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ViecLam,
            this.menu_HoSo,
            this.menu_CongTy,
            this.menu_TrangCaNhan});
            this.menuStrip_MenuStrip.Location = new System.Drawing.Point(0, 40);
            this.menuStrip_MenuStrip.Name = "menuStrip_MenuStrip";
            this.menuStrip_MenuStrip.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip_MenuStrip.Size = new System.Drawing.Size(942, 35);
            this.menuStrip_MenuStrip.TabIndex = 0;
            this.menuStrip_MenuStrip.Text = "menuStrip1";
            // 
            // menu_ViecLam
            // 
            this.menu_ViecLam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Dsvl,
            this.menuItem_VieclamUT});
            this.menu_ViecLam.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ViecLam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ViecLam.Name = "menu_ViecLam";
            this.menu_ViecLam.Size = new System.Drawing.Size(97, 27);
            this.menu_ViecLam.Text = "Việc làm";
            // 
            // menuItem_Dsvl
            // 
            this.menuItem_Dsvl.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_Dsvl.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_Dsvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_Dsvl.Name = "menuItem_Dsvl";
            this.menuItem_Dsvl.Size = new System.Drawing.Size(251, 26);
            this.menuItem_Dsvl.Text = "Danh sách việc làm";
            // 
            // menuItem_VieclamUT
            // 
            this.menuItem_VieclamUT.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_VieclamUT.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_VieclamUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_VieclamUT.Name = "menuItem_VieclamUT";
            this.menuItem_VieclamUT.Size = new System.Drawing.Size(251, 26);
            this.menuItem_VieclamUT.Text = "Việc làm đã ứng tuyển";
            this.menuItem_VieclamUT.Click += new System.EventHandler(this.menuItem_VieclamUT_Click);
            // 
            // menu_HoSo
            // 
            this.menu_HoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_QlyCv,
            this.menuItem_MauCv});
            this.menu_HoSo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_HoSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_HoSo.Name = "menu_HoSo";
            this.menu_HoSo.Size = new System.Drawing.Size(110, 27);
            this.menu_HoSo.Text = "Hồ sơ & CV";
            // 
            // menuItem_QlyCv
            // 
            this.menuItem_QlyCv.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_QlyCv.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_QlyCv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_QlyCv.Name = "menuItem_QlyCv";
            this.menuItem_QlyCv.Size = new System.Drawing.Size(174, 26);
            this.menuItem_QlyCv.Text = "Quản lý CV";
            this.menuItem_QlyCv.Click += new System.EventHandler(this.menuItem_QlyCv_Click);
            // 
            // menuItem_MauCv
            // 
            this.menuItem_MauCv.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_MauCv.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_MauCv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_MauCv.Name = "menuItem_MauCv";
            this.menuItem_MauCv.Size = new System.Drawing.Size(174, 26);
            this.menuItem_MauCv.Text = "Mẫu CV";
            this.menuItem_MauCv.Click += new System.EventHandler(this.menuItem_MauCv_Click);
            // 
            // menu_CongTy
            // 
            this.menu_CongTy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_DsCty});
            this.menu_CongTy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_CongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_CongTy.Name = "menu_CongTy";
            this.menu_CongTy.Size = new System.Drawing.Size(87, 27);
            this.menu_CongTy.Text = "Công ty";
            // 
            // menuItem_DsCty
            // 
            this.menuItem_DsCty.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_DsCty.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_DsCty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DsCty.Name = "menuItem_DsCty";
            this.menuItem_DsCty.Size = new System.Drawing.Size(223, 26);
            this.menuItem_DsCty.Text = "Danh sách công ty";
            this.menuItem_DsCty.Click += new System.EventHandler(this.menuItem_DsCty_Click);
            // 
            // menu_TrangCaNhan
            // 
            this.menu_TrangCaNhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ThongTinCaNhan,
            this.menuItem_DoiMatKhau,
            this.menuItem_DangXuat});
            this.menu_TrangCaNhan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_TrangCaNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_TrangCaNhan.Name = "menu_TrangCaNhan";
            this.menu_TrangCaNhan.Size = new System.Drawing.Size(146, 27);
            this.menu_TrangCaNhan.Text = "Trang cá nhân";
            // 
            // menuItem_ThongTinCaNhan
            // 
            this.menuItem_ThongTinCaNhan.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_ThongTinCaNhan.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_ThongTinCaNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_ThongTinCaNhan.Name = "menuItem_ThongTinCaNhan";
            this.menuItem_ThongTinCaNhan.Size = new System.Drawing.Size(222, 26);
            this.menuItem_ThongTinCaNhan.Text = "Thông tin cá nhân";
            this.menuItem_ThongTinCaNhan.Click += new System.EventHandler(this.menuItem_ThongTinCaNhan_Click);
            // 
            // menuItem_DoiMatKhau
            // 
            this.menuItem_DoiMatKhau.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_DoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_DoiMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DoiMatKhau.Name = "menuItem_DoiMatKhau";
            this.menuItem_DoiMatKhau.Size = new System.Drawing.Size(222, 26);
            this.menuItem_DoiMatKhau.Text = "Đổi mật khẩu";
            this.menuItem_DoiMatKhau.Click += new System.EventHandler(this.menuItem_DoiMatKhau_Click);
            // 
            // menuItem_DangXuat
            // 
            this.menuItem_DangXuat.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_DangXuat.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_DangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DangXuat.Name = "menuItem_DangXuat";
            this.menuItem_DangXuat.Size = new System.Drawing.Size(222, 26);
            this.menuItem_DangXuat.Text = "Đăng xuất";
            this.menuItem_DangXuat.Click += new System.EventHandler(this.menuItem_DangXuat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(942, 40);
            this.panel1.TabIndex = 5;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(898, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(44, 30);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsViecLam);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ViecLamUT);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_MauCV);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DsCty);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_ThongTin);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DoiMatKhau);
            this.flowLayoutPanel1.Controls.Add(this.ucMenuCard_DangXuat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(942, 396);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ucMenuCard_DsViecLam
            // 
            this.ucMenuCard_DsViecLam.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsViecLam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsViecLam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DsViecLam.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_DsViecLam.ButtonTextColor = System.Drawing.Color.Coral;
            this.ucMenuCard_DsViecLam.Id = 0;
            this.ucMenuCard_DsViecLam.Location = new System.Drawing.Point(24, 24);
            this.ucMenuCard_DsViecLam.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsViecLam.MenuImage = global::FinalProject.Properties.Resources.icons8_job_seeker_96;
            this.ucMenuCard_DsViecLam.MenuName = "Danh sách việc làm";
            this.ucMenuCard_DsViecLam.Name = "ucMenuCard_DsViecLam";
            this.ucMenuCard_DsViecLam.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsViecLam.Size = new System.Drawing.Size(200, 150);
            this.ucMenuCard_DsViecLam.TabIndex = 0;
            this.ucMenuCard_DsViecLam.MenuClick += new System.EventHandler(this.ucMenuCard_DsViecLam_MenuClick);
            // 
            // ucMenuCard_ViecLamUT
            // 
            this.ucMenuCard_ViecLamUT.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_ViecLamUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_ViecLamUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_ViecLamUT.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_ViecLamUT.ButtonTextColor = System.Drawing.Color.Coral;
            this.ucMenuCard_ViecLamUT.Id = 0;
            this.ucMenuCard_ViecLamUT.Location = new System.Drawing.Point(252, 24);
            this.ucMenuCard_ViecLamUT.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ViecLamUT.MenuImage = global::FinalProject.Properties.Resources.icons8_resume_website_96;
            this.ucMenuCard_ViecLamUT.MenuName = "Việc làm đã ứng tuyển";
            this.ucMenuCard_ViecLamUT.Name = "ucMenuCard_ViecLamUT";
            this.ucMenuCard_ViecLamUT.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ViecLamUT.Size = new System.Drawing.Size(200, 150);
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
            this.ucMenuCard_DsCV.Id = 0;
            this.ucMenuCard_DsCV.Location = new System.Drawing.Point(480, 24);
            this.ucMenuCard_DsCV.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCV.MenuImage = global::FinalProject.Properties.Resources.icons8_profiles_96;
            this.ucMenuCard_DsCV.MenuName = "CV của tôi";
            this.ucMenuCard_DsCV.Name = "ucMenuCard_DsCV";
            this.ucMenuCard_DsCV.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCV.Size = new System.Drawing.Size(200, 150);
            this.ucMenuCard_DsCV.TabIndex = 2;
            this.ucMenuCard_DsCV.MenuClick += new System.EventHandler(this.ucMenuCard_DsCV_MenuClick);
            // 
            // ucMenuCard_MauCV
            // 
            this.ucMenuCard_MauCV.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_MauCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_MauCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_MauCV.ButtonBackColor = System.Drawing.Color.CadetBlue;
            this.ucMenuCard_MauCV.ButtonTextColor = System.Drawing.Color.Azure;
            this.ucMenuCard_MauCV.Id = 0;
            this.ucMenuCard_MauCV.Location = new System.Drawing.Point(708, 24);
            this.ucMenuCard_MauCV.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_MauCV.MenuImage = global::FinalProject.Properties.Resources.icons8_cv_96;
            this.ucMenuCard_MauCV.MenuName = "Mẫu CV";
            this.ucMenuCard_MauCV.Name = "ucMenuCard_MauCV";
            this.ucMenuCard_MauCV.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_MauCV.Size = new System.Drawing.Size(200, 150);
            this.ucMenuCard_MauCV.TabIndex = 3;
            this.ucMenuCard_MauCV.MenuClick += new System.EventHandler(this.ucMenuCard_MauCV_MenuClick);
            // 
            // ucMenuCard_DsCty
            // 
            this.ucMenuCard_DsCty.BackColor = System.Drawing.Color.Azure;
            this.ucMenuCard_DsCty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMenuCard_DsCty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMenuCard_DsCty.ButtonBackColor = System.Drawing.Color.Cornsilk;
            this.ucMenuCard_DsCty.ButtonTextColor = System.Drawing.Color.RoyalBlue;
            this.ucMenuCard_DsCty.Id = 0;
            this.ucMenuCard_DsCty.Location = new System.Drawing.Point(24, 202);
            this.ucMenuCard_DsCty.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCty.MenuImage = global::FinalProject.Properties.Resources.icons8_company_96;
            this.ucMenuCard_DsCty.MenuName = "Danh sách công ty";
            this.ucMenuCard_DsCty.Name = "ucMenuCard_DsCty";
            this.ucMenuCard_DsCty.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DsCty.Size = new System.Drawing.Size(200, 150);
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
            this.ucMenuCard_ThongTin.Id = 0;
            this.ucMenuCard_ThongTin.Location = new System.Drawing.Point(252, 202);
            this.ucMenuCard_ThongTin.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ThongTin.MenuImage = global::FinalProject.Properties.Resources.icons8_name_96;
            this.ucMenuCard_ThongTin.MenuName = "Thông tin cá nhân";
            this.ucMenuCard_ThongTin.Name = "ucMenuCard_ThongTin";
            this.ucMenuCard_ThongTin.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_ThongTin.Size = new System.Drawing.Size(200, 150);
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
            this.ucMenuCard_DoiMatKhau.Id = 0;
            this.ucMenuCard_DoiMatKhau.Location = new System.Drawing.Point(480, 202);
            this.ucMenuCard_DoiMatKhau.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DoiMatKhau.MenuImage = global::FinalProject.Properties.Resources.icons8_password_144;
            this.ucMenuCard_DoiMatKhau.MenuName = "Đổi mật khẩu";
            this.ucMenuCard_DoiMatKhau.Name = "ucMenuCard_DoiMatKhau";
            this.ucMenuCard_DoiMatKhau.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DoiMatKhau.Size = new System.Drawing.Size(200, 150);
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
            this.ucMenuCard_DangXuat.Id = 0;
            this.ucMenuCard_DangXuat.Location = new System.Drawing.Point(708, 202);
            this.ucMenuCard_DangXuat.Margin = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DangXuat.MenuImage = global::FinalProject.Properties.Resources.icons8_log_out_96;
            this.ucMenuCard_DangXuat.MenuName = "Đăng xuất";
            this.ucMenuCard_DangXuat.Name = "ucMenuCard_DangXuat";
            this.ucMenuCard_DangXuat.Padding = new System.Windows.Forms.Padding(14);
            this.ucMenuCard_DangXuat.Size = new System.Drawing.Size(200, 150);
            this.ucMenuCard_DangXuat.TabIndex = 7;
            this.ucMenuCard_DangXuat.MenuClick += new System.EventHandler(this.ucMenuCard_DangXuat_MenuClick);
            // 
            // FCandidateHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.hcmute;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 499);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_MenuStrip);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FCandidateHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCandidateHomePage";
            this.Load += new System.EventHandler(this.FCandidateHomePage_Load);
            this.menuStrip_MenuStrip.ResumeLayout(false);
            this.menuStrip_MenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_ViecLam;
        private System.Windows.Forms.ToolStripMenuItem menu_HoSo;
        private System.Windows.Forms.ToolStripMenuItem menu_CongTy;
        private System.Windows.Forms.ToolStripMenuItem menu_TrangCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Dsvl;
        private System.Windows.Forms.ToolStripMenuItem menuItem_VieclamUT;
        private System.Windows.Forms.ToolStripMenuItem menuItem_QlyCv;
        private System.Windows.Forms.ToolStripMenuItem menuItem_MauCv;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DsCty;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DoiMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Close;
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