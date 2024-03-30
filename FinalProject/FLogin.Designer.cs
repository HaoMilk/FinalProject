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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            this.label_Ten = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_PhanQuyen = new System.Windows.Forms.GroupBox();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.radioButton_NhaTuyenDung = new System.Windows.Forms.RadioButton();
            this.radioButton__UngVien = new System.Windows.Forms.RadioButton();
            this.groupBox_Pass = new System.Windows.Forms.GroupBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_DangNhap = new FinalProject.UC.UCCustomButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_PhanQuyen.SuspendLayout();
            this.groupBox_Pass.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.Color.Transparent;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold);
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ten.Location = new System.Drawing.Point(20, 60);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(896, 76);
            this.label_Ten.TabIndex = 5;
            this.label_Ten.Text = "ĐĂNG NHẬP";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 136);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.36285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.63715F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 523);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_PhanQuyen);
            this.panel2.Controls.Add(this.groupBox_Pass);
            this.panel2.Controls.Add(this.groupBox_Name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(451, 33);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panel2.Size = new System.Drawing.Size(412, 291);
            this.panel2.TabIndex = 0;
            // 
            // groupBox_PhanQuyen
            // 
            this.groupBox_PhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton_Admin);
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton_NhaTuyenDung);
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton__UngVien);
            this.groupBox_PhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_PhanQuyen.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhanQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_PhanQuyen.Location = new System.Drawing.Point(30, 187);
            this.groupBox_PhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_PhanQuyen.Name = "groupBox_PhanQuyen";
            this.groupBox_PhanQuyen.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox_PhanQuyen.Size = new System.Drawing.Size(352, 86);
            this.groupBox_PhanQuyen.TabIndex = 6;
            this.groupBox_PhanQuyen.TabStop = false;
            this.groupBox_PhanQuyen.Text = "Phân quyền";
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_Admin.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Admin.Location = new System.Drawing.Point(256, 33);
            this.radioButton_Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(83, 41);
            this.radioButton_Admin.TabIndex = 2;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_NhaTuyenDung
            // 
            this.radioButton_NhaTuyenDung.AutoSize = true;
            this.radioButton_NhaTuyenDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_NhaTuyenDung.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_NhaTuyenDung.Location = new System.Drawing.Point(117, 33);
            this.radioButton_NhaTuyenDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_NhaTuyenDung.Name = "radioButton_NhaTuyenDung";
            this.radioButton_NhaTuyenDung.Size = new System.Drawing.Size(93, 41);
            this.radioButton_NhaTuyenDung.TabIndex = 1;
            this.radioButton_NhaTuyenDung.Text = "Công ty";
            this.radioButton_NhaTuyenDung.UseVisualStyleBackColor = true;
            // 
            // radioButton__UngVien
            // 
            this.radioButton__UngVien.AutoSize = true;
            this.radioButton__UngVien.Checked = true;
            this.radioButton__UngVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton__UngVien.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton__UngVien.Location = new System.Drawing.Point(13, 33);
            this.radioButton__UngVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton__UngVien.Name = "radioButton__UngVien";
            this.radioButton__UngVien.Size = new System.Drawing.Size(104, 41);
            this.radioButton__UngVien.TabIndex = 0;
            this.radioButton__UngVien.TabStop = true;
            this.radioButton__UngVien.Text = "Ứng viên";
            this.radioButton__UngVien.UseVisualStyleBackColor = true;
            // 
            // groupBox_Pass
            // 
            this.groupBox_Pass.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Pass.Controls.Add(this.textBox_MatKhau);
            this.groupBox_Pass.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Pass.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Pass.Location = new System.Drawing.Point(30, 98);
            this.groupBox_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Pass.Name = "groupBox_Pass";
            this.groupBox_Pass.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox_Pass.Size = new System.Drawing.Size(352, 89);
            this.groupBox_Pass.TabIndex = 5;
            this.groupBox_Pass.TabStop = false;
            this.groupBox_Pass.Text = "Mật khẩu";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_MatKhau.Location = new System.Drawing.Point(13, 33);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(326, 32);
            this.textBox_MatKhau.TabIndex = 0;
            this.textBox_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Name.Controls.Add(this.textBox_TenDangNhap);
            this.groupBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Name.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Name.Location = new System.Drawing.Point(30, 10);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox_Name.Size = new System.Drawing.Size(352, 88);
            this.groupBox_Name.TabIndex = 4;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Tên đăng nhập";
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenDangNhap.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenDangNhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(13, 33);
            this.textBox_TenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(326, 32);
            this.textBox_TenDangNhap.TabIndex = 0;
            this.textBox_TenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.YIT_bg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(33, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 291);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_DangNhap);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.linkLabel_QuenMatKhau);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(451, 330);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel4.Size = new System.Drawing.Size(412, 160);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.linkLabel_DangKy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(30, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 50);
            this.panel1.TabIndex = 11;
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Segoe UI Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_DangKy.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel_DangKy.Location = new System.Drawing.Point(203, 0);
            this.linkLabel_DangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Padding = new System.Windows.Forms.Padding(10);
            this.linkLabel_DangKy.Size = new System.Drawing.Size(149, 43);
            this.linkLabel_DangKy.TabIndex = 1;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng ký ngay";
            this.linkLabel_DangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chưa có tài khoản? ";
            // 
            // linkLabel_QuenMatKhau
            // 
            this.linkLabel_QuenMatKhau.BackColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel_QuenMatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel_QuenMatKhau.Font = new System.Drawing.Font("Segoe UI Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_QuenMatKhau.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(30, 116);
            this.linkLabel_QuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            this.linkLabel_QuenMatKhau.Padding = new System.Windows.Forms.Padding(10);
            this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(352, 44);
            this.linkLabel_QuenMatKhau.TabIndex = 10;
            this.linkLabel_QuenMatKhau.TabStop = true;
            this.linkLabel_QuenMatKhau.Text = "Quên mật khẩu";
            this.linkLabel_QuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenMatKhau_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_Close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 40);
            this.panel3.TabIndex = 12;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(852, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(44, 40);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.Crimson;
            this.button_DangNhap.BackgroundColor = System.Drawing.Color.Crimson;
            this.button_DangNhap.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_DangNhap.BorderRadius = 0;
            this.button_DangNhap.BorderSize = 0;
            this.button_DangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_DangNhap.FlatAppearance.BorderSize = 0;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.button_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap.Image = global::FinalProject.Properties.Resources.icons8_sign_in_24;
            this.button_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DangNhap.Location = new System.Drawing.Point(30, 10);
            this.button_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_DangNhap.Size = new System.Drawing.Size(352, 56);
            this.button_DangNhap.TabIndex = 12;
            this.button_DangNhap.Text = "ĐĂNG NHẬP";
            this.button_DangNhap.TextColor = System.Drawing.Color.White;
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_DangNhap";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox_PhanQuyen.ResumeLayout(false);
            this.groupBox_PhanQuyen.PerformLayout();
            this.groupBox_Pass.ResumeLayout(false);
            this.groupBox_Pass.PerformLayout();
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_PhanQuyen;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.RadioButton radioButton_NhaTuyenDung;
        private System.Windows.Forms.RadioButton radioButton__UngVien;
        private System.Windows.Forms.GroupBox groupBox_Pass;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panel4;
        private UC.UCCustomButton button_DangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
    }
}

