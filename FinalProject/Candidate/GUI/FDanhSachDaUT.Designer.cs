namespace FinalProject.Candidate.GUI
{
    partial class FDanhSachDaUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDanhSachDaUT));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.ucPagination = new FinalProject.UC.UCPagination();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.groupBox_TenTrangThai = new System.Windows.Forms.GroupBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.groupBox_TenTrangThai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.flowLayoutPanel_Data);
            this.panelLeft.Controls.Add(this.ucPagination);
            this.panelLeft.Controls.Add(this.panelFilter);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 2);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(670, 730);
            this.panelLeft.TabIndex = 0;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.AutoScroll = true;
            this.flowLayoutPanel_Data.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(0, 98);
            this.flowLayoutPanel_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(670, 585);
            this.flowLayoutPanel_Data.TabIndex = 1;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Location = new System.Drawing.Point(0, 683);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(670, 47);
            this.ucPagination.TabIndex = 0;
            this.ucPagination.TotalRecord = 20;
            this.ucPagination.CurrentPageChanged += new System.EventHandler(this.ucPagination_CurrentPageChanged);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Goldenrod;
            this.panelFilter.Controls.Add(this.groupBox_TenTrangThai);
            this.panelFilter.Controls.Add(this.label_Ten);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(670, 98);
            this.panelFilter.TabIndex = 0;
            // 
            // groupBox_TenTrangThai
            // 
            this.groupBox_TenTrangThai.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox_TenTrangThai.Controls.Add(this.comboBox_Status);
            this.groupBox_TenTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TenTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_TenTrangThai.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenTrangThai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TenTrangThai.Location = new System.Drawing.Point(0, 36);
            this.groupBox_TenTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_TenTrangThai.Name = "groupBox_TenTrangThai";
            this.groupBox_TenTrangThai.Padding = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.groupBox_TenTrangThai.Size = new System.Drawing.Size(670, 62);
            this.groupBox_TenTrangThai.TabIndex = 0;
            this.groupBox_TenTrangThai.TabStop = false;
            this.groupBox_TenTrangThai.Text = "Trạng thái";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.BackColor = System.Drawing.Color.Azure;
            this.comboBox_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Status.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Status.ForeColor = System.Drawing.Color.Goldenrod;
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Đã ứng tuyển",
            "NTD đã xem hồ sơ",
            "Hồ sơ phù hợp"});
            this.comboBox_Status.Location = new System.Drawing.Point(22, 26);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(626, 32);
            this.comboBox_Status.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.Color.Goldenrod;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(670, 36);
            this.label_Ten.TabIndex = 0;
            this.label_Ten.Text = "CÔNG VIỆC ĐÃ ỨNG TUYỂN";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 734);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FDanhSachDaUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(676, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachDaUT";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Danh sách việc làm đã ứng tuyển";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachDaUT_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.panelLeft.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.groupBox_TenTrangThai.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.GroupBox groupBox_TenTrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private FinalProject.UC.UCPagination ucPagination;
    }
}