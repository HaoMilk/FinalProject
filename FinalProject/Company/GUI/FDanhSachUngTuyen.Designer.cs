namespace FinalProject.Company.GUI
{
    partial class FDanhSachUngTuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_HoSo = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách CV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_HoSo
            // 
            this.flowLayoutPanel_HoSo.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel_HoSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_HoSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_HoSo.Location = new System.Drawing.Point(27, 81);
            this.flowLayoutPanel_HoSo.Name = "flowLayoutPanel_HoSo";
            this.flowLayoutPanel_HoSo.Padding = new System.Windows.Forms.Padding(18, 19, 18, 19);
            this.flowLayoutPanel_HoSo.Size = new System.Drawing.Size(693, 634);
            this.flowLayoutPanel_HoSo.TabIndex = 18;
            // 
            // FDanhSachUngTuyencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 744);
            this.Controls.Add(this.flowLayoutPanel_HoSo);
            this.Controls.Add(this.label1);
            this.Name = "FDanhSachUngTuyencs";
            this.Text = "FDanhSachUngTuyencs";
            this.Load += new System.EventHandler(this.FDanhSachUngTuyencs_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel_HoSo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_HoSo;
    }
}