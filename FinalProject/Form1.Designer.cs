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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.groupBox_PhanQuyen = new System.Windows.Forms.GroupBox();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.radioButton_NhaTuyenDung = new System.Windows.Forms.RadioButton();
            this.radioButton__UngVien = new System.Windows.Forms.RadioButton();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.groupBox_Pass = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.groupBox_PhanQuyen.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.groupBox_Pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 30);
            this.textBox1.TabIndex = 0;
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DangNhap.Location = new System.Drawing.Point(245, 447);
            this.button_DangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(234, 53);
            this.button_DangNhap.TabIndex = 1;
            this.button_DangNhap.Text = "ĐĂNG NHẬP";
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // groupBox_PhanQuyen
            // 
            this.groupBox_PhanQuyen.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton_Admin);
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton_NhaTuyenDung);
            this.groupBox_PhanQuyen.Controls.Add(this.radioButton__UngVien);
            this.groupBox_PhanQuyen.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhanQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_PhanQuyen.Location = new System.Drawing.Point(185, 370);
            this.groupBox_PhanQuyen.Name = "groupBox_PhanQuyen";
            this.groupBox_PhanQuyen.Size = new System.Drawing.Size(387, 70);
            this.groupBox_PhanQuyen.TabIndex = 2;
            this.groupBox_PhanQuyen.TabStop = false;
            this.groupBox_PhanQuyen.Text = "Phân quyền:";
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_Admin.Location = new System.Drawing.Point(293, 26);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(91, 41);
            this.radioButton_Admin.TabIndex = 2;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_NhaTuyenDung
            // 
            this.radioButton_NhaTuyenDung.AutoSize = true;
            this.radioButton_NhaTuyenDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_NhaTuyenDung.Location = new System.Drawing.Point(114, 26);
            this.radioButton_NhaTuyenDung.Name = "radioButton_NhaTuyenDung";
            this.radioButton_NhaTuyenDung.Size = new System.Drawing.Size(167, 41);
            this.radioButton_NhaTuyenDung.TabIndex = 1;
            this.radioButton_NhaTuyenDung.TabStop = true;
            this.radioButton_NhaTuyenDung.Text = "Nhà tuyển dụng";
            this.radioButton_NhaTuyenDung.UseVisualStyleBackColor = true;
            // 
            // radioButton__UngVien
            // 
            this.radioButton__UngVien.AutoSize = true;
            this.radioButton__UngVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton__UngVien.Location = new System.Drawing.Point(3, 26);
            this.radioButton__UngVien.Name = "radioButton__UngVien";
            this.radioButton__UngVien.Size = new System.Drawing.Size(111, 41);
            this.radioButton__UngVien.TabIndex = 0;
            this.radioButton__UngVien.TabStop = true;
            this.radioButton__UngVien.Text = "Ứng viên";
            this.radioButton__UngVien.UseVisualStyleBackColor = true;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Name.Controls.Add(this.textBox1);
            this.groupBox_Name.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Name.Location = new System.Drawing.Point(199, 125);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Size = new System.Drawing.Size(360, 63);
            this.groupBox_Name.TabIndex = 3;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Tên đăng nhập";
            // 
            // groupBox_Pass
            // 
            this.groupBox_Pass.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Pass.Controls.Add(this.textBox2);
            this.groupBox_Pass.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Pass.Location = new System.Drawing.Point(199, 194);
            this.groupBox_Pass.Name = "groupBox_Pass";
            this.groupBox_Pass.Size = new System.Drawing.Size(360, 63);
            this.groupBox_Pass.TabIndex = 4;
            this.groupBox_Pass.TabStop = false;
            this.groupBox_Pass.Text = "Mật khẩu";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 30);
            this.textBox2.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.BackColor = System.Drawing.Color.Transparent;
            this.label_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Ten.Font = new System.Drawing.Font("iCiel Koni", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ten.Location = new System.Drawing.Point(0, 0);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(735, 66);
            this.label_Ten.TabIndex = 5;
            this.label_Ten.Text = "ĐĂNG NHẬP";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::FinalProject.Properties.Resources._7384eb896c87f613f4d36bba5a24108b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 592);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.groupBox_Pass);
            this.Controls.Add(this.groupBox_Name);
            this.Controls.Add(this.groupBox_PhanQuyen);
            this.Controls.Add(this.button_DangNhap);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_DangNhap";
            this.Text = "FDangnhap";
            this.groupBox_PhanQuyen.ResumeLayout(false);
            this.groupBox_PhanQuyen.PerformLayout();
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            this.groupBox_Pass.ResumeLayout(false);
            this.groupBox_Pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.GroupBox groupBox_PhanQuyen;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.RadioButton radioButton_NhaTuyenDung;
        private System.Windows.Forms.RadioButton radioButton__UngVien;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.GroupBox groupBox_Pass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Ten;
    }
}

