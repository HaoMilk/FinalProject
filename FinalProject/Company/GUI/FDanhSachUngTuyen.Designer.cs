namespace FinalProject.Company.GUI
{
    partial class FDanhSachUngTuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_DanhSachCV = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách CV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 83);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Name.Controls.Add(this.comboBox_TrangThai);
            this.groupBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Name.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Name.Location = new System.Drawing.Point(11, 11);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(11);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(11);
            this.groupBox_Name.Size = new System.Drawing.Size(721, 61);
            this.groupBox_Name.TabIndex = 15;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Tìm kiếm";
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.BackColor = System.Drawing.Color.CadetBlue;
            this.comboBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Items.AddRange(new object[] {
            "Hồ sơ chưa duyệt",
            "Hồ sơ đã duyệt",
            "Hồ sơ bị loại",
            "Hồ sơ đã tuyển dụng",
            "Hủy",
            "Tất cả"});
            this.comboBox_TrangThai.Location = new System.Drawing.Point(11, 28);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(308, 23);
            this.comboBox_TrangThai.TabIndex = 0;
            this.comboBox_TrangThai.SelectedValueChanged += new System.EventHandler(this.comboBox_TrangThai_SelectedValueChanged);
            // 
            // flowLayoutPanel_DanhSachCV
            // 
            this.flowLayoutPanel_DanhSachCV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.flowLayoutPanel_DanhSachCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_DanhSachCV.Location = new System.Drawing.Point(27, 190);
            this.flowLayoutPanel_DanhSachCV.Name = "flowLayoutPanel_DanhSachCV";
            this.flowLayoutPanel_DanhSachCV.Size = new System.Drawing.Size(743, 426);
            this.flowLayoutPanel_DanhSachCV.TabIndex = 18;
            // 
            // FDanhSachUngTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 645);
            this.Controls.Add(this.flowLayoutPanel_DanhSachCV);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FDanhSachUngTuyen";
            this.Text = "FDanhSachUngTuyen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachUngTuyen_Load);
            this.Shown += new System.EventHandler(this.FDanhSachUngTuyen_Shown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel_DanhSachCV, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.ComboBox comboBox_TrangThai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_DanhSachCV;
    }
}