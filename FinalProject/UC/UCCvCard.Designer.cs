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
            this.button_View = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_CvName = new System.Windows.Forms.Label();
            this.label_UpdatedTime = new System.Windows.Forms.Label();
            this.label_ViTriUngTuyen = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_ViTriUngTuyen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_View, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Delete, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_CvName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_UpdatedTime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_View
            // 
            this.button_View.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_View.BackgroundImage = global::FinalProject.Properties.Resources.icons8_menu_24;
            this.button_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_View.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_View.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button_View.FlatAppearance.BorderSize = 0;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.ForeColor = System.Drawing.SystemColors.Control;
            this.button_View.Location = new System.Drawing.Point(3, 185);
            this.button_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_View.Name = "button_View";
            this.button_View.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.button_View.Size = new System.Drawing.Size(125, 39);
            this.button_View.TabIndex = 4;
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkGray;
            this.button_Delete.BackgroundImage = global::FinalProject.Properties.Resources.icons8_delete_24;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Delete.Location = new System.Drawing.Point(134, 185);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.button_Delete.Size = new System.Drawing.Size(125, 39);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_CvName
            // 
            this.label_CvName.AutoEllipsis = true;
            this.label_CvName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_CvName, 2);
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CvName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CvName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.Color.Chocolate;
            this.label_CvName.Location = new System.Drawing.Point(3, 45);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(256, 68);
            this.label_CvName.TabIndex = 1;
            this.label_CvName.Text = "CV Name";
            this.label_CvName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_UpdatedTime
            // 
            this.label_UpdatedTime.AutoEllipsis = true;
            this.label_UpdatedTime.AutoSize = true;
            this.label_UpdatedTime.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel1.SetColumnSpan(this.label_UpdatedTime, 2);
            this.label_UpdatedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_UpdatedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_UpdatedTime.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.Color.White;
            this.label_UpdatedTime.Location = new System.Drawing.Point(3, 0);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(256, 45);
            this.label_UpdatedTime.TabIndex = 2;
            this.label_UpdatedTime.Text = "09/03/2024 11:10:00";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ViTriUngTuyen
            // 
            this.label_ViTriUngTuyen.AutoEllipsis = true;
            this.label_ViTriUngTuyen.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_ViTriUngTuyen, 2);
            this.label_ViTriUngTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ViTriUngTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ViTriUngTuyen.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ViTriUngTuyen.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_ViTriUngTuyen.Location = new System.Drawing.Point(3, 113);
            this.label_ViTriUngTuyen.Name = "label_ViTriUngTuyen";
            this.label_ViTriUngTuyen.Size = new System.Drawing.Size(256, 68);
            this.label_ViTriUngTuyen.TabIndex = 5;
            this.label_ViTriUngTuyen.Text = "ViTriUngTuyen";
            this.label_ViTriUngTuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCCvCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "UCCvCard";
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Size = new System.Drawing.Size(284, 252);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_CvName;
        private System.Windows.Forms.Label label_UpdatedTime;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_ViTriUngTuyen;
    }
}
