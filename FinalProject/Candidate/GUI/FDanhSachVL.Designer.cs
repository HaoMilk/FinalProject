using FinalProject.UC;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDanhSachVL_Name));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Search = new FinalProject.UC.UCCustomButton();
            this.menuStrip_Filter = new System.Windows.Forms.MenuStrip();
            this.comboBox_DiaDiem = new System.Windows.Forms.ToolStripComboBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip_Filter.SuspendLayout();
            this.groupBox_ViTri.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.menuStrip_Filter);
            this.panel1.Controls.Add(this.groupBox_ViTri);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 553);
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
            this.button_Search.Location = new System.Drawing.Point(0, 499);
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
            this.comboBox_DiaDiem,
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
            // comboBox_DiaDiem
            // 
            this.comboBox_DiaDiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_DiaDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DiaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_DiaDiem.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_DiaDiem.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_DiaDiem.Name = "comboBox_DiaDiem";
            this.comboBox_DiaDiem.Size = new System.Drawing.Size(284, 35);
            this.comboBox_DiaDiem.ToolTipText = "Địa điểm";
            // 
            // comboBox_NgheNghiep
            // 
            this.comboBox_NgheNghiep.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_NgheNghiep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NgheNghiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_NgheNghiep.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_NgheNghiep.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_NgheNghiep.Name = "comboBox_NgheNghiep";
            this.comboBox_NgheNghiep.Size = new System.Drawing.Size(284, 35);
            this.comboBox_NgheNghiep.ToolTipText = "Nghề nghiệp";
            // 
            // comboBox_MucLuong
            // 
            this.comboBox_MucLuong.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_MucLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MucLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MucLuong.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_MucLuong.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_MucLuong.Name = "comboBox_MucLuong";
            this.comboBox_MucLuong.Size = new System.Drawing.Size(284, 35);
            this.comboBox_MucLuong.ToolTipText = "Mức lương";
            // 
            // comboBox_KinhNghiem
            // 
            this.comboBox_KinhNghiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox_KinhNghiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_KinhNghiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_KinhNghiem.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox_KinhNghiem.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_KinhNghiem.Name = "comboBox_KinhNghiem";
            this.comboBox_KinhNghiem.Size = new System.Drawing.Size(284, 35);
            this.comboBox_KinhNghiem.ToolTipText = "Kinh nghiệm";
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
            this.panel3.Location = new System.Drawing.Point(312, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 553);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel_CongViec
            // 
            this.flowLayoutPanel_CongViec.AutoScroll = true;
            this.flowLayoutPanel_CongViec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel_CongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CongViec.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel_CongViec.Name = "flowLayoutPanel_CongViec";
            this.flowLayoutPanel_CongViec.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_CongViec.Size = new System.Drawing.Size(690, 513);
            this.flowLayoutPanel_CongViec.TabIndex = 3;
            this.flowLayoutPanel_CongViec.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_CongViec_Paint);
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
            this.label_SoLuongViecLam.Size = new System.Drawing.Size(690, 40);
            this.label_SoLuongViecLam.TabIndex = 4;
            this.label_SoLuongViecLam.Text = "Số lượng việc làm: 0";
            this.label_SoLuongViecLam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button_Close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.panel4.Size = new System.Drawing.Size(982, 40);
            this.panel4.TabIndex = 6;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(938, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(44, 25);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // FDanhSachVL_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachVL_Name";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách việc làm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Label label_SoLuongViecLam;
        private System.Windows.Forms.ToolStripComboBox comboBox_DiaDiem;
        private System.Windows.Forms.ToolStripComboBox comboBox_KinhNghiem;
        private System.Windows.Forms.ToolStripComboBox comboBox_NgheNghiep;
        private System.Windows.Forms.ToolStripComboBox comboBox_MucLuong;
        private UCCustomButton button_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CongViec;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_Close;
    }
}