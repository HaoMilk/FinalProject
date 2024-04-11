namespace FinalProject.UC
{
    partial class UCViewJob
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
            this.label_UpdatedTime = new System.Windows.Forms.Label();
            this.label_CvName = new System.Windows.Forms.Label();
            this.button_View = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UpdatedTime
            // 
            this.label_UpdatedTime.AutoEllipsis = true;
            this.label_UpdatedTime.AutoSize = true;
            this.label_UpdatedTime.BackColor = System.Drawing.Color.Transparent;
            this.label_UpdatedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_UpdatedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_UpdatedTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_UpdatedTime.Location = new System.Drawing.Point(3, 0);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(288, 42);
            this.label_UpdatedTime.TabIndex = 2;
            this.label_UpdatedTime.Text = "09/03/2024 11:10:00";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_CvName
            // 
            this.label_CvName.AutoEllipsis = true;
            this.label_CvName.AutoSize = true;
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CvName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CvName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_CvName.Location = new System.Drawing.Point(3, 42);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(288, 126);
            this.label_CvName.TabIndex = 1;
            this.label_CvName.Text = "CV Name";
            this.label_CvName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_View
            // 
            this.button_View.BackColor = System.Drawing.Color.Cornsilk;
            this.button_View.BackgroundImage = global::FinalProject.Properties.Resources.icons8_view_96;
            this.button_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_View.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Location = new System.Drawing.Point(3, 171);
            this.button_View.Name = "button_View";
            this.button_View.Padding = new System.Windows.Forms.Padding(5);
            this.button_View.Size = new System.Drawing.Size(288, 36);
            this.button_View.TabIndex = 4;
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.57823F));
            this.tableLayoutPanel1.Controls.Add(this.button_View, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_CvName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_UpdatedTime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 210);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // UCViewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.default_cv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCViewJob";
            this.Size = new System.Drawing.Size(294, 210);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_UpdatedTime;
        private System.Windows.Forms.Label label_CvName;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
