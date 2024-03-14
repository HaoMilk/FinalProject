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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.label_CvName = new System.Windows.Forms.Label();
            this.label_UpdatedTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_CvName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_UpdatedTime, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Menu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_View, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(272, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_Menu
            // 
            this.button_Menu.BackColor = System.Drawing.Color.LightCyan;
            this.button_Menu.BackgroundImage = global::FinalProject.Properties.Resources.icons8_menu_96;
            this.button_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Menu.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Location = new System.Drawing.Point(139, 3);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Padding = new System.Windows.Forms.Padding(5);
            this.button_Menu.Size = new System.Drawing.Size(130, 35);
            this.button_Menu.TabIndex = 1;
            this.button_Menu.UseVisualStyleBackColor = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
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
            this.button_View.Location = new System.Drawing.Point(3, 3);
            this.button_View.Name = "button_View";
            this.button_View.Padding = new System.Windows.Forms.Padding(5);
            this.button_View.Size = new System.Drawing.Size(130, 35);
            this.button_View.TabIndex = 0;
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // label_CvName
            // 
            this.label_CvName.AutoEllipsis = true;
            this.label_CvName.AutoSize = true;
            this.label_CvName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CvName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CvName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CvName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_CvName.Location = new System.Drawing.Point(3, 45);
            this.label_CvName.Name = "label_CvName";
            this.label_CvName.Size = new System.Drawing.Size(272, 136);
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
            this.label_UpdatedTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdatedTime.ForeColor = System.Drawing.Color.Navy;
            this.label_UpdatedTime.Location = new System.Drawing.Point(3, 0);
            this.label_UpdatedTime.Name = "label_UpdatedTime";
            this.label_UpdatedTime.Size = new System.Drawing.Size(272, 45);
            this.label_UpdatedTime.TabIndex = 2;
            this.label_UpdatedTime.Text = "09/03/2024 11:10:00";
            this.label_UpdatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCJobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::FinalProject.Properties.Resources.default_cv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCJobCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(298, 248);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Label label_CvName;
        private System.Windows.Forms.Label label_UpdatedTime;
    }
}
