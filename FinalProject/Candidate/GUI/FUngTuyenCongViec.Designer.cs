﻿namespace FinalProject.Candidate.GUI
{
    partial class FUngTuyenCongViec
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
            this.label_JobName = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_TenUngVien = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ucComboBox_Cv = new FinalProject.UC.UCComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_TenCongTy = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_TenCongViec = new System.Windows.Forms.TextBox();
            this.groupBox_MoTa = new System.Windows.Forms.GroupBox();
            this.richTextBox_MoTa = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_MoTa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_JobName
            // 
            this.label_JobName.BackColor = System.Drawing.Color.Goldenrod;
            this.label_JobName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_JobName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JobName.ForeColor = System.Drawing.SystemColors.Control;
            this.label_JobName.Location = new System.Drawing.Point(0, 50);
            this.label_JobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_JobName.Name = "label_JobName";
            this.label_JobName.Size = new System.Drawing.Size(700, 37);
            this.label_JobName.TabIndex = 7;
            this.label_JobName.Text = "ỨNG TUYÊN VIỆC LÀM";
            this.label_JobName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.Crimson;
            this.button_Submit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Submit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Submit.FlatAppearance.BorderSize = 0;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Submit.Location = new System.Drawing.Point(0, 449);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(700, 44);
            this.button_Submit.TabIndex = 8;
            this.button_Submit.Text = "NỘP CV";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 154);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_TenUngVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox1.Size = new System.Drawing.Size(344, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ứng viên";
            // 
            // textBox_TenUngVien
            // 
            this.textBox_TenUngVien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_TenUngVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenUngVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenUngVien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_TenUngVien.Location = new System.Drawing.Point(9, 32);
            this.textBox_TenUngVien.Name = "textBox_TenUngVien";
            this.textBox_TenUngVien.Size = new System.Drawing.Size(326, 30);
            this.textBox_TenUngVien.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ucComboBox_Cv);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(353, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox5.Size = new System.Drawing.Size(344, 70);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CV";
            // 
            // ucComboBox_Cv
            // 
            this.ucComboBox_Cv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ucComboBox_Cv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_Cv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_Cv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBox_Cv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_Cv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ucComboBox_Cv.FormattingEnabled = true;
            this.ucComboBox_Cv.ItemHeight = 23;
            this.ucComboBox_Cv.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_Cv.Location = new System.Drawing.Point(9, 32);
            this.ucComboBox_Cv.Name = "ucComboBox_Cv";
            this.ucComboBox_Cv.Size = new System.Drawing.Size(326, 29);
            this.ucComboBox_Cv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_TenCongTy);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox3.Size = new System.Drawing.Size(344, 70);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công ty";
            // 
            // textBox_TenCongTy
            // 
            this.textBox_TenCongTy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_TenCongTy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenCongTy.Enabled = false;
            this.textBox_TenCongTy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_TenCongTy.Location = new System.Drawing.Point(9, 32);
            this.textBox_TenCongTy.Name = "textBox_TenCongTy";
            this.textBox_TenCongTy.Size = new System.Drawing.Size(326, 30);
            this.textBox_TenCongTy.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_TenCongViec);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(353, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox2.Size = new System.Drawing.Size(344, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công việc";
            // 
            // textBox_TenCongViec
            // 
            this.textBox_TenCongViec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_TenCongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TenCongViec.Enabled = false;
            this.textBox_TenCongViec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_TenCongViec.Location = new System.Drawing.Point(9, 32);
            this.textBox_TenCongViec.Name = "textBox_TenCongViec";
            this.textBox_TenCongViec.Size = new System.Drawing.Size(326, 30);
            this.textBox_TenCongViec.TabIndex = 1;
            // 
            // groupBox_MoTa
            // 
            this.groupBox_MoTa.Controls.Add(this.richTextBox_MoTa);
            this.groupBox_MoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_MoTa.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MoTa.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_MoTa.Location = new System.Drawing.Point(0, 241);
            this.groupBox_MoTa.Name = "groupBox_MoTa";
            this.groupBox_MoTa.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.groupBox_MoTa.Size = new System.Drawing.Size(700, 208);
            this.groupBox_MoTa.TabIndex = 10;
            this.groupBox_MoTa.TabStop = false;
            this.groupBox_MoTa.Text = "Ghi chú";
            // 
            // richTextBox_MoTa
            // 
            this.richTextBox_MoTa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox_MoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_MoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_MoTa.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_MoTa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.richTextBox_MoTa.Location = new System.Drawing.Point(9, 34);
            this.richTextBox_MoTa.Name = "richTextBox_MoTa";
            this.richTextBox_MoTa.Size = new System.Drawing.Size(682, 165);
            this.richTextBox_MoTa.TabIndex = 0;
            this.richTextBox_MoTa.Text = "";
            // 
            // FUngTuyenCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(700, 493);
            this.Controls.Add(this.groupBox_MoTa);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_JobName);
            this.Name = "FUngTuyenCongViec";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "FUngTuyenCongViec";
            this.Load += new System.EventHandler(this.FUngTuyenCongViec_Load);
            this.Controls.SetChildIndex(this.label_JobName, 0);
            this.Controls.SetChildIndex(this.button_Submit, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox_MoTa, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_MoTa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_JobName;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_TenCongTy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_TenCongViec;
        private System.Windows.Forms.GroupBox groupBox_MoTa;
        private System.Windows.Forms.RichTextBox richTextBox_MoTa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_TenUngVien;
        private FinalProject.UC.UCComboBox ucComboBox_Cv;
    }
}