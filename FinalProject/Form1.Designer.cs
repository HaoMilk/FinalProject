namespace FinalProject
{
    partial class Form_DangNhap
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
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.groupBox_PhanQuyen = new System.Windows.Forms.GroupBox();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.radioButton_NhaTuyenDung = new System.Windows.Forms.RadioButton();
            this.radioButton__UngVien = new System.Windows.Forms.RadioButton();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.groupBox_Pass = new System.Windows.Forms.GroupBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.button_DangNhap = new FinalProject.UC.UCCustomButton();
            this.groupBox_PhanQuyen.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.groupBox_Pass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(10, 26);
            this.textBox_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(280, 23);
            this.textBox_TenDangNhap.TabIndex = 0;
            // 
            // groupBox_PhanQuyen
            // 
            this.groupBox_PhanQuyen.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton_Admin);
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton_NhaTuyenDung);
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton__UngVien);
            this.groupBox_PhanQuyen.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhanQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_PhanQuyen.Location = new System.Drawing.Point(101, 221);
            this.groupBox_PhanQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_PhanQuyen.Name = "groupBox_PhanQuyen";
            this.groupBox_PhanQuyen.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_PhanQuyen.Size = new System.Drawing.Size(300, 58);
            this.groupBox_PhanQuyen.TabIndex = 2;
            this.groupBox_PhanQuyen.TabStop = false;
            this.groupBox_PhanQuyen.Text = "Phân quyền:";
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_Admin.Location = new System.Drawing.Point(224, 26);
            this.radioButton_Admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(66, 22);
            this.radioButton_Admin.TabIndex = 2;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_NhaTuyenDung
            // 
            this.radioButton_NhaTuyenDung.AutoSize = true;
            this.radioButton_NhaTuyenDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_NhaTuyenDung.Location = new System.Drawing.Point(90, 26);
            this.radioButton_NhaTuyenDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_NhaTuyenDung.Name = "radioButton_NhaTuyenDung";
            this.radioButton_NhaTuyenDung.Size = new System.Drawing.Size(121, 22);
            this.radioButton_NhaTuyenDung.TabIndex = 1;
            this.radioButton_NhaTuyenDung.TabStop = true;
            this.radioButton_NhaTuyenDung.Text = "Nhà tuyển dụng";
            this.radioButton_NhaTuyenDung.UseVisualStyleBackColor = true;
            // 
            // radioButton__UngVien
            // 
            this.radioButton__UngVien.AutoSize = true;
            this.radioButton__UngVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton__UngVien.Location = new System.Drawing.Point(10, 26);
            this.radioButton__UngVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton__UngVien.Name = "radioButton__UngVien";
            this.radioButton__UngVien.Size = new System.Drawing.Size(80, 22);
            this.radioButton__UngVien.TabIndex = 0;
            this.radioButton__UngVien.TabStop = true;
            this.radioButton__UngVien.Text = "Ứng viên";
            this.radioButton__UngVien.UseVisualStyleBackColor = true;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Name.Controls.Add(this.textBox_TenDangNhap);
            this.groupBox_Name.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Name.Location = new System.Drawing.Point(101, 64);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_Name.Size = new System.Drawing.Size(300, 61);
            this.groupBox_Name.TabIndex = 3;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Tên đăng nhập";
            // 
            // groupBox_Pass
            // 
            this.groupBox_Pass.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Pass.Controls.Add(this.textBox_MatKhau);
            this.groupBox_Pass.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Pass.Location = new System.Drawing.Point(101, 145);
            this.groupBox_Pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Pass.Name = "groupBox_Pass";
            this.groupBox_Pass.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_Pass.Size = new System.Drawing.Size(300, 63);
            this.groupBox_Pass.TabIndex = 4;
            this.groupBox_Pass.TabStop = false;
            this.groupBox_Pass.Text = "Mật khẩu";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MatKhau.Location = new System.Drawing.Point(10, 26);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(280, 23);
            this.textBox_MatKhau.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.Color.Transparent;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(490, 62);
            this.label_Ten.TabIndex = 5;
            this.label_Ten.Text = "ĐĂNG NHẬP";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.linkLabel_DangKy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(145, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 34);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chưa có tài khoản ? ";
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_DangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(148, 0);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Padding = new System.Windows.Forms.Padding(5);
            this.linkLabel_DangKy.Size = new System.Drawing.Size(70, 27);
            this.linkLabel_DangKy.TabIndex = 1;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.AutoSize = true;
            this.button_DangNhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_DangNhap.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.button_DangNhap.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_DangNhap.BorderRadius = 0;
            this.button_DangNhap.BorderSize = 0;
            this.button_DangNhap.FlatAppearance.BorderSize = 0;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.button_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap.Image = global::FinalProject.Properties.Resources._24_sign_in;
            this.button_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DangNhap.Location = new System.Drawing.Point(145, 307);
            this.button_DangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Padding = new System.Windows.Forms.Padding(5);
            this.button_DangNhap.Size = new System.Drawing.Size(218, 43);
            this.button_DangNhap.TabIndex = 6;
            this.button_DangNhap.Text = "ĐĂNG NHẬP";
            this.button_DangNhap.TextColor = System.Drawing.Color.White;
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background_neon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.groupBox_Pass);
            this.Controls.Add(this.groupBox_Name);
            this.Controls.Add(this.groupBox_PhanQuyen);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.groupBox_PhanQuyen.ResumeLayout(false);
            this.groupBox_PhanQuyen.PerformLayout();
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            this.groupBox_Pass.ResumeLayout(false);
            this.groupBox_Pass.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.GroupBox groupBox_PhanQuyen;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.RadioButton radioButton_NhaTuyenDung;
        private System.Windows.Forms.RadioButton radioButton__UngVien;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.GroupBox groupBox_Pass;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label_Ten;
        private UC.UCCustomButton button_DangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
    }
}

