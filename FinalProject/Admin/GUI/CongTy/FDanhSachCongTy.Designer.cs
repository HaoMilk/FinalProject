﻿namespace FinalProject.Admin
{
    partial class FDanhSachCongTy
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
            this.btnThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDSCT = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.cbKinhNghiem = new System.Windows.Forms.ComboBox();
            this.cbMucLuong = new System.Windows.Forms.ComboBox();
            this.cbDiaDiem = new System.Windows.Forms.ComboBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_DSCongTy = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox_Avatar = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCT)).BeginInit();
            this.panel3.SuspendLayout();
            this.grpBoxTimKiem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btnThem.Image = global::FinalProject.Properties.Resources.icons8_add_48;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(0, 172);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(241, 86);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDSCT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(241, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1158, 544);
            this.panel4.TabIndex = 7;
            // 
            // dgvDSCT
            // 
            this.dgvDSCT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.dgvDSCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCT.Location = new System.Drawing.Point(0, 0);
            this.dgvDSCT.Name = "dgvDSCT";
            this.dgvDSCT.RowHeadersWidth = 51;
            this.dgvDSCT.RowTemplate.Height = 24;
            this.dgvDSCT.Size = new System.Drawing.Size(1158, 544);
            this.dgvDSCT.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpBoxTimKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(241, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 113);
            this.panel3.TabIndex = 6;
            // 
            // grpBoxTimKiem
            // 
            this.grpBoxTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.grpBoxTimKiem.Controls.Add(this.cbKinhNghiem);
            this.grpBoxTimKiem.Controls.Add(this.cbMucLuong);
            this.grpBoxTimKiem.Controls.Add(this.cbDiaDiem);
            this.grpBoxTimKiem.Controls.Add(this.cbNganh);
            this.grpBoxTimKiem.Controls.Add(this.txtTimKiem);
            this.grpBoxTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxTimKiem.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpBoxTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grpBoxTimKiem.Name = "grpBoxTimKiem";
            this.grpBoxTimKiem.Size = new System.Drawing.Size(1158, 113);
            this.grpBoxTimKiem.TabIndex = 0;
            this.grpBoxTimKiem.TabStop = false;
            this.grpBoxTimKiem.Text = "TÌm kiếm";
            // 
            // cbKinhNghiem
            // 
            this.cbKinhNghiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.cbKinhNghiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbKinhNghiem.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKinhNghiem.ForeColor = System.Drawing.SystemColors.Window;
            this.cbKinhNghiem.FormattingEnabled = true;
            this.cbKinhNghiem.Location = new System.Drawing.Point(867, 68);
            this.cbKinhNghiem.Name = "cbKinhNghiem";
            this.cbKinhNghiem.Size = new System.Drawing.Size(288, 36);
            this.cbKinhNghiem.TabIndex = 4;
            this.cbKinhNghiem.Text = "Kinh nghiệm";
            // 
            // cbMucLuong
            // 
            this.cbMucLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.cbMucLuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbMucLuong.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMucLuong.ForeColor = System.Drawing.SystemColors.Window;
            this.cbMucLuong.FormattingEnabled = true;
            this.cbMucLuong.Location = new System.Drawing.Point(579, 68);
            this.cbMucLuong.Name = "cbMucLuong";
            this.cbMucLuong.Size = new System.Drawing.Size(288, 36);
            this.cbMucLuong.TabIndex = 3;
            this.cbMucLuong.Text = "Mức lương";
            // 
            // cbDiaDiem
            // 
            this.cbDiaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.cbDiaDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDiaDiem.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDiaDiem.ForeColor = System.Drawing.SystemColors.Window;
            this.cbDiaDiem.FormattingEnabled = true;
            this.cbDiaDiem.Location = new System.Drawing.Point(291, 68);
            this.cbDiaDiem.Name = "cbDiaDiem";
            this.cbDiaDiem.Size = new System.Drawing.Size(288, 36);
            this.cbDiaDiem.TabIndex = 2;
            this.cbDiaDiem.Text = "Địa điểm";
            // 
            // cbNganh
            // 
            this.cbNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.cbNganh.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbNganh.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNganh.ForeColor = System.Drawing.Color.White;
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(3, 68);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(288, 36);
            this.cbNganh.TabIndex = 1;
            this.cbNganh.Text = "Ngành";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiem.Location = new System.Drawing.Point(3, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1152, 36);
            this.txtTimKiem.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_DSCongTy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 69);
            this.panel2.TabIndex = 5;
            // 
            // label_DSCongTy
            // 
            this.label_DSCongTy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.label_DSCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DSCongTy.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DSCongTy.ForeColor = System.Drawing.SystemColors.Info;
            this.label_DSCongTy.Location = new System.Drawing.Point(0, 0);
            this.label_DSCongTy.Name = "label_DSCongTy";
            this.label_DSCongTy.Size = new System.Drawing.Size(1158, 69);
            this.label_DSCongTy.TabIndex = 9;
            this.label_DSCongTy.Text = "DANH SÁCH CÔNG TY";
            this.label_DSCongTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_DSCongTy.UseCompatibleTextRendering = true;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.pnlControl.Controls.Add(this.btnXoa);
            this.pnlControl.Controls.Add(this.btnSua);
            this.pnlControl.Controls.Add(this.btnThem);
            this.pnlControl.Controls.Add(this.panel5);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(241, 726);
            this.pnlControl.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoa.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btnXoa.Image = global::FinalProject.Properties.Resources.icons8_delete_48;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(0, 344);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(241, 86);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSua.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btnSua.Image = global::FinalProject.Properties.Resources.icons8_edit_48;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(0, 258);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(241, 86);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox_Avatar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 172);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox_Avatar
            // 
            this.pictureBox_Avatar.BackColor = System.Drawing.Color.White;
            this.pictureBox_Avatar.BackgroundImage = global::FinalProject.Properties.Resources.companyicon;
            this.pictureBox_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Avatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Avatar.Margin = new System.Windows.Forms.Padding(34, 32, 34, 32);
            this.pictureBox_Avatar.Name = "pictureBox_Avatar";
            this.pictureBox_Avatar.Padding = new System.Windows.Forms.Padding(34, 32, 34, 32);
            this.pictureBox_Avatar.Size = new System.Drawing.Size(241, 172);
            this.pictureBox_Avatar.TabIndex = 1;
            this.pictureBox_Avatar.TabStop = false;
            // 
            // FDanhSachCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 726);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDanhSachCongTy";
            this.Text = "FDanhSachCongTy";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCT)).EndInit();
            this.panel3.ResumeLayout(false);
            this.grpBoxTimKiem.ResumeLayout(false);
            this.grpBoxTimKiem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UCDanhSach ucDanhSach1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvDSCT;
        private System.Windows.Forms.GroupBox grpBoxTimKiem;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbKinhNghiem;
        private System.Windows.Forms.ComboBox cbMucLuong;
        private System.Windows.Forms.ComboBox cbDiaDiem;
        private System.Windows.Forms.PictureBox pictureBox_Avatar;
        private System.Windows.Forms.Label label_DSCongTy;
    }
}