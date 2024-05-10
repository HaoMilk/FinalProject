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
            this.textBox_TenUngVien = new System.Windows.Forms.TextBox();
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.groupBox_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.OrangeRed;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Azure;
            this.label_Name.Location = new System.Drawing.Point(19, 50);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(1042, 41);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "DANH SÁCH ỨNG VIÊN";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Name.Controls.Add(this.button_TimKiem);
            this.groupBox_Name.Controls.Add(this.textBox_TenUngVien);
            this.groupBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Name.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Name.Location = new System.Drawing.Point(19, 91);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(11);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(11);
            this.groupBox_Name.Size = new System.Drawing.Size(1042, 71);
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
            this.button_TimKiem.Location = new System.Drawing.Point(982, 28);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(49, 32);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // textBox_TenUngVien
            // 
            this.textBox_TenUngVien.BackColor = System.Drawing.Color.Azure;
            this.textBox_TenUngVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenUngVien.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenUngVien.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox_TenUngVien.Location = new System.Drawing.Point(11, 28);
            this.textBox_TenUngVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenUngVien.Name = "textBox_TenUngVien";
            this.textBox_TenUngVien.Size = new System.Drawing.Size(1020, 24);
            this.textBox_TenUngVien.TabIndex = 1;
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Data.Location = new System.Drawing.Point(19, 162);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.Size = new System.Drawing.Size(1042, 603);
            this.dataGridView_Data.TabIndex = 17;
            this.dataGridView_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Data_CellClick);
            // 
            // FTimUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1080, 786);
            this.Controls.Add(this.dataGridView_Data);
            this.Controls.Add(this.groupBox_Name);
            this.Controls.Add(this.label_Name);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FTimUngVien";
            this.Padding = new System.Windows.Forms.Padding(19, 0, 19, 21);
            this.Text = "FTimUngVien";
            this.Load += new System.EventHandler(this.FTimUngVien_Load);
            this.Controls.SetChildIndex(this.label_Name, 0);
            this.Controls.SetChildIndex(this.groupBox_Name, 0);
            this.Controls.SetChildIndex(this.dataGridView_Data, 0);
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TenUngVien;
        private System.Windows.Forms.DataGridView dataGridView_Data;
    }
}