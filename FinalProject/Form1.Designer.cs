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
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
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
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(15, 38);
            this.textBox_TenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(420, 30);
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
            this.groupBox_PhanQuyen.Location = new System.Drawing.Point(152, 340);
            this.groupBox_PhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_PhanQuyen.Name = "groupBox_PhanQuyen";
            this.groupBox_PhanQuyen.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox_PhanQuyen.Size = new System.Drawing.Size(450, 89);
            this.groupBox_PhanQuyen.TabIndex = 2;
            this.groupBox_PhanQuyen.TabStop = false;
            this.groupBox_PhanQuyen.Text = "Phân quyền:";
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_Admin.Location = new System.Drawing.Point(344, 38);
            this.radioButton_Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(91, 36);
            this.radioButton_Admin.TabIndex = 2;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_NhaTuyenDung
            // 
            this.radioButton_NhaTuyenDung.AutoSize = true;
            this.radioButton_NhaTuyenDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_NhaTuyenDung.Location = new System.Drawing.Point(126, 38);
            this.radioButton_NhaTuyenDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_NhaTuyenDung.Name = "radioButton_NhaTuyenDung";
            this.radioButton_NhaTuyenDung.Size = new System.Drawing.Size(167, 36);
            this.radioButton_NhaTuyenDung.TabIndex = 1;
            this.radioButton_NhaTuyenDung.TabStop = true;
            this.radioButton_NhaTuyenDung.Text = "Nhà tuyển dụng";
            this.radioButton_NhaTuyenDung.UseVisualStyleBackColor = true;
            // 
            // radioButton__UngVien
            // 
            this.radioButton__UngVien.AutoSize = true;
            this.radioButton__UngVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton__UngVien.Location = new System.Drawing.Point(15, 38);
            this.radioButton__UngVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton__UngVien.Name = "radioButton__UngVien";
            this.radioButton__UngVien.Size = new System.Drawing.Size(111, 36);
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
            this.groupBox_Name.Location = new System.Drawing.Point(152, 99);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox_Name.Size = new System.Drawing.Size(450, 94);
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
            this.groupBox_Pass.Location = new System.Drawing.Point(152, 222);
            this.groupBox_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Pass.Name = "groupBox_Pass";
            this.groupBox_Pass.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox_Pass.Size = new System.Drawing.Size(450, 98);
            this.groupBox_Pass.TabIndex = 4;
            this.groupBox_Pass.TabStop = false;
            this.groupBox_Pass.Text = "Mật khẩu";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MatKhau.Location = new System.Drawing.Point(15, 38);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(420, 30);
            this.textBox_MatKhau.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.Color.Transparent;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(735, 95);
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
            this.panel1.Location = new System.Drawing.Point(217, 551);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 48);
            this.panel1.TabIndex = 7;
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_DangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(200, 0);
            this.linkLabel_DangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Padding = new System.Windows.Forms.Padding(8);
            this.linkLabel_DangKy.Size = new System.Drawing.Size(95, 39);
            this.linkLabel_DangKy.TabIndex = 1;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chưa có tài khoản ? ";
            // 
            // linkLabel_QuenMatKhau
            // 
            this.linkLabel_QuenMatKhau.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_QuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_QuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(216, 612);
            this.linkLabel_QuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            this.linkLabel_QuenMatKhau.Padding = new System.Windows.Forms.Padding(8);
            this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(328, 40);
            this.linkLabel_QuenMatKhau.TabIndex = 8;
            this.linkLabel_QuenMatKhau.TabStop = true;
            this.linkLabel_QuenMatKhau.Text = "Quên mật khẩu";
            this.linkLabel_QuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenMatKhau_LinkClicked);
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
            this.button_DangNhap.Image = global::FinalProject.Properties.Resources.icons8_sign_in_24;
            this.button_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DangNhap.Location = new System.Drawing.Point(217, 472);
            this.button_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Padding = new System.Windows.Forms.Padding(8);
            this.button_DangNhap.Size = new System.Drawing.Size(327, 66);
            this.button_DangNhap.TabIndex = 6;
            this.button_DangNhap.Text = "ĐĂNG NHẬP";
            this.button_DangNhap.TextColor = System.Drawing.Color.White;
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::FinalProject.Properties.Resources.background_neon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 695);
            this.Controls.Add(this.linkLabel_QuenMatKhau);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.groupBox_Pass);
            this.Controls.Add(this.groupBox_Name);
            this.Controls.Add(this.groupBox_PhanQuyen);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
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
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
    }
}

