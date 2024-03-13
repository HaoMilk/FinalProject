namespace FinalProject.Candidate.GUI
{
    partial class FDanhSachCty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_TimCongTy = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Contro_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView_DanhSachCty = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_TimCongTy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 135);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Contro_TimKiem);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_TimCongTy);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 135);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÔNG TY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.business_people_partnership_support_team_urban_scene_concept;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 135);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_TimCongTy
            // 
            this.groupBox_TimCongTy.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_TimCongTy.Controls.Add(this.textBox1);
            this.groupBox_TimCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TimCongTy.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TimCongTy.Location = new System.Drawing.Point(0, 58);
            this.groupBox_TimCongTy.Name = "groupBox_TimCongTy";
            this.groupBox_TimCongTy.Size = new System.Drawing.Size(945, 77);
            this.groupBox_TimCongTy.TabIndex = 1;
            this.groupBox_TimCongTy.TabStop = false;
            this.groupBox_TimCongTy.Text = "Tên công ty";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(939, 30);
            this.textBox1.TabIndex = 0;
            // 
            // Contro_TimKiem
            // 
            this.Contro_TimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.Contro_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.Contro_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contro_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Contro_TimKiem.Location = new System.Drawing.Point(772, 58);
            this.Contro_TimKiem.Name = "Contro_TimKiem";
            this.Contro_TimKiem.Size = new System.Drawing.Size(173, 77);
            this.Contro_TimKiem.TabIndex = 2;
            this.Contro_TimKiem.Text = "Tìm kiếm";
            this.Contro_TimKiem.UseVisualStyleBackColor = false;
            // 
            // dataGridView_DanhSachCty
            // 
            this.dataGridView_DanhSachCty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachCty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DanhSachCty.Location = new System.Drawing.Point(0, 135);
            this.dataGridView_DanhSachCty.Name = "dataGridView_DanhSachCty";
            this.dataGridView_DanhSachCty.RowHeadersWidth = 62;
            this.dataGridView_DanhSachCty.RowTemplate.Height = 28;
            this.dataGridView_DanhSachCty.Size = new System.Drawing.Size(1240, 443);
            this.dataGridView_DanhSachCty.TabIndex = 1;
            // 
            // FDanhSachCty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 578);
            this.Controls.Add(this.dataGridView_DanhSachCty);
            this.Controls.Add(this.panel1);
            this.Name = "FDanhSachCty";
            this.Text = "FDanhSachCty";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_TimCongTy.ResumeLayout(false);
            this.groupBox_TimCongTy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_TimCongTy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Contro_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachCty;
    }
}