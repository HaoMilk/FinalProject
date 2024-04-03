﻿namespace FinalProject.Candidate.GUI
{
    partial class FQlyCv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQlyCv));
            this.flowLayoutPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TenCv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucPagination = new FinalProject.UC.UCPagination();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Data
            // 
            this.flowLayoutPanel_Data.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Data.Location = new System.Drawing.Point(0, 173);
            this.flowLayoutPanel_Data.Name = "flowLayoutPanel_Data";
            this.flowLayoutPanel_Data.Padding = new System.Windows.Forms.Padding(18, 19, 18, 19);
            this.flowLayoutPanel_Data.Size = new System.Drawing.Size(828, 452);
            this.flowLayoutPanel_Data.TabIndex = 12;
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.OrangeRed;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Azure;
            this.label_Name.Location = new System.Drawing.Point(0, 38);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(828, 41);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "QUẢN LÝ CV";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(790, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(38, 24);
            this.button_Close.TabIndex = 1;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_Close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 9);
            this.panel3.Size = new System.Drawing.Size(828, 38);
            this.panel3.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 94);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(425, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.groupBox1.Size = new System.Drawing.Size(392, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý";
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Them.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button_Them.FlatAppearance.BorderSize = 0;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Image = global::FinalProject.Properties.Resources.icons8_add_24;
            this.button_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Them.Location = new System.Drawing.Point(11, 32);
            this.button_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(370, 28);
            this.button_Them.TabIndex = 7;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Name.Controls.Add(this.button_TimKiem);
            this.groupBox_Name.Controls.Add(this.textBox_TenCv);
            this.groupBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Name.Font = new System.Drawing.Font("Constantia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Name.Location = new System.Drawing.Point(11, 11);
            this.groupBox_Name.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.groupBox_Name.Size = new System.Drawing.Size(392, 71);
            this.groupBox_Name.TabIndex = 15;
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
            this.button_TimKiem.Location = new System.Drawing.Point(332, 32);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(49, 28);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // textBox_TenCv
            // 
            this.textBox_TenCv.BackColor = System.Drawing.Color.Azure;
            this.textBox_TenCv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenCv.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenCv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox_TenCv.Location = new System.Drawing.Point(11, 32);
            this.textBox_TenCv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenCv.Name = "textBox_TenCv";
            this.textBox_TenCv.Size = new System.Drawing.Size(370, 28);
            this.textBox_TenCv.TabIndex = 1;
            this.textBox_TenCv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TenCv_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 625);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 19);
            this.panel1.TabIndex = 0;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Location = new System.Drawing.Point(0, 644);
            this.ucPagination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(828, 47);
            this.ucPagination.TabIndex = 9;
            this.ucPagination.TotalRecord = 0;
            this.ucPagination.CurrentPageChanged += new System.EventHandler(this.ucPagination_CurrentPageChanged);
            // 
            // FQlyCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(828, 691);
            this.Controls.Add(this.flowLayoutPanel_Data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucPagination);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FQlyCv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý CV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FQlyCv_Load);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Data;
        private FinalProject.UC.UCPagination ucPagination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.TextBox textBox_TenCv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}