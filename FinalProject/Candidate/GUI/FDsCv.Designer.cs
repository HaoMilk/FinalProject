namespace FinalProject.Candidate.GUI
{
    partial class FDsCv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDsCv));
            this.label_DanhSachCv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.ucPagination = new FinalProject.UC.UCPagination();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DanhSachCv
            // 
            this.label_DanhSachCv.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_DanhSachCv.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DanhSachCv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DanhSachCv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_DanhSachCv.Location = new System.Drawing.Point(20, 50);
            this.label_DanhSachCv.Name = "label_DanhSachCv";
            this.label_DanhSachCv.Size = new System.Drawing.Size(960, 36);
            this.label_DanhSachCv.TabIndex = 0;
            this.label_DanhSachCv.Text = "DANH SÁCH CV";
            this.label_DanhSachCv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(20, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(844, 32);
            this.textBox1.TabIndex = 1;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackgroundImage = global::FinalProject.Properties.Resources.icons8_search_32;
            this.button_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TimKiem.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_TimKiem.FlatAppearance.BorderSize = 0;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.Location = new System.Drawing.Point(864, 10);
            this.button_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(76, 33);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(960, 53);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.panel2.Size = new System.Drawing.Size(960, 40);
            this.panel2.TabIndex = 6;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(916, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(44, 25);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(20, 139);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(960, 591);
            this.flowLayoutPanel_Data.TabIndex = 7;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Location = new System.Drawing.Point(20, 730);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(960, 50);
            this.ucPagination.TabIndex = 0;
            this.ucPagination.TotalRecord = 0;
            this.ucPagination.CurrentPageChanged += new System.EventHandler(this.ucPagination_CurrentPageChanged);
            // 
            // FDsCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.flowLayoutPanel_Data);
            this.Controls.Add(this.ucPagination);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_DanhSachCv);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDsCv";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDsCv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDsCv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_DanhSachCv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
        private FinalProject.UC.UCPagination ucPagination;
    }
}