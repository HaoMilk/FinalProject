namespace FinalProject.Company.GUI
{
    partial class FHoSoUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHoSoUT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucPagination = new FinalProject.UC.UCPagination();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(39, 968);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 27);
            this.panel1.TabIndex = 0;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Location = new System.Drawing.Point(39, 995);
            this.ucPagination.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(1465, 66);
            this.ucPagination.TabIndex = 9;
            this.ucPagination.TotalRecord = 0;
            this.ucPagination.CurrentPageChanged += new System.EventHandler(this.ucPagination_CurrentPageChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 107);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1465, 132);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Name.Controls.Add(this.button_TimKiem);
            this.groupBox_Name.Controls.Add(this.comboBox_TrangThai);
            this.groupBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Name.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Name.Location = new System.Drawing.Point(16, 15);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.groupBox_Name.Size = new System.Drawing.Size(1433, 101);
            this.groupBox_Name.TabIndex = 15;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Tìm kiếm";
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackgroundImage = global::FinalProject.Properties.Resources.icons8_search_24;
            this.button_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TimKiem.FlatAppearance.BorderSize = 0;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.button_TimKiem.Location = new System.Drawing.Point(1313, 36);
            this.button_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(104, 50);
            this.button_TimKiem.TabIndex = 3;
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Items.AddRange(new object[] {
            "Hồ sơ đã duyệt",
            "Hồ sơ chưa duyệt",
            "Hồ sơ bị loại"});
            this.comboBox_TrangThai.Location = new System.Drawing.Point(16, 36);
            this.comboBox_TrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(405, 29);
            this.comboBox_TrangThai.TabIndex = 0;
            this.comboBox_TrangThai.Text = "Hồ sơ chưa duyệt";
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.OrangeRed;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Azure;
            this.label_Name.Location = new System.Drawing.Point(39, 50);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(1465, 57);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "QUẢN LÝ CV";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(39, 239);
            this.flowLayoutPanel_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(1465, 729);
            this.flowLayoutPanel_Data.TabIndex = 17;
            // 
            // FHoSoUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1543, 1102);
            this.Controls.Add(this.flowLayoutPanel_Data);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucPagination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FHoSoUT";
            this.Padding = new System.Windows.Forms.Padding(39, 0, 39, 41);
            this.Text = "Quản lý CV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FQlyCv_Load);
            this.Controls.SetChildIndex(this.ucPagination, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel_Data, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FinalProject.UC.UCPagination ucPagination;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
        private System.Windows.Forms.ComboBox comboBox_TrangThai;
        private System.Windows.Forms.Button button_TimKiem;
    }
}