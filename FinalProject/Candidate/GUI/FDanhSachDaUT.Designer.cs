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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.groupBox_TenTrangThai = new System.Windows.Forms.GroupBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.ucUserSetting1 = new FinalProject.Candidate.UC.UCUserSetting();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.groupBox_TenTrangThai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel_Top.SuspendLayout();
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
            this.panelLeft.Size = new System.Drawing.Size(916, 754);
            this.panelLeft.TabIndex = 0;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.AutoScroll = true;
            this.flowLayoutPanel_Data.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(0, 104);
            this.flowLayoutPanel_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(916, 650);
            this.flowLayoutPanel_Data.TabIndex = 1;
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
            this.panelFilter.Size = new System.Drawing.Size(916, 104);
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
            this.groupBox_TenTrangThai.Location = new System.Drawing.Point(0, 38);
            this.groupBox_TenTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_TenTrangThai.Name = "groupBox_TenTrangThai";
            this.groupBox_TenTrangThai.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.groupBox_TenTrangThai.Size = new System.Drawing.Size(916, 66);
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
            this.comboBox_Status.Location = new System.Drawing.Point(25, 26);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(866, 32);
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
            this.label_Ten.Size = new System.Drawing.Size(916, 38);
            this.label_Ten.TabIndex = 0;
            this.label_Ten.Text = "CÔNG VIỆC ĐÃ ỨNG TUYỂN";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1318, 688);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.ucUserSetting1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(925, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(390, 752);
            this.panelRight.TabIndex = 1;
            // 
            // ucUserSetting1
            // 
            this.ucUserSetting1.AutoSize = true;
            this.ucUserSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserSetting1.Location = new System.Drawing.Point(0, 0);
            this.ucUserSetting1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucUserSetting1.Name = "ucUserSetting1";
            this.ucUserSetting1.Size = new System.Drawing.Size(390, 752);
            this.ucUserSetting1.TabIndex = 0;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(20, 10);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.panel_Top.Size = new System.Drawing.Size(1318, 40);
            this.panel_Top.TabIndex = 6;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(1274, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(44, 25);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // FDanhSachDaUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1358, 758);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel_Top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachDaUT";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách việc làm đã ứng tuyển";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachDaUT_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.groupBox_TenTrangThai.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel_Top.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelRight;
        private UC.UCUserSetting ucUserSetting1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Close;
    }
}