namespace FinalProject.UC
{
    partial class UCJobCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_MucLuong = new System.Windows.Forms.Label();
            this.label_DiaDiem = new System.Windows.Forms.Label();
            this.label_TenCongViec = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_TenCty = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_MucLuong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_DiaDiem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_TenCongViec, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Logo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_TenCty, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 194);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_MucLuong
            // 
            this.label_MucLuong.AutoSize = true;
            this.label_MucLuong.BackColor = System.Drawing.Color.LightBlue;
            this.label_MucLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MucLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MucLuong.ForeColor = System.Drawing.Color.Crimson;
            this.label_MucLuong.Location = new System.Drawing.Point(127, 147);
            this.label_MucLuong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label_MucLuong.Name = "label_MucLuong";
            this.label_MucLuong.Size = new System.Drawing.Size(127, 42);
            this.label_MucLuong.TabIndex = 8;
            this.label_MucLuong.Text = "Mức lương";
            this.label_MucLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DiaDiem
            // 
            this.label_DiaDiem.AutoSize = true;
            this.label_DiaDiem.BackColor = System.Drawing.Color.LightBlue;
            this.label_DiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DiaDiem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_DiaDiem.Location = new System.Drawing.Point(0, 147);
            this.label_DiaDiem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label_DiaDiem.Name = "label_DiaDiem";
            this.label_DiaDiem.Size = new System.Drawing.Size(127, 42);
            this.label_DiaDiem.TabIndex = 7;
            this.label_DiaDiem.Text = "Địa điểm";
            this.label_DiaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TenCongViec
            // 
            this.label_TenCongViec.AutoEllipsis = true;
            this.label_TenCongViec.AutoSize = true;
            this.label_TenCongViec.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label_TenCongViec, 2);
            this.label_TenCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TenCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TenCongViec.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenCongViec.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_TenCongViec.Location = new System.Drawing.Point(0, 68);
            this.label_TenCongViec.Margin = new System.Windows.Forms.Padding(0);
            this.label_TenCongViec.Name = "label_TenCongViec";
            this.label_TenCongViec.Size = new System.Drawing.Size(254, 79);
            this.label_TenCongViec.TabIndex = 1;
            this.label_TenCongViec.Text = "Tên công việc";
            this.label_TenCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TenCongViec.Click += new System.EventHandler(this.label_TenCongViec_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(127, 68);
            this.pictureBox_Logo.TabIndex = 5;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_TenCty
            // 
            this.label_TenCty.AutoSize = true;
            this.label_TenCty.BackColor = System.Drawing.Color.LightBlue;
            this.label_TenCty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TenCty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenCty.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_TenCty.Location = new System.Drawing.Point(127, 0);
            this.label_TenCty.Margin = new System.Windows.Forms.Padding(0);
            this.label_TenCty.Name = "label_TenCty";
            this.label_TenCty.Size = new System.Drawing.Size(127, 68);
            this.label_TenCty.TabIndex = 6;
            this.label_TenCty.Text = "Tên công ty";
            this.label_TenCty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCJobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(13);
            this.Name = "UCJobCard";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.Size = new System.Drawing.Size(280, 220);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_TenCongViec;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_TenCty;
        private System.Windows.Forms.Label label_MucLuong;
        private System.Windows.Forms.Label label_DiaDiem;
    }
}
