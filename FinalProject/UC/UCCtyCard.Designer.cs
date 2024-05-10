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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 182);
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
            this.label_Name.Location = new System.Drawing.Point(3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label_Name.Size = new System.Drawing.Size(224, 182);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Công ty";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // UCCtyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCCtyCard";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(252, 202);
            this.Load += new System.EventHandler(this.UCCtyCard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Name;
    }
}
