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
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label_Ten = new System.Windows.Forms.Label();
            this.groupBox_TenTrangThai = new System.Windows.Forms.GroupBox();
            this.rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.ucUserSetting1 = new FinalProject.Candidate.UC.UCUserSetting();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox_TenTrangThai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 100);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label_Ten);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_TenTrangThai);
            this.splitContainer2.Size = new System.Drawing.Size(785, 100);
            this.splitContainer2.SplitterDistance = 499;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Ten.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(499, 100);
            this.label_Ten.TabIndex = 0;
            this.label_Ten.Text = "Công việc đã ứng tuyển";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_TenTrangThai
            // 
            this.groupBox_TenTrangThai.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_TenTrangThai.Controls.Add(this.rjComboBox1);
            this.groupBox_TenTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TenTrangThai.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenTrangThai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TenTrangThai.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TenTrangThai.Name = "groupBox_TenTrangThai";
            this.groupBox_TenTrangThai.Size = new System.Drawing.Size(282, 100);
            this.groupBox_TenTrangThai.TabIndex = 0;
            this.groupBox_TenTrangThai.TabStop = false;
            this.groupBox_TenTrangThai.Text = "Trạng thái";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.Items.AddRange(new object[] {
            "Đã ứng tuyển",
            "NTD đã xem hồ sơ",
            "Hồ sơ phù hợp"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(3, 26);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(276, 71);
            this.rjComboBox1.TabIndex = 1;
            this.rjComboBox1.Texts = "";
            this.rjComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // ucUserSetting1
            // 
            this.ucUserSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserSetting1.Location = new System.Drawing.Point(794, 3);
            this.ucUserSetting1.Name = "ucUserSetting1";
            this.ucUserSetting1.Size = new System.Drawing.Size(334, 586);
            this.ucUserSetting1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucUserSetting1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1131, 548);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FDanhSachDauUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FDanhSachDauUT";
            this.Text = "FDanhSachDauUT";
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox_TenTrangThai.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.GroupBox groupBox_TenTrangThai;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBox1;
        private UC.UCUserSetting ucUserSetting1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}