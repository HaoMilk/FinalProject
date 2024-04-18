namespace FinalProject.Company.GUI
{
    partial class FDanhSachViecLam
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
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_NgheNghiep = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_MucLuong = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_KinhNghiem = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_DiaDiem = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_CongViec = new System.Windows.Forms.FlowLayoutPanel();
            this.ucPagination = new FinalProject.UC.UCPagination();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_TimKiem.FlatAppearance.BorderSize = 3;
            this.button_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.Image = global::FinalProject.Properties.Resources.icons8_search_32;
            this.button_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_TimKiem.Location = new System.Drawing.Point(1113, 3);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(203, 83);
            this.button_TimKiem.TabIndex = 30;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.comboBox_NgheNghiep);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(228, 5);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox6.Size = new System.Drawing.Size(210, 79);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tên công việc";
            // 
            // comboBox_NgheNghiep
            // 
            this.comboBox_NgheNghiep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_NgheNghiep.FormattingEnabled = true;
            this.comboBox_NgheNghiep.Location = new System.Drawing.Point(6, 28);
            this.comboBox_NgheNghiep.Name = "comboBox_NgheNghiep";
            this.comboBox_NgheNghiep.Size = new System.Drawing.Size(198, 30);
            this.comboBox_NgheNghiep.TabIndex = 0;
            this.comboBox_NgheNghiep.Text = "Tất cả công việc";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.textBox_TimKiem);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(210, 79);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vị trí tuyển dụng";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TimKiem.Location = new System.Drawing.Point(6, 28);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(198, 30);
            this.textBox_TimKiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.comboBox_MucLuong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(450, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(210, 79);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mức lương";
            // 
            // comboBox_MucLuong
            // 
            this.comboBox_MucLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_MucLuong.FormattingEnabled = true;
            this.comboBox_MucLuong.Location = new System.Drawing.Point(6, 28);
            this.comboBox_MucLuong.Name = "comboBox_MucLuong";
            this.comboBox_MucLuong.Size = new System.Drawing.Size(198, 30);
            this.comboBox_MucLuong.TabIndex = 1;
            this.comboBox_MucLuong.Text = "Tất cả mức lương";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.comboBox_KinhNghiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(894, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(210, 79);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kinh Nghiệm";
            // 
            // comboBox_KinhNghiem
            // 
            this.comboBox_KinhNghiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_KinhNghiem.FormattingEnabled = true;
            this.comboBox_KinhNghiem.Location = new System.Drawing.Point(6, 28);
            this.comboBox_KinhNghiem.Name = "comboBox_KinhNghiem";
            this.comboBox_KinhNghiem.Size = new System.Drawing.Size(198, 30);
            this.comboBox_KinhNghiem.TabIndex = 1;
            this.comboBox_KinhNghiem.Text = "Tất cả kinh nghiệm";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.comboBox_DiaDiem);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(672, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox4.Size = new System.Drawing.Size(210, 79);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Địa điểm";
            // 
            // comboBox_DiaDiem
            // 
            this.comboBox_DiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_DiaDiem.FormattingEnabled = true;
            this.comboBox_DiaDiem.Location = new System.Drawing.Point(6, 28);
            this.comboBox_DiaDiem.Name = "comboBox_DiaDiem";
            this.comboBox_DiaDiem.Size = new System.Drawing.Size(198, 30);
            this.comboBox_DiaDiem.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_TimKiem, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1319, 89);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1269, 6);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(50, 24);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button_Close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 11);
            this.panel4.Size = new System.Drawing.Size(1319, 41);
            this.panel4.TabIndex = 30;
            // 
            // flowLayoutPanel_CongViec
            // 
            this.flowLayoutPanel_CongViec.AutoScroll = true;
            this.flowLayoutPanel_CongViec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel_CongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel_CongViec.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanel_CongViec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel_CongViec.Name = "flowLayoutPanel_CongViec";
            this.flowLayoutPanel_CongViec.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.flowLayoutPanel_CongViec.Size = new System.Drawing.Size(1319, 544);
            this.flowLayoutPanel_CongViec.TabIndex = 37;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPagination.Location = new System.Drawing.Point(0, 674);
            this.ucPagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(1319, 73);
            this.ucPagination.TabIndex = 31;
            this.ucPagination.TotalRecord = 15;
            // 
            // FDanhSachViecLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 747);
            this.Controls.Add(this.flowLayoutPanel_CongViec);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ucPagination);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachViecLam";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachViecLam_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button_TimKiem;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.ComboBox comboBox_NgheNghiep;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox_TimKiem;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox comboBox_MucLuong;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox comboBox_KinhNghiem;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox comboBox_DiaDiem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ColorDialog colorDialog2;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.Panel panel4;
        public UC.UCPagination ucPagination;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CongViec;
    }
}