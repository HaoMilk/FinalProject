namespace FinalProject.UC
{
    partial class UCMenuCard
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
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label_Menu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Image, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Menu, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.95454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.04546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImage = global::FinalProject.Properties.Resources.icons8_name_96;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(268, 94);
            this.pictureBox_Image.TabIndex = 1;
            this.pictureBox_Image.TabStop = false;
            this.pictureBox_Image.Click += new System.EventHandler(this.pictureBox_Image_Click);
            // 
            // label_Menu
            // 
            this.label_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Menu.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Menu.Location = new System.Drawing.Point(3, 102);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(270, 74);
            this.label_Menu.TabIndex = 2;
            this.label_Menu.Text = "Menu";
            this.label_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Menu.Click += new System.EventHandler(this.label_Menu_Click);
            // 
            // UCMenuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(13);
            this.Name = "UCMenuCard";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.Size = new System.Drawing.Size(302, 202);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label_Menu;
    }
}
