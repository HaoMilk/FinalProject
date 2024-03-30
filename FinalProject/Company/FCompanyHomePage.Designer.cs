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
            this.menuItem_VieclamUT = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_HoSoDaDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_HoSoChuaDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TrangCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ThongTinCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.menuStrip_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImage = global::FinalProject.Properties.Resources.hcmute;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 36);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(1135, 646);
            this.pictureBox_Image.TabIndex = 7;
            this.pictureBox_Image.TabStop = false;
            // 
            // menuStrip_MenuStrip
            // 
            this.menuStrip_MenuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip_MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ViecLam,
            this.menu_HoSo,
            this.menu_TrangCaNhan});
            this.menuStrip_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MenuStrip.Name = "menuStrip_MenuStrip";
            this.menuStrip_MenuStrip.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip_MenuStrip.Size = new System.Drawing.Size(1135, 36);
            this.menuStrip_MenuStrip.TabIndex = 6;
            this.menuStrip_MenuStrip.Text = "menuStrip1";
            // 
            // menu_ViecLam
            // 
            this.menu_ViecLam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Dsvl,
            this.ToolStripMenuItem_ChinhSuaCongViec,
            this.menuItem_VieclamUT});
            this.menu_ViecLam.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ViecLam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ViecLam.Name = "menu_ViecLam";
            this.menu_ViecLam.Size = new System.Drawing.Size(197, 28);
            this.menu_ViecLam.Text = "Quản lý ứng tuyển";
            // 
            // menuItem_Dsvl
            // 
            this.menuItem_Dsvl.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_Dsvl.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_Dsvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_Dsvl.Name = "menuItem_Dsvl";
            this.menuItem_Dsvl.Size = new System.Drawing.Size(344, 28);
            this.menuItem_Dsvl.Text = "Tạo và chỉnh sửa công việc";
            this.menuItem_Dsvl.Click += new System.EventHandler(this.menuItem_Dsvl_Click);
            // 
            // ToolStripMenuItem_ChinhSuaCongViec
            // 
            this.ToolStripMenuItem_ChinhSuaCongViec.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToolStripMenuItem_ChinhSuaCongViec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolStripMenuItem_ChinhSuaCongViec.Name = "ToolStripMenuItem_ChinhSuaCongViec";
            this.ToolStripMenuItem_ChinhSuaCongViec.Size = new System.Drawing.Size(344, 28);
            this.ToolStripMenuItem_ChinhSuaCongViec.Text = "Danh sách công việc";
            this.ToolStripMenuItem_ChinhSuaCongViec.Click += new System.EventHandler(this.ToolStripMenuItem_ChinhSuaCongViec_Click);
            // 
            // menuItem_VieclamUT
            // 
            this.menuItem_VieclamUT.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_VieclamUT.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_VieclamUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_VieclamUT.Name = "menuItem_VieclamUT";
            this.menuItem_VieclamUT.Size = new System.Drawing.Size(344, 28);
            this.menuItem_VieclamUT.Text = "Lịch sử tuyển dụng";
            this.menuItem_VieclamUT.Click += new System.EventHandler(this.menuItem_VieclamUT_Click);
            // 
            // menu_HoSo
            // 
            this.menu_HoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_HoSoDaDuyet,
            this.menuItem_HoSoChuaDuyet});
            this.menu_HoSo.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_HoSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_HoSo.Name = "menu_HoSo";
            this.menu_HoSo.Size = new System.Drawing.Size(155, 28);
            this.menu_HoSo.Text = "Quản lý hồ sơ";
            // 
            // menuItem_HoSoDaDuyet
            // 
            this.menuItem_HoSoDaDuyet.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_HoSoDaDuyet.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_HoSoDaDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_HoSoDaDuyet.Name = "menuItem_HoSoDaDuyet";
            this.menuItem_HoSoDaDuyet.Size = new System.Drawing.Size(263, 28);
            this.menuItem_HoSoDaDuyet.Text = "Hồ sơ đã duyệt";
            this.menuItem_HoSoDaDuyet.Click += new System.EventHandler(this.hồSơĐãDuyệnToolStripMenuItem_Click);
            // 
            // menuItem_HoSoChuaDuyet
            // 
            this.menuItem_HoSoChuaDuyet.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_HoSoChuaDuyet.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_HoSoChuaDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_HoSoChuaDuyet.Name = "menuItem_HoSoChuaDuyet";
            this.menuItem_HoSoChuaDuyet.Size = new System.Drawing.Size(263, 28);
            this.menuItem_HoSoChuaDuyet.Text = "Hồ sơ chưa duyệt";
            this.menuItem_HoSoChuaDuyet.Click += new System.EventHandler(this.hồSơChưaDuyệtToolStripMenuItem_Click);
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
            this.menuItem_ThongTinCongTy.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_ThongTinCongTy.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_ThongTinCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_ThongTinCongTy.Name = "menuItem_ThongTinCongTy";
            this.menuItem_ThongTinCongTy.Size = new System.Drawing.Size(257, 28);
            this.menuItem_ThongTinCongTy.Text = "Thông tin công ty";
            this.menuItem_ThongTinCongTy.Click += new System.EventHandler(this.menuItem_ThongTinCaNhan_Click);
            // 
            // menuItem_DoiMatKhau
            // 
            this.menuItem_DoiMatKhau.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_DoiMatKhau.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_DoiMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DoiMatKhau.Name = "menuItem_DoiMatKhau";
            this.menuItem_DoiMatKhau.Size = new System.Drawing.Size(257, 28);
            this.menuItem_DoiMatKhau.Text = "Đổi mật khẩu";
            this.menuItem_DoiMatKhau.Click += new System.EventHandler(this.menuItem_DoiMatKhau_Click);
            // 
            // menuItem_DangXuat
            // 
            this.menuItem_DangXuat.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuItem_DangXuat.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuItem_DangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_DangXuat.Name = "menuItem_DangXuat";
            this.menuItem_DangXuat.Size = new System.Drawing.Size(257, 28);
            this.menuItem_DangXuat.Text = "Đăng xuất";
            this.menuItem_DangXuat.Click += new System.EventHandler(this.menuItem_DangXuat_Click);
            // 
            // FCompanyHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 682);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.menuStrip_MenuStrip);
            this.Name = "FCompanyHomePage";
            this.Text = "FCompanyHomePage";
            this.Load += new System.EventHandler(this.FCompanyHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.menuStrip_MenuStrip.ResumeLayout(false);
            this.menuStrip_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.MenuStrip menuStrip_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_ViecLam;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Dsvl;
        private System.Windows.Forms.ToolStripMenuItem menuItem_VieclamUT;
        private System.Windows.Forms.ToolStripMenuItem menu_HoSo;
        private System.Windows.Forms.ToolStripMenuItem menuItem_HoSoDaDuyet;
        private System.Windows.Forms.ToolStripMenuItem menuItem_HoSoChuaDuyet;
        private System.Windows.Forms.ToolStripMenuItem menu_TrangCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ThongTinCongTy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ChinhSuaCongViec;
    }
}