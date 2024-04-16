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
            this.button_View = new System.Windows.Forms.Button();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_View, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Image, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_View
            // 
            this.button_View.AutoEllipsis = true;
            this.button_View.BackColor = System.Drawing.Color.Cornsilk;
            this.button_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_View.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.ForeColor = System.Drawing.Color.Orange;
            this.button_View.Location = new System.Drawing.Point(4, 92);
            this.button_View.Margin = new System.Windows.Forms.Padding(4);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(268, 80);
            this.button_View.TabIndex = 0;
            this.button_View.Text = "Menu";
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImage = global::FinalProject.Properties.Resources.icons8_name_96;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Image.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(268, 80);
            this.pictureBox_Image.TabIndex = 1;
            this.pictureBox_Image.TabStop = false;
            // 
            // UCMenuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
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
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.PictureBox pictureBox_Image;
    }
}
