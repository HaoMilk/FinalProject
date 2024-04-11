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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_DSCongTy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BieuDoCotLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BieuDoSoLuongCongViec = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCotLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoSoLuongCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_DSCongTy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 78);
            this.panel1.TabIndex = 0;
            // 
            // label_DSCongTy
            // 
            this.label_DSCongTy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.label_DSCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DSCongTy.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DSCongTy.ForeColor = System.Drawing.SystemColors.Info;
            this.label_DSCongTy.Location = new System.Drawing.Point(0, 0);
            this.label_DSCongTy.Name = "label_DSCongTy";
            this.label_DSCongTy.Size = new System.Drawing.Size(1320, 78);
            this.label_DSCongTy.TabIndex = 10;
            this.label_DSCongTy.Text = "CÔNG VIỆC";
            this.label_DSCongTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_DSCongTy.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 445);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BieuDoCotLuong);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 327);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BieuDoSoLuongCongViec);
            this.panel4.Location = new System.Drawing.Point(662, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 327);
            this.panel4.TabIndex = 1;
            // 
            // BieuDoCotLuong
            // 
            this.BieuDoCotLuong.BackColor = System.Drawing.Color.MistyRose;
            chartArea3.Name = "BieuDoCotLuong";
            this.BieuDoCotLuong.ChartAreas.Add(chartArea3);
            this.BieuDoCotLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.BieuDoCotLuong.Legends.Add(legend3);
            this.BieuDoCotLuong.Location = new System.Drawing.Point(0, 0);
            this.BieuDoCotLuong.Name = "BieuDoCotLuong";
            series3.ChartArea = "BieuDoCotLuong";
            series3.Legend = "Legend1";
            series3.Name = "BieuDoCotLuong";
            this.BieuDoCotLuong.Series.Add(series3);
            this.BieuDoCotLuong.Size = new System.Drawing.Size(653, 327);
            this.BieuDoCotLuong.TabIndex = 0;
            this.BieuDoCotLuong.Text = "chart1";
            // 
            // BieuDoSoLuongCongViec
            // 
            this.BieuDoSoLuongCongViec.BackColor = System.Drawing.Color.MistyRose;
            chartArea4.Name = "ChartArea1";
            this.BieuDoSoLuongCongViec.ChartAreas.Add(chartArea4);
            this.BieuDoSoLuongCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.BieuDoSoLuongCongViec.Legends.Add(legend4);
            this.BieuDoSoLuongCongViec.Location = new System.Drawing.Point(0, 0);
            this.BieuDoSoLuongCongViec.Name = "BieuDoSoLuongCongViec";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BieuDoSoLuongCongViec.Series.Add(series4);
            this.BieuDoSoLuongCongViec.Size = new System.Drawing.Size(653, 327);
            this.BieuDoSoLuongCongViec.TabIndex = 0;
            this.BieuDoSoLuongCongViec.Text = "chart2";
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
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCotLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoSoLuongCongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_DSCongTy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoSoLuongCongViec;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoCotLuong;
    }
}