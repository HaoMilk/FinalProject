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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.groupBox_TenTrangThai = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.ucUserSetting1 = new FinalProject.Candidate.UC.UCUserSetting();
            this.panelLeft.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.groupBox_TenTrangThai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.flowLayoutPanel_Data);
            this.panelLeft.Controls.Add(this.panelFilter);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 2);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(944, 754);
            this.panelLeft.TabIndex = 0;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.AutoScroll = true;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(0, 93);
            this.flowLayoutPanel_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(944, 661);
            this.flowLayoutPanel_Data.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelFilter.Controls.Add(this.groupBox_TenTrangThai);
            this.panelFilter.Controls.Add(this.label_Ten);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(944, 93);
            this.panelFilter.TabIndex = 0;
            // 
            // groupBox_TenTrangThai
            // 
            this.groupBox_TenTrangThai.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_TenTrangThai.Controls.Add(this.comboBox1);
            this.groupBox_TenTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TenTrangThai.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenTrangThai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TenTrangThai.Location = new System.Drawing.Point(0, 38);
            this.groupBox_TenTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_TenTrangThai.Name = "groupBox_TenTrangThai";
            this.groupBox_TenTrangThai.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_TenTrangThai.Size = new System.Drawing.Size(944, 55);
            this.groupBox_TenTrangThai.TabIndex = 0;
            this.groupBox_TenTrangThai.TabStop = false;
            this.groupBox_TenTrangThai.Text = "Trạng thái";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đã ứng tuyển",
            "NTD đã xem hồ sơ",
            "Hồ sơ phù hợp"});
            this.comboBox1.Location = new System.Drawing.Point(3, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(938, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(944, 38);
            this.label_Ten.TabIndex = 0;
            this.label_Ten.Text = "Công việc đã ứng tuyển";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panelRight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1358, 758);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.ucUserSetting1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(953, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(402, 752);
            this.panelRight.TabIndex = 1;
            // 
            // ucUserSetting1
            // 
            this.ucUserSetting1.AutoSize = true;
            this.ucUserSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserSetting1.Location = new System.Drawing.Point(0, 0);
            this.ucUserSetting1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucUserSetting1.Name = "ucUserSetting1";
            this.ucUserSetting1.Size = new System.Drawing.Size(402, 752);
            this.ucUserSetting1.TabIndex = 0;
            // 
            // FDanhSachDaUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 758);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachDaUT";
            this.Text = "FDanhSachDauUT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachDaUT_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.groupBox_TenTrangThai.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.GroupBox groupBox_TenTrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelRight;
        private UC.UCUserSetting ucUserSetting1;
    }
}