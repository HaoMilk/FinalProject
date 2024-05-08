namespace FinalProject.UC
{
    partial class UCCtyCard
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
            this.label_Name = new System.Windows.Forms.Label();
            this.button_View = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_View, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoEllipsis = true;
            this.label_Name.BackColor = System.Drawing.Color.Azure;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_Name.Image = global::FinalProject.Properties.Resources.icons8_company_100;
            this.label_Name.Location = new System.Drawing.Point(2, 0);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label_Name.Size = new System.Drawing.Size(169, 111);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Công ty";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button_View
            // 
            this.button_View.BackColor = System.Drawing.Color.DarkOrange;
            this.button_View.BackgroundImage = global::FinalProject.Properties.Resources.icons8_menu_24;
            this.button_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_View.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_View.FlatAppearance.BorderSize = 0;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Location = new System.Drawing.Point(2, 113);
            this.button_View.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(169, 33);
            this.button_View.TabIndex = 1;
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // UCCtyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCCtyCard";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Size = new System.Drawing.Size(189, 164);
            this.Load += new System.EventHandler(this.UCCtyCard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_View;
    }
}
