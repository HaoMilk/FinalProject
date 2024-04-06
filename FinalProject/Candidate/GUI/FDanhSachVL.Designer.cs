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
            this.ucPagination = new FinalProject.UC.UCPagination();
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
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.menuStrip_Filter);
            this.panel1.Controls.Add(this.groupBox_ViTri);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 534);
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
            this.button_Search.Location = new System.Drawing.Point(0, 493);
            this.button_Search.Name = "button_Search";
            this.button_Search.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Search.Size = new System.Drawing.Size(307, 41);
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
            this.menuStrip_Filter.Location = new System.Drawing.Point(0, 202);
            this.menuStrip_Filter.Name = "menuStrip_Filter";
            this.menuStrip_Filter.Padding = new System.Windows.Forms.Padding(20);
            this.menuStrip_Filter.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_Filter.Size = new System.Drawing.Size(307, 182);
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
            this.comboBox_DiaDiem.Size = new System.Drawing.Size(264, 35);
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
            this.comboBox_NgheNghiep.Size = new System.Drawing.Size(264, 35);
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
            this.comboBox_MucLuong.Size = new System.Drawing.Size(264, 35);
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
            this.comboBox_KinhNghiem.Size = new System.Drawing.Size(264, 35);
            this.comboBox_KinhNghiem.ToolTipText = "Kinh nghiệm";
            // 
            // groupBox_ViTri
            // 
            this.groupBox_ViTri.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_ViTri.Controls.Add(this.textBox_TimKiem);
            this.groupBox_ViTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ViTri.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ViTri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_ViTri.Location = new System.Drawing.Point(0, 122);
            this.groupBox_ViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ViTri.Name = "groupBox_ViTri";
            this.groupBox_ViTri.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.groupBox_ViTri.Size = new System.Drawing.Size(307, 80);
            this.groupBox_ViTri.TabIndex = 1;
            this.groupBox_ViTri.TabStop = false;
            this.groupBox_ViTri.Text = "Vị trí tuyển dụng";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TimKiem.Location = new System.Drawing.Point(20, 27);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(267, 29);
            this.textBox_TimKiem.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 122);
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
            this.pictureBox1.Size = new System.Drawing.Size(307, 122);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.flowLayoutPanel_CongViec);
            this.panel3.Controls.Add(this.ucPagination);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(307, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 534);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel_CongViec
            // 
            this.flowLayoutPanel_CongViec.AutoScroll = true;
            this.flowLayoutPanel_CongViec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel_CongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CongViec.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_CongViec.Name = "flowLayoutPanel_CongViec";
            this.flowLayoutPanel_CongViec.Padding = new System.Windows.Forms.Padding(9);
            this.flowLayoutPanel_CongViec.Size = new System.Drawing.Size(639, 487);
            this.flowLayoutPanel_CongViec.TabIndex = 3;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Location = new System.Drawing.Point(0, 487);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(639, 47);
            this.ucPagination.TabIndex = 0;
            this.ucPagination.TotalRecord = 15;
            this.ucPagination.CurrentPageChanged += new System.EventHandler(this.ucPagination_CurrentPageChanged);
            // 
            // FDanhSachVL_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachVL_Name";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachVL_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
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
        private System.Windows.Forms.ToolStripComboBox comboBox_DiaDiem;
        private System.Windows.Forms.ToolStripComboBox comboBox_KinhNghiem;
        private System.Windows.Forms.ToolStripComboBox comboBox_NgheNghiep;
        private System.Windows.Forms.ToolStripComboBox comboBox_MucLuong;
        private UCCustomButton button_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CongViec;
        private UCPagination ucPagination;
    }
}