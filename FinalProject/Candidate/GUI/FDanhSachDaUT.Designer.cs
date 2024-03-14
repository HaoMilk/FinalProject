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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Ten = new System.Windows.Forms.Label();
            this.groupBox_TenTrangThai = new System.Windows.Forms.GroupBox();
            this.rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.ucJobCard1 = new FinalProject.UC.UCJobCard();
            this.ucJobCard2 = new FinalProject.UC.UCJobCard();
            this.ucUserSetting1 = new FinalProject.Candidate.UC.UCUserSetting();
            this.panel2.SuspendLayout();
            this.groupBox_TenTrangThai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel_Data);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 586);
            this.panel2.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(672, 47);
            this.label_Ten.TabIndex = 0;
            this.label_Ten.Text = "Công việc đã ứng tuyển";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_TenTrangThai
            // 
            this.groupBox_TenTrangThai.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_TenTrangThai.Controls.Add(this.rjComboBox1);
            this.groupBox_TenTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TenTrangThai.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TenTrangThai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TenTrangThai.Location = new System.Drawing.Point(0, 47);
            this.groupBox_TenTrangThai.Name = "groupBox_TenTrangThai";
            this.groupBox_TenTrangThai.Size = new System.Drawing.Size(672, 69);
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
            this.rjComboBox1.Size = new System.Drawing.Size(666, 40);
            this.rjComboBox1.TabIndex = 1;
            this.rjComboBox1.Texts = "";
            this.rjComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucUserSetting1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1131, 548);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.groupBox_TenTrangThai);
            this.panel3.Controls.Add(this.label_Ten);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 116);
            this.panel3.TabIndex = 0;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.Controls.Add(this.ucJobCard1);
            this.flowLayoutPanel_Data.Controls.Add(this.ucJobCard2);
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(672, 470);
            this.flowLayoutPanel_Data.TabIndex = 1;
            // 
            // ucJobCard1
            // 
            this.ucJobCard1.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucJobCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard1.BackgroundImage")));
            this.ucJobCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucJobCard1.BgImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard1.BgImage")));
            this.ucJobCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucJobCard1.ButtonMenuBackground = System.Drawing.Color.LightCyan;
            this.ucJobCard1.ButtonMenuImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard1.ButtonMenuImage")));
            this.ucJobCard1.ButtonViewBackground = System.Drawing.Color.Cornsilk;
            this.ucJobCard1.ButtonViewImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard1.ButtonViewImage")));
            this.ucJobCard1.CvName = null;
            this.ucJobCard1.CvUpdatedTime = new System.DateTime(((long)(0)));
            this.ucJobCard1.Id = 0;
            this.ucJobCard1.LabelCvNameTextColor = System.Drawing.SystemColors.Highlight;
            this.ucJobCard1.LabelUpdatedTimeTextColor = System.Drawing.Color.Navy;
            this.ucJobCard1.Location = new System.Drawing.Point(11, 12);
            this.ucJobCard1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ucJobCard1.Name = "ucJobCard1";
            this.ucJobCard1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ucJobCard1.Size = new System.Drawing.Size(335, 310);
            this.ucJobCard1.TabIndex = 0;
            // 
            // ucJobCard2
            // 
            this.ucJobCard2.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucJobCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard2.BackgroundImage")));
            this.ucJobCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucJobCard2.BgImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard2.BgImage")));
            this.ucJobCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucJobCard2.ButtonMenuBackground = System.Drawing.Color.LightCyan;
            this.ucJobCard2.ButtonMenuImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard2.ButtonMenuImage")));
            this.ucJobCard2.ButtonViewBackground = System.Drawing.Color.Cornsilk;
            this.ucJobCard2.ButtonViewImage = ((System.Drawing.Image)(resources.GetObject("ucJobCard2.ButtonViewImage")));
            this.ucJobCard2.CvName = null;
            this.ucJobCard2.CvUpdatedTime = new System.DateTime(((long)(0)));
            this.ucJobCard2.Id = 0;
            this.ucJobCard2.LabelCvNameTextColor = System.Drawing.SystemColors.Highlight;
            this.ucJobCard2.LabelUpdatedTimeTextColor = System.Drawing.Color.Navy;
            this.ucJobCard2.Location = new System.Drawing.Point(11, 346);
            this.ucJobCard2.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ucJobCard2.Name = "ucJobCard2";
            this.ucJobCard2.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ucJobCard2.Size = new System.Drawing.Size(335, 310);
            this.ucJobCard2.TabIndex = 1;
            // 
            // ucUserSetting1
            // 
            this.ucUserSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserSetting1.Location = new System.Drawing.Point(681, 3);
            this.ucUserSetting1.Name = "ucUserSetting1";
            this.ucUserSetting1.Size = new System.Drawing.Size(447, 586);
            this.ucUserSetting1.TabIndex = 0;
            // 
            // FDanhSachDaUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FDanhSachDaUT";
            this.Text = "FDanhSachDauUT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.groupBox_TenTrangThai.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel_Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.GroupBox groupBox_TenTrangThai;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBox1;
        private UC.UCUserSetting ucUserSetting1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
        private FinalProject.UC.UCJobCard ucJobCard1;
        private FinalProject.UC.UCJobCard ucJobCard2;
    }
}