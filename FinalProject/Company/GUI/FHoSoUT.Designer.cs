namespace FinalProject.Company.GUI
{
    partial class FHoSoUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHoSoUT));
            this.label_Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel_CongViec = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.OrangeRed;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Azure;
            this.label_Name.Location = new System.Drawing.Point(14, 64);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(694, 41);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "DANH SÁCH CÔNG VIỆC";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_CongViec
            // 
            this.flowLayoutPanel_CongViec.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel_CongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CongViec.Location = new System.Drawing.Point(14, 105);
            this.flowLayoutPanel_CongViec.Name = "flowLayoutPanel_CongViec";
            this.flowLayoutPanel_CongViec.Padding = new System.Windows.Forms.Padding(18, 19, 18, 19);
            this.flowLayoutPanel_CongViec.Size = new System.Drawing.Size(694, 441);
            this.flowLayoutPanel_CongViec.TabIndex = 17;
            // 
            // FHoSoUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(722, 560);
            this.Controls.Add(this.flowLayoutPanel_CongViec);
            this.Controls.Add(this.label_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FHoSoUT";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "Quản lý CV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FQlyCv_Load);
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel_CongViec, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CongViec;
    }
}