namespace FinalProject.Candidate.GUI
{
    partial class FDanhSachVL_Name
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Search = new FinalProject.UC.UCCustomButton();
            this.menuStrip_Filter = new System.Windows.Forms.MenuStrip();
            this.comboBox_ViTri = new System.Windows.Forms.ToolStripComboBox();
            this.comboBox_NgheNghiep = new System.Windows.Forms.ToolStripComboBox();
            this.comboBox_MucLuong = new System.Windows.Forms.ToolStripComboBox();
            this.comboBox_KinhNghiem = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox_ViTri = new System.Windows.Forms.GroupBox();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_CongViec = new System.Windows.Forms.FlowLayoutPanel();
            this.label_SoLuongViecLam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip_Filter.SuspendLayout();
            this.groupBox_ViTri.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.menuStrip_Filter);
            this.panel1.Controls.Add(this.groupBox_ViTri);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 623);
            this.panel1.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Search.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.button_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_Search.BorderRadius = 0;
            this.button_Search.BorderSize = 0;
            this.button_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Image = global::FinalProject.Properties.Resources.icons8_search_32;
            this.button_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Search.Location = new System.Drawing.Point(0, 569);
            this.button_Search.Name = "button_Search";
            this.button_Search.Padding = new System.Windows.Forms.Padding(5);
            this.button_Search.Size = new System.Drawing.Size(292, 54);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Tìm kiếm";
            this.button_Search.TextColor = System.Drawing.Color.White;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // menuStrip_Filter
            // 
            this.menuStrip_Filter.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip_Filter.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Filter.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Filter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox_ViTri,
            this.comboBox_NgheNghiep,
            this.comboBox_MucLuong,
            this.comboBox_KinhNghiem});
            this.menuStrip_Filter.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip_Filter.Location = new System.Drawing.Point(0, 188);
            this.menuStrip_Filter.Name = "menuStrip_Filter";
            this.menuStrip_Filter.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip_Filter.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_Filter.Size = new System.Drawing.Size(292, 146);
            this.menuStrip_Filter.TabIndex = 2;
            this.menuStrip_Filter.Text = "MenuFilter";
            // 
            // comboBox_ViTri
            // 
            this.comboBox_ViTri.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_ViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_ViTri.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_ViTri.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_ViTri.Items.AddRange(new object[] {
            "Tất cả vị trí việc làm",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Kiên Giang",
            "Kon Tum",
            "Khánh Hòa",
            "Lai Châu",
            "Lạng Sơn",
            "Lào Cai",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Ninh Bình",
            "Ninh Thuận",
            "Nghệ An",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ninh",
            "Quảng Ngãi",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Tiền Giang",
            "Tuyên Quang",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thành phố Hồ Chí Minh",
            "Thừa Thiên Huế",
            "Trà Vinh",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.comboBox_ViTri.Name = "comboBox_ViTri";
            this.comboBox_ViTri.Size = new System.Drawing.Size(284, 35);
            // 
            // comboBox_NgheNghiep
            // 
            this.comboBox_NgheNghiep.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_NgheNghiep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NgheNghiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_NgheNghiep.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_NgheNghiep.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_NgheNghiep.Items.AddRange(new object[] {
            "Tất cả ngành nghề",
            "IT phần mềm",
            "Kinh doanh / Bán hàng",
            "Marketing / Truyền thông / Quảng cáo",
            "Hành chính / Văn phòng",
            "Dịch vụ khách hàng",
            "Tư vấn"});
            this.comboBox_NgheNghiep.Name = "comboBox_NgheNghiep";
            this.comboBox_NgheNghiep.Size = new System.Drawing.Size(284, 35);
            // 
            // comboBox_MucLuong
            // 
            this.comboBox_MucLuong.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_MucLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MucLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MucLuong.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_MucLuong.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_MucLuong.Items.AddRange(new object[] {
            "Tất cả mức lương",
            "Dưới 10 triệu",
            "10 - 15 triệu",
            "15 - 20 triệu",
            "20 - 25 triệu",
            "25 - 30 triệu",
            "30 - 50 triệu",
            "Trên 50 triệu",
            "Thỏa thuận"});
            this.comboBox_MucLuong.Name = "comboBox_MucLuong";
            this.comboBox_MucLuong.Size = new System.Drawing.Size(284, 35);
            // 
            // comboBox_KinhNghiem
            // 
            this.comboBox_KinhNghiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_KinhNghiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_KinhNghiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_KinhNghiem.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_KinhNghiem.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_KinhNghiem.Items.AddRange(new object[] {
            "Tất cả kinh nghiệm",
            "Dưới 1 năm",
            "1 - 2 năm",
            "2 - 4 năm",
            "4 - 5 năm",
            "Trên 5 năm"});
            this.comboBox_KinhNghiem.Name = "comboBox_KinhNghiem";
            this.comboBox_KinhNghiem.Size = new System.Drawing.Size(284, 35);
            // 
            // groupBox_ViTri
            // 
            this.groupBox_ViTri.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_ViTri.Controls.Add(this.textBox_TimKiem);
            this.groupBox_ViTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ViTri.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ViTri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_ViTri.Location = new System.Drawing.Point(0, 130);
            this.groupBox_ViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ViTri.Name = "groupBox_ViTri";
            this.groupBox_ViTri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ViTri.Size = new System.Drawing.Size(292, 58);
            this.groupBox_ViTri.TabIndex = 1;
            this.groupBox_ViTri.TabStop = false;
            this.groupBox_ViTri.Text = "Vị trí tuyển dụng";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TimKiem.Location = new System.Drawing.Point(3, 24);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(286, 29);
            this.textBox_TimKiem.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 130);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.job_search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.flowLayoutPanel_CongViec);
            this.panel3.Controls.Add(this.label_SoLuongViecLam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(292, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 623);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel_CongViec
            // 
            this.flowLayoutPanel_CongViec.AutoScroll = true;
            this.flowLayoutPanel_CongViec.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_CongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CongViec.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel_CongViec.Name = "flowLayoutPanel_CongViec";
            this.flowLayoutPanel_CongViec.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_CongViec.Size = new System.Drawing.Size(1048, 583);
            this.flowLayoutPanel_CongViec.TabIndex = 3;
            // 
            // label_SoLuongViecLam
            // 
            this.label_SoLuongViecLam.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_SoLuongViecLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_SoLuongViecLam.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoLuongViecLam.ForeColor = System.Drawing.SystemColors.Control;
            this.label_SoLuongViecLam.Location = new System.Drawing.Point(0, 0);
            this.label_SoLuongViecLam.Name = "label_SoLuongViecLam";
            this.label_SoLuongViecLam.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label_SoLuongViecLam.Size = new System.Drawing.Size(1048, 40);
            this.label_SoLuongViecLam.TabIndex = 4;
            this.label_SoLuongViecLam.Text = "Số lượng việc làm: 0";
            this.label_SoLuongViecLam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FDanhSachVL_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1340, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachVL_Name";
            this.Text = "Danh sách việc làm";
            this.Load += new System.EventHandler(this.FDanhSachVL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip_Filter.ResumeLayout(false);
            this.menuStrip_Filter.PerformLayout();
            this.groupBox_ViTri.ResumeLayout(false);
            this.groupBox_ViTri.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_ViTri;
        private System.Windows.Forms.MenuStrip menuStrip_Filter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CongViec;
        private System.Windows.Forms.Label label_SoLuongViecLam;
        private System.Windows.Forms.ToolStripComboBox comboBox_ViTri;
        private System.Windows.Forms.ToolStripComboBox comboBox_KinhNghiem;
        private System.Windows.Forms.ToolStripComboBox comboBox_NgheNghiep;
        private System.Windows.Forms.ToolStripComboBox comboBox_MucLuong;
        private UC.UCCustomButton button_Search;
    }
}