namespace FinalProject.UC
{
    partial class UCViewCV
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
            this.label_CvName = new System.Windows.Forms.Label();
            this.label_UpdatedTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_CvName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_UpdatedTime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 166);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_CvName
            // 
            this.label_CvName.AutoEllipsis = true;
            this.label_CvName.AutoSize = true;
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CvName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CvName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.Color.Chocolate;
            this.label_CvName.Location = new System.Drawing.Point(2, 41);
            this.label_CvName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(180, 125);
            this.label_CvName.TabIndex = 1;
            this.label_CvName.Text = "CV Name";
            this.label_CvName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_CvName.Click += new System.EventHandler(this.label_CvName_Click);
            // 
            // label_UpdatedTime
            // 
            this.label_UpdatedTime.AutoEllipsis = true;
            this.label_UpdatedTime.AutoSize = true;
            this.label_UpdatedTime.BackColor = System.Drawing.Color.LightSalmon;
            this.label_UpdatedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_UpdatedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_UpdatedTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.Color.White;
            this.label_UpdatedTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_UpdatedTime.Location = new System.Drawing.Point(2, 0);
            this.label_UpdatedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(180, 41);
            this.label_UpdatedTime.TabIndex = 2;
            this.label_UpdatedTime.Text = "09/03/2024 11:10:00";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCViewCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FinalProject.Properties.Resources.rounded_reactangle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "UCViewCV";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Size = new System.Drawing.Size(200, 182);
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
