namespace FinalProject.Common.GUI
{
    partial class FQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuenMatKhau));
            this.pictureBox_Picture = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_LayMatKhau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Picture
            // 
            this.pictureBox_Picture.BackColor = System.Drawing.Color.Azure;
            this.pictureBox_Picture.BackgroundImage = global::FinalProject.Properties.Resources.techny_cybersecurity_with_password_locked_laptop;
            this.pictureBox_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Picture.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Picture.Location = new System.Drawing.Point(547, 37);
            this.pictureBox_Picture.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox_Picture.Name = "pictureBox_Picture";
            this.pictureBox_Picture.Size = new System.Drawing.Size(341, 407);
            this.pictureBox_Picture.TabIndex = 4;
            this.pictureBox_Picture.TabStop = false;
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Name.Location = new System.Drawing.Point(0, 50);
            this.label_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(926, 62);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "QUÊN MẬT KHẨU";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox_Picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(38, 37, 38, 37);
            this.panel1.Size = new System.Drawing.Size(926, 481);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.button_LayMatKhau);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(38, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 100, 50, 100);
            this.panel2.Size = new System.Drawing.Size(509, 407);
            this.panel2.TabIndex = 5;
            // 
            // button_LayMatKhau
            // 
            this.button_LayMatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_LayMatKhau.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LayMatKhau.Location = new System.Drawing.Point(50, 233);
            this.button_LayMatKhau.Name = "button_LayMatKhau";
            this.button_LayMatKhau.Size = new System.Drawing.Size(409, 74);
            this.button_LayMatKhau.TabIndex = 8;
            this.button_LayMatKhau.Text = "Lấy lại mật khẩu";
            this.button_LayMatKhau.UseVisualStyleBackColor = true;
            this.button_LayMatKhau.Click += new System.EventHandler(this.button_LayMatKhau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(50, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.groupBox1.Size = new System.Drawing.Size(409, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Email.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox_Email.Location = new System.Drawing.Point(14, 36);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(381, 32);
            this.textBox_Email.TabIndex = 1;
            // 
            // FQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "FQuenMatKhau";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Đổi mật khẩu";
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Picture;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_LayMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Email;
    }
}