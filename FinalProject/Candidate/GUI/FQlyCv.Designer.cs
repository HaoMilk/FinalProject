namespace FinalProject.Candidate.GUI
{
    partial class FQlyCv
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox_Ghichu = new System.Windows.Forms.GroupBox();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.groupBox_NameFile = new System.Windows.Forms.GroupBox();
            this.textBox_NameFile = new System.Windows.Forms.TextBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView_Cv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Ghichu.SuspendLayout();
            this.groupBox_NameFile.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Sua);
            this.splitContainer1.Panel1.Controls.Add(this.button_Xoa);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label_Name);
            this.splitContainer1.Panel1.Controls.Add(this.button_Them);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_NameFile);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Ghichu);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_Cv);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1329, 605);
            this.splitContainer1.SplitterDistance = 666;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(117, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(415, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên CV";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(10, 33);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(395, 30);
            this.textBox_Name.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.comboBox_TrangThai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(117, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(415, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Location = new System.Drawing.Point(10, 33);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(395, 33);
            this.comboBox_TrangThai.TabIndex = 3;
            // 
            // groupBox_Ghichu
            // 
            this.groupBox_Ghichu.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Ghichu.Controls.Add(this.textBox_GhiChu);
            this.groupBox_Ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Ghichu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Ghichu.Location = new System.Drawing.Point(117, 303);
            this.groupBox_Ghichu.Name = "groupBox_Ghichu";
            this.groupBox_Ghichu.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_Ghichu.Size = new System.Drawing.Size(415, 75);
            this.groupBox_Ghichu.TabIndex = 3;
            this.groupBox_Ghichu.TabStop = false;
            this.groupBox_Ghichu.Text = "Ghi chú";
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_GhiChu.Location = new System.Drawing.Point(10, 33);
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(395, 30);
            this.textBox_GhiChu.TabIndex = 1;
            // 
            // groupBox_NameFile
            // 
            this.groupBox_NameFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_NameFile.Controls.Add(this.textBox_NameFile);
            this.groupBox_NameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NameFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_NameFile.Location = new System.Drawing.Point(117, 384);
            this.groupBox_NameFile.Name = "groupBox_NameFile";
            this.groupBox_NameFile.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_NameFile.Size = new System.Drawing.Size(415, 75);
            this.groupBox_NameFile.TabIndex = 4;
            this.groupBox_NameFile.TabStop = false;
            this.groupBox_NameFile.Text = "Tên File";
            // 
            // textBox_NameFile
            // 
            this.textBox_NameFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_NameFile.Location = new System.Drawing.Point(10, 33);
            this.textBox_NameFile.Name = "textBox_NameFile";
            this.textBox_NameFile.Size = new System.Drawing.Size(395, 30);
            this.textBox_NameFile.TabIndex = 1;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Them.BackgroundImage = global::FinalProject.Properties.Resources._01_logobachkhoatoi;
            this.button_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(202, 494);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(115, 85);
            this.button_Them.TabIndex = 6;
            this.button_Them.Text = "Thêm";
            this.button_Them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_ChonFile_Click);
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(0, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(666, 43);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "QUẢN LÝ CV";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = global::FinalProject.Properties.Resources._01_logobachkhoatoi;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chọn File";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Xoa.BackgroundImage = global::FinalProject.Properties.Resources._01_logobachkhoatoi;
            this.button_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(340, 494);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(115, 85);
            this.button_Xoa.TabIndex = 9;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Sua.BackgroundImage = global::FinalProject.Properties.Resources._01_logobachkhoatoi;
            this.button_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(481, 494);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(115, 85);
            this.button_Sua.TabIndex = 10;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Sua.UseVisualStyleBackColor = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(0, 0);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(659, 35);
            this.textBox_Search.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Controls.Add(this.textBox_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 28);
            this.panel1.TabIndex = 1;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TimKiem.Location = new System.Drawing.Point(527, 0);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(132, 28);
            this.button_TimKiem.TabIndex = 1;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Cv
            // 
            this.dataGridView_Cv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Cv.Location = new System.Drawing.Point(0, 28);
            this.dataGridView_Cv.Name = "dataGridView_Cv";
            this.dataGridView_Cv.RowHeadersWidth = 62;
            this.dataGridView_Cv.RowTemplate.Height = 28;
            this.dataGridView_Cv.Size = new System.Drawing.Size(659, 577);
            this.dataGridView_Cv.TabIndex = 2;
            this.dataGridView_Cv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Cv_CellClick);
            // 
            // FQlyCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 605);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FQlyCv";
            this.Text = "FQlyCv";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Ghichu.ResumeLayout(false);
            this.groupBox_Ghichu.PerformLayout();
            this.groupBox_NameFile.ResumeLayout(false);
            this.groupBox_NameFile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_TrangThai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.GroupBox groupBox_NameFile;
        private System.Windows.Forms.TextBox textBox_NameFile;
        private System.Windows.Forms.GroupBox groupBox_Ghichu;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_Cv;
    }
}