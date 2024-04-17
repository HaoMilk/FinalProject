namespace FinalProject.Company.GUI
{
    partial class FDanhSachViecLam
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
            this.UC_DSVL = new FinalProject.UC.UCDanhSachViecLam();
            this.SuspendLayout();
            // 
            // UC_DSVL
            // 
            this.UC_DSVL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_DSVL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_DSVL.Location = new System.Drawing.Point(0, 0);
            this.UC_DSVL.Margin = new System.Windows.Forms.Padding(4);
            this.UC_DSVL.Name = "UC_DSVL";
            this.UC_DSVL.Size = new System.Drawing.Size(1319, 747);
            this.UC_DSVL.TabIndex = 0;
            this.UC_DSVL.Load += new System.EventHandler(this.UC_DSVL_Load);
            // 
            // FDanhSachViecLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 747);
            this.Controls.Add(this.UC_DSVL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachViecLam";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UCDanhSachViecLam UC_DSVL;
    }
}