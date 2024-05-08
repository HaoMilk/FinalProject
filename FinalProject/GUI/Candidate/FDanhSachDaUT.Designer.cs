namespace FinalProject.GUI.Candidate
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
            this.ucComboBox_TrangThai = new FinalProject.UC.UCComboBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
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
            this.panelLeft.Controls.Add(this.panelFilter);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(4, 3);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(958, 650);
            this.panelLeft.TabIndex = 0;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.AutoScroll = true;
            this.flowLayoutPanel_Data.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(0, 137);
            this.flowLayoutPanel_Data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(958, 513);
            this.flowLayoutPanel_Data.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Goldenrod;
            this.panelFilter.Controls.Add(this.groupBox_TenTrangThai);
            this.panelFilter.Controls.Add(this.label_Ten);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(958, 137);
            this.panelFilter.TabIndex = 0;
            // 
            // groupBox_TenTrangThai
            // 
            this.groupBox_TenTrangThai.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox_TenTrangThai.Controls.Add(this.ucComboBox_TrangThai);
            this.groupBox_TenTrangThai.Controls.Add(this.button_TimKiem);
            this.groupBox_TenTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TenTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_TenTrangThai.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenTrangThai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TenTrangThai.Location = new System.Drawing.Point(0, 51);
            this.groupBox_TenTrangThai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_TenTrangThai.Name = "groupBox_TenTrangThai";
            this.groupBox_TenTrangThai.Padding = new System.Windows.Forms.Padding(32, 7, 32, 7);
            this.groupBox_TenTrangThai.Size = new System.Drawing.Size(958, 86);
            this.groupBox_TenTrangThai.TabIndex = 0;
            this.groupBox_TenTrangThai.TabStop = false;
            this.groupBox_TenTrangThai.Text = "Trạng thái";
            // 
            // ucComboBox_TrangThai
            // 
            this.ucComboBox_TrangThai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ucComboBox_TrangThai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ucComboBox_TrangThai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucComboBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBox_TrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_TrangThai.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_TrangThai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucComboBox_TrangThai.FormattingEnabled = true;
            this.ucComboBox_TrangThai.ItemHeight = 45;
            this.ucComboBox_TrangThai.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_TrangThai.Location = new System.Drawing.Point(32, 28);
            this.ucComboBox_TrangThai.Name = "ucComboBox_TrangThai";
            this.ucComboBox_TrangThai.SelectedItem = null;
            this.ucComboBox_TrangThai.Size = new System.Drawing.Size(798, 51);
            this.ucComboBox_TrangThai.TabIndex = 5;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.Goldenrod;
            this.button_TimKiem.BackgroundImage = global::FinalProject.Properties.Resources.icons8_search_32;
            this.button_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button_TimKiem.FlatAppearance.BorderSize = 0;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_TimKiem.Location = new System.Drawing.Point(830, 28);
            this.button_TimKiem.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(96, 51);
            this.button_TimKiem.TabIndex = 4;
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.Color.Goldenrod;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(958, 51);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 903F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 656);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FDanhSachDaUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(966, 706);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Button button_TimKiem;
        private FinalProject.UC.UCComboBox ucComboBox_TrangThai;
    }
}