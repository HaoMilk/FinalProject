namespace FinalProject.UC
{
    partial class UCCvCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCvCard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_CvName = new System.Windows.Forms.Label();
            this.label_UpdatedTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_CvName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_UpdatedTime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_CvName
            // 
            this.label_CvName.AutoEllipsis = true;
            this.label_CvName.AutoSize = true;
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CvName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CvName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.Color.Chocolate;
            this.label_CvName.Location = new System.Drawing.Point(3, 45);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(226, 137);
            this.label_CvName.TabIndex = 1;
            this.label_CvName.Text = "CV Name";
            this.label_CvName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_UpdatedTime
            // 
            this.label_UpdatedTime.AutoEllipsis = true;
            this.label_UpdatedTime.AutoSize = true;
            this.label_UpdatedTime.BackColor = System.Drawing.Color.Transparent;
            this.label_UpdatedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_UpdatedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_UpdatedTime.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.Color.Firebrick;
            this.label_UpdatedTime.Location = new System.Drawing.Point(3, 0);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(226, 45);
            this.label_UpdatedTime.TabIndex = 2;
            this.label_UpdatedTime.Text = "09/03/2024 11:10:00";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCCvCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCCvCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(252, 202);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_CvName;
        private System.Windows.Forms.Label label_UpdatedTime;
    }
}
