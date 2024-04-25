namespace FinalProject.Admin.GUI.ThongKe
{
    partial class FThongKeCongViec
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_DSCongTy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViTriTuyenDungPhoBien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViTriTuyenDungPhoBien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_DSCongTy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 64);
            this.panel1.TabIndex = 0;
            // 
            // label_DSCongTy
            // 
            this.label_DSCongTy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_DSCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DSCongTy.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DSCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_DSCongTy.Location = new System.Drawing.Point(0, 0);
            this.label_DSCongTy.Name = "label_DSCongTy";
            this.label_DSCongTy.Size = new System.Drawing.Size(1320, 64);
            this.label_DSCongTy.TabIndex = 13;
            this.label_DSCongTy.Text = "THỐNG KÊ CÔNG VIỆC";
            this.label_DSCongTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_DSCongTy.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ViTriTuyenDungPhoBien);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 284);
            this.panel2.TabIndex = 1;
            // 
            // ViTriTuyenDungPhoBien
            // 
            chartArea1.Name = "ChartArea1";
            this.ViTriTuyenDungPhoBien.ChartAreas.Add(chartArea1);
            this.ViTriTuyenDungPhoBien.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ViTriTuyenDungPhoBien.Legends.Add(legend1);
            this.ViTriTuyenDungPhoBien.Location = new System.Drawing.Point(0, 0);
            this.ViTriTuyenDungPhoBien.Name = "ViTriTuyenDungPhoBien";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ViTriTuyenDungPhoBien.Series.Add(series1);
            this.ViTriTuyenDungPhoBien.Size = new System.Drawing.Size(669, 284);
            this.ViTriTuyenDungPhoBien.TabIndex = 0;
            this.ViTriTuyenDungPhoBien.Text = "chart1";
            // 
            // FThongKeCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FThongKeCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThongKeCongViec";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViTriTuyenDungPhoBien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_DSCongTy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ViTriTuyenDungPhoBien;
    }
}