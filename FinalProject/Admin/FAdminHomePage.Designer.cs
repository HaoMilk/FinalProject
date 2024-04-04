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
            this.chỉnhSửaCôngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DanhSachUngVien = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmỨngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TaiKhoanUngVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DanhSachCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaCôngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TaiKhoanMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsM_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.ucMenuCard_XetDuyet = new FinalProject.UC.UCMenuCard();
            this.ucMenuCard_ThongKe = new FinalProject.UC.UCMenuCard();
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
            this.chỉnhSửaCôngViệcToolStripMenuItem});
            this.menu_ViecLam.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ViecLam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_ViecLam.Name = "menu_ViecLam";
            this.menu_ViecLam.Size = new System.Drawing.Size(172, 27);
            this.menu_ViecLam.Text = "Quản lý công việc";
            // 
            // menu_DanhSachCongViec
            // 
            this.menu_DanhSachCongViec.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu_DanhSachCongViec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_DanhSachCongViec.Name = "menu_DanhSachCongViec";
            this.menu_DanhSachCongViec.Size = new System.Drawing.Size(265, 28);
            this.menu_DanhSachCongViec.Text = "Danh sách công việc";
            this.menu_DanhSachCongViec.Click += new System.EventHandler(this.menu_DanhSachCongViec_Click);
            // 
            // chỉnhSửaCôngViệcToolStripMenuItem
            // 
            this.chỉnhSửaCôngViệcToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.chỉnhSửaCôngViệcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chỉnhSửaCôngViệcToolStripMenuItem.Name = "chỉnhSửaCôngViệcToolStripMenuItem";
            this.chỉnhSửaCôngViệcToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.chỉnhSửaCôngViệcToolStripMenuItem.Text = "Chỉnh sửa công việc";
            this.chỉnhSửaCôngViệcToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaCôngViệcToolStripMenuItem_Click);
            // 
            // menu_HoSo
            // 
            this.menu_HoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DanhSachUngVien,
            this.thêmỨngViênToolStripMenuItem,
            this.menu_TaiKhoanUngVien});
            this.menu_HoSo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_HoSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_HoSo.Name = "menu_HoSo";
            this.menu_HoSo.Size = new System.Drawing.Size(167, 27);
            this.menu_HoSo.Text = "Quản lý ứng viên";
            // 
            // menu_DanhSachUngVien
            // 
            this.menu_DanhSachUngVien.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu_DanhSachUngVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_DanhSachUngVien.Name = "menu_DanhSachUngVien";
            this.menu_DanhSachUngVien.Size = new System.Drawing.Size(286, 28);
            this.menu_DanhSachUngVien.Text = "Danh sách ứng viên";
            this.menu_DanhSachUngVien.Click += new System.EventHandler(this.menu_DanhSachUngVien_Click);
            // 
            // thêmỨngViênToolStripMenuItem
            // 
            this.thêmỨngViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.thêmỨngViênToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thêmỨngViênToolStripMenuItem.Name = "thêmỨngViênToolStripMenuItem";
            this.thêmỨngViênToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.thêmỨngViênToolStripMenuItem.Text = "Chỉnh sửa ứng viên";
            this.thêmỨngViênToolStripMenuItem.Click += new System.EventHandler(this.thêmỨngViênToolStripMenuItem_Click);
            // 
            // menu_TaiKhoanUngVien
            // 
            this.menu_TaiKhoanUngVien.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.chỉnhSửaCôngTyToolStripMenuItem,
            this.menu_TaiKhoanMatKhau});
            this.menu_CongTy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_CongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_CongTy.Name = "menu_CongTy";
            this.menu_CongTy.Size = new System.Drawing.Size(158, 27);
            this.menu_CongTy.Text = "Quản lý Công ty";
            // 
            // menu_DanhSachCongTy
            // 
            this.menu_DanhSachCongTy.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu_DanhSachCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_DanhSachCongTy.Name = "menu_DanhSachCongTy";
            this.menu_DanhSachCongTy.Size = new System.Drawing.Size(286, 28);
            this.menu_DanhSachCongTy.Text = "Danh sách công ty";
            this.menu_DanhSachCongTy.Click += new System.EventHandler(this.menu_DanhSachCongTy_Click);
            // 
            // chỉnhSửaCôngTyToolStripMenuItem
            // 
            this.chỉnhSửaCôngTyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.chỉnhSửaCôngTyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.chỉnhSửaCôngTyToolStripMenuItem.Name = "chỉnhSửaCôngTyToolStripMenuItem";
            this.chỉnhSửaCôngTyToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.chỉnhSửaCôngTyToolStripMenuItem.Text = "Chỉnh sửa công ty";
            this.chỉnhSửaCôngTyToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaCôngTyToolStripMenuItem_Click);
            // 
            // menu_TaiKhoanMatKhau
            // 
            this.menu_TaiKhoanMatKhau.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.ucMenuCard_ThongKe.MenuClick += new System.EventHandler(this.ucMenuCard1_MenuClick);
            // 
            // FAdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 412);
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
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaCôngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_DanhSachUngVien;
        private System.Windows.Forms.ToolStripMenuItem thêmỨngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_DanhSachCongTy;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaCôngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_TaiKhoanUngVien;
        private System.Windows.Forms.ToolStripMenuItem menu_TaiKhoanMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tsM_ThongKe;
        private UC.UCMenuCard ucMenuCard_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private UC.UCMenuCard ucMenuCard_XetDuyet;
    }
}