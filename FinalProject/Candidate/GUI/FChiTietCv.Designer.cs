namespace FinalProject.Candidate.GUI
{
    partial class FChiTietCv
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
            this.label_CvName = new System.Windows.Forms.Label();
            this.label_UpdatedTime = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CvName
            // 
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CvName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_CvName.Location = new System.Drawing.Point(0, 0);
            this.label_CvName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(1173, 66);
            this.label_CvName.TabIndex = 0;
            this.label_CvName.Text = "Công việc";
            this.label_CvName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_CvName.Click += new System.EventHandler(this.label_CvName_Click);
            // 
            // label_UpdatedTime
            // 
            this.label_UpdatedTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_UpdatedTime.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_UpdatedTime.Location = new System.Drawing.Point(0, 66);
            this.label_UpdatedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(1173, 66);
            this.label_UpdatedTime.TabIndex = 1;
            this.label_UpdatedTime.Text = "Thời gian";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 465);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1165, 425);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Mô tả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1165, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quyền lợi ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1892, 788);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Kỹ năng yêu cầu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FChiTietCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1173, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_UpdatedTime);
            this.Controls.Add(this.label_CvName);
            this.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FChiTietCv";
            this.Text = "FChiTietCv";
            this.Load += new System.EventHandler(this.FChiTietCv_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_CvName;
        private System.Windows.Forms.Label label_UpdatedTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}