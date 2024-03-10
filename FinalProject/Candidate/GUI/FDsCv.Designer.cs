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
            this.label_DanhSachCv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_DanhSachCv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCv)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DanhSachCv
            // 
            this.label_DanhSachCv.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_DanhSachCv.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_DanhSachCv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DanhSachCv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_DanhSachCv.Location = new System.Drawing.Point(0, 0);
            this.label_DanhSachCv.Name = "label_DanhSachCv";
            this.label_DanhSachCv.Size = new System.Drawing.Size(1079, 36);
            this.label_DanhSachCv.TabIndex = 0;
            this.label_DanhSachCv.Text = "DANH SÁCH CV";
            this.label_DanhSachCv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(946, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.Location = new System.Drawing.Point(946, 0);
            this.button_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(133, 23);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 23);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView_DanhSachCv
            // 
            this.dataGridView_DanhSachCv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachCv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DanhSachCv.Location = new System.Drawing.Point(0, 59);
            this.dataGridView_DanhSachCv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_DanhSachCv.Name = "dataGridView_DanhSachCv";
            this.dataGridView_DanhSachCv.RowHeadersWidth = 62;
            this.dataGridView_DanhSachCv.RowTemplate.Height = 28;
            this.dataGridView_DanhSachCv.Size = new System.Drawing.Size(1079, 388);
            this.dataGridView_DanhSachCv.TabIndex = 4;
            // 
            // FDsCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 447);
            this.Controls.Add(this.dataGridView_DanhSachCv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_DanhSachCv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDsCv";
            this.Text = "FDsCv";
            this.Load += new System.EventHandler(this.FDsCv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachCv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_DanhSachCv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachCv;
    }
}