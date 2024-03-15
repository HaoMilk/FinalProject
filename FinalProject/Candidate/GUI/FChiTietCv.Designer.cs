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
            this.SuspendLayout();
            // 
            // label_CvName
            // 
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CvName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_CvName.Location = new System.Drawing.Point(0, 0);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(800, 39);
            this.label_CvName.TabIndex = 0;
            this.label_CvName.Text = "Công việc";
            this.label_CvName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_UpdatedTime
            // 
            this.label_UpdatedTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_UpdatedTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_UpdatedTime.Location = new System.Drawing.Point(0, 39);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(800, 39);
            this.label_UpdatedTime.TabIndex = 1;
            this.label_UpdatedTime.Text = "Thời gian";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FChiTietCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_UpdatedTime);
            this.Controls.Add(this.label_CvName);
            this.Name = "FChiTietCv";
            this.Text = "FChiTietCv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_CvName;
        private System.Windows.Forms.Label label_UpdatedTime;
    }
}