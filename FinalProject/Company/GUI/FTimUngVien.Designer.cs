namespace FinalProject.Company.GUI
{
    partial class FTimUngVien
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
            this.label_Name = new System.Windows.Forms.Label();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TenCv = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.OrangeRed;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Azure;
            this.label_Name.Location = new System.Drawing.Point(27, 50);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(1489, 57);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "QUẢN LÝ CV";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Name.Controls.Add(this.button_TimKiem);
            this.groupBox_Name.Controls.Add(this.textBox_TenCv);
            this.groupBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Name.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Name.Location = new System.Drawing.Point(27, 107);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.groupBox_Name.Size = new System.Drawing.Size(1489, 99);
            this.groupBox_Name.TabIndex = 16;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Tìm kiếm";
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackgroundImage = global::FinalProject.Properties.Resources.icons8_search_24;
            this.button_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TimKiem.FlatAppearance.BorderSize = 0;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.button_TimKiem.Location = new System.Drawing.Point(1403, 36);
            this.button_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(70, 48);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox_TenCv
            // 
            this.textBox_TenCv.BackColor = System.Drawing.Color.Azure;
            this.textBox_TenCv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenCv.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenCv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox_TenCv.Location = new System.Drawing.Point(16, 36);
            this.textBox_TenCv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TenCv.Name = "textBox_TenCv";
            this.textBox_TenCv.Size = new System.Drawing.Size(1457, 28);
            this.textBox_TenCv.TabIndex = 1;
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(27, 206);
            this.flowLayoutPanel_Data.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(1489, 867);
            this.flowLayoutPanel_Data.TabIndex = 17;
            // 
            // FTimUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 1102);
            this.Controls.Add(this.flowLayoutPanel_Data);
            this.Controls.Add(this.groupBox_Name);
            this.Controls.Add(this.label_Name);
            this.Name = "FTimUngVien";
            this.Text = "FTimUngVien";
            this.Load += new System.EventHandler(this.FTimUngVien_Load);
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.groupBox_Name, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel_Data, 0);
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TenCv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
    }
}