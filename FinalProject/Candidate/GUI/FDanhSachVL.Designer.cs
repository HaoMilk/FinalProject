﻿using FinalProject.UC;

namespace FinalProject.Candidate.GUI
{
    partial class FDanhSachVL_Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDanhSachVL_Name));
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_CongViec = new System.Windows.Forms.FlowLayoutPanel();
            this.ucPagination = new FinalProject.UC.UCPagination();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_FromDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_FromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox_KinhNghiem = new System.Windows.Forms.GroupBox();
            this.ucComboBox_KinhNghiem = new FinalProject.UC.UCComboBox();
            this.groupBox_GioiTinh = new System.Windows.Forms.GroupBox();
            this.ucComboBox_GioiTinh = new FinalProject.UC.UCComboBox();
            this.groupBox_Luong = new System.Windows.Forms.GroupBox();
            this.ucComboBox_Luong = new FinalProject.UC.UCComboBox();
            this.groupBox_Nganh = new System.Windows.Forms.GroupBox();
            this.ucComboBox_Nganh = new FinalProject.UC.UCComboBox();
            this.groupBox_DiaDiem = new System.Windows.Forms.GroupBox();
            this.ucComboBox_DiaDiem = new FinalProject.UC.UCComboBox();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucCustomButton1 = new FinalProject.UC.UCCustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_FromDate.SuspendLayout();
            this.groupBox_KinhNghiem.SuspendLayout();
            this.groupBox_GioiTinh.SuspendLayout();
            this.groupBox_Luong.SuspendLayout();
            this.groupBox_Nganh.SuspendLayout();
            this.groupBox_DiaDiem.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.flowLayoutPanel_CongViec);
            this.panel3.Controls.Add(this.ucPagination);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(418, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 793);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel_CongViec
            // 
            this.flowLayoutPanel_CongViec.AutoScroll = true;
            this.flowLayoutPanel_CongViec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel_CongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_CongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CongViec.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_CongViec.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel_CongViec.Name = "flowLayoutPanel_CongViec";
            this.flowLayoutPanel_CongViec.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.flowLayoutPanel_CongViec.Size = new System.Drawing.Size(1203, 718);
            this.flowLayoutPanel_CongViec.TabIndex = 3;
            // 
            // ucPagination
            // 
            this.ucPagination.CurrentPage = 1;
            this.ucPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagination.Location = new System.Drawing.Point(0, 718);
            this.ucPagination.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucPagination.Name = "ucPagination";
            this.ucPagination.Size = new System.Drawing.Size(1203, 75);
            this.ucPagination.TabIndex = 0;
            this.ucPagination.TotalRecord = 15;
            this.ucPagination.CurrentPageChanged += new System.EventHandler(this.ucPagination_CurrentPageChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox_FromDate);
            this.panel1.Controls.Add(this.groupBox_KinhNghiem);
            this.panel1.Controls.Add(this.groupBox_GioiTinh);
            this.panel1.Controls.Add(this.groupBox_Luong);
            this.panel1.Controls.Add(this.groupBox_Nganh);
            this.panel1.Controls.Add(this.groupBox_DiaDiem);
            this.panel1.Controls.Add(this.groupBox_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 588);
            this.panel1.TabIndex = 18;
            // 
            // groupBox_ToDate
            // 
            this.groupBox_ToDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_ToDate.Controls.Add(this.dateTimePicker_ToDate);
            this.groupBox_ToDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ToDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_ToDate.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_ToDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_ToDate.Location = new System.Drawing.Point(0, 786);
            this.groupBox_ToDate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_ToDate.Name = "groupBox_ToDate";
            this.groupBox_ToDate.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_ToDate.Size = new System.Drawing.Size(384, 114);
            this.groupBox_ToDate.TabIndex = 22;
            this.groupBox_ToDate.TabStop = false;
            this.groupBox_ToDate.Text = "  Đến ngày  ";
            // 
            // dateTimePicker_ToDate
            // 
            this.dateTimePicker_ToDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ToDate.Location = new System.Drawing.Point(36, 38);
            this.dateTimePicker_ToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_ToDate.Name = "dateTimePicker_ToDate";
            this.dateTimePicker_ToDate.Size = new System.Drawing.Size(312, 34);
            this.dateTimePicker_ToDate.TabIndex = 1;
            // 
            // groupBox_FromDate
            // 
            this.groupBox_FromDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_FromDate.Controls.Add(this.dateTimePicker_FromDate);
            this.groupBox_FromDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_FromDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_FromDate.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_FromDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_FromDate.Location = new System.Drawing.Point(0, 672);
            this.groupBox_FromDate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_FromDate.Name = "groupBox_FromDate";
            this.groupBox_FromDate.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_FromDate.Size = new System.Drawing.Size(384, 114);
            this.groupBox_FromDate.TabIndex = 21;
            this.groupBox_FromDate.TabStop = false;
            this.groupBox_FromDate.Text = "  Từ ngày  ";
            // 
            // dateTimePicker_FromDate
            // 
            this.dateTimePicker_FromDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_FromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FromDate.Location = new System.Drawing.Point(36, 38);
            this.dateTimePicker_FromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_FromDate.Name = "dateTimePicker_FromDate";
            this.dateTimePicker_FromDate.Size = new System.Drawing.Size(312, 34);
            this.dateTimePicker_FromDate.TabIndex = 0;
            // 
            // groupBox_KinhNghiem
            // 
            this.groupBox_KinhNghiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_KinhNghiem.Controls.Add(this.ucComboBox_KinhNghiem);
            this.groupBox_KinhNghiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_KinhNghiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_KinhNghiem.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_KinhNghiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_KinhNghiem.Location = new System.Drawing.Point(0, 558);
            this.groupBox_KinhNghiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_KinhNghiem.Name = "groupBox_KinhNghiem";
            this.groupBox_KinhNghiem.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_KinhNghiem.Size = new System.Drawing.Size(384, 114);
            this.groupBox_KinhNghiem.TabIndex = 20;
            this.groupBox_KinhNghiem.TabStop = false;
            this.groupBox_KinhNghiem.Text = "  Kinh nghiệm  ";
            // 
            // ucComboBox_KinhNghiem
            // 
            this.ucComboBox_KinhNghiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ucComboBox_KinhNghiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ucComboBox_KinhNghiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucComboBox_KinhNghiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_KinhNghiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_KinhNghiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_KinhNghiem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_KinhNghiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ucComboBox_KinhNghiem.FormattingEnabled = true;
            this.ucComboBox_KinhNghiem.ItemHeight = 47;
            this.ucComboBox_KinhNghiem.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_KinhNghiem.Location = new System.Drawing.Point(36, 38);
            this.ucComboBox_KinhNghiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucComboBox_KinhNghiem.Name = "ucComboBox_KinhNghiem";
            this.ucComboBox_KinhNghiem.Size = new System.Drawing.Size(312, 53);
            this.ucComboBox_KinhNghiem.TabIndex = 0;
            // 
            // groupBox_GioiTinh
            // 
            this.groupBox_GioiTinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_GioiTinh.Controls.Add(this.ucComboBox_GioiTinh);
            this.groupBox_GioiTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_GioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_GioiTinh.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_GioiTinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_GioiTinh.Location = new System.Drawing.Point(0, 444);
            this.groupBox_GioiTinh.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_GioiTinh.Name = "groupBox_GioiTinh";
            this.groupBox_GioiTinh.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_GioiTinh.Size = new System.Drawing.Size(384, 114);
            this.groupBox_GioiTinh.TabIndex = 19;
            this.groupBox_GioiTinh.TabStop = false;
            this.groupBox_GioiTinh.Text = "  Giới tính  ";
            // 
            // ucComboBox_GioiTinh
            // 
            this.ucComboBox_GioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ucComboBox_GioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ucComboBox_GioiTinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucComboBox_GioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_GioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_GioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_GioiTinh.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_GioiTinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ucComboBox_GioiTinh.FormattingEnabled = true;
            this.ucComboBox_GioiTinh.ItemHeight = 47;
            this.ucComboBox_GioiTinh.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_GioiTinh.Location = new System.Drawing.Point(36, 38);
            this.ucComboBox_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucComboBox_GioiTinh.Name = "ucComboBox_GioiTinh";
            this.ucComboBox_GioiTinh.Size = new System.Drawing.Size(312, 53);
            this.ucComboBox_GioiTinh.TabIndex = 0;
            // 
            // groupBox_Luong
            // 
            this.groupBox_Luong.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Luong.Controls.Add(this.ucComboBox_Luong);
            this.groupBox_Luong.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Luong.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_Luong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Luong.Location = new System.Drawing.Point(0, 330);
            this.groupBox_Luong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_Luong.Name = "groupBox_Luong";
            this.groupBox_Luong.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_Luong.Size = new System.Drawing.Size(384, 114);
            this.groupBox_Luong.TabIndex = 18;
            this.groupBox_Luong.TabStop = false;
            this.groupBox_Luong.Text = "  Mức lương  ";
            // 
            // ucComboBox_Luong
            // 
            this.ucComboBox_Luong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ucComboBox_Luong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ucComboBox_Luong.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucComboBox_Luong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_Luong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_Luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_Luong.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_Luong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ucComboBox_Luong.FormattingEnabled = true;
            this.ucComboBox_Luong.ItemHeight = 47;
            this.ucComboBox_Luong.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_Luong.Location = new System.Drawing.Point(36, 38);
            this.ucComboBox_Luong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucComboBox_Luong.Name = "ucComboBox_Luong";
            this.ucComboBox_Luong.Size = new System.Drawing.Size(312, 53);
            this.ucComboBox_Luong.TabIndex = 0;
            // 
            // groupBox_Nganh
            // 
            this.groupBox_Nganh.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_Nganh.Controls.Add(this.ucComboBox_Nganh);
            this.groupBox_Nganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Nganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Nganh.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_Nganh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Nganh.Location = new System.Drawing.Point(0, 216);
            this.groupBox_Nganh.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_Nganh.Name = "groupBox_Nganh";
            this.groupBox_Nganh.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_Nganh.Size = new System.Drawing.Size(384, 114);
            this.groupBox_Nganh.TabIndex = 17;
            this.groupBox_Nganh.TabStop = false;
            this.groupBox_Nganh.Text = "  Ngành nghề  ";
            // 
            // ucComboBox_Nganh
            // 
            this.ucComboBox_Nganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ucComboBox_Nganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ucComboBox_Nganh.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucComboBox_Nganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_Nganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_Nganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_Nganh.Font = new System.Drawing.Font("Constantia", 11F);
            this.ucComboBox_Nganh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ucComboBox_Nganh.FormattingEnabled = true;
            this.ucComboBox_Nganh.ItemHeight = 47;
            this.ucComboBox_Nganh.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_Nganh.Location = new System.Drawing.Point(36, 38);
            this.ucComboBox_Nganh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucComboBox_Nganh.Name = "ucComboBox_Nganh";
            this.ucComboBox_Nganh.Size = new System.Drawing.Size(312, 53);
            this.ucComboBox_Nganh.TabIndex = 0;
            // 
            // groupBox_DiaDiem
            // 
            this.groupBox_DiaDiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_DiaDiem.Controls.Add(this.ucComboBox_DiaDiem);
            this.groupBox_DiaDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_DiaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_DiaDiem.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_DiaDiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_DiaDiem.Location = new System.Drawing.Point(0, 102);
            this.groupBox_DiaDiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_DiaDiem.Name = "groupBox_DiaDiem";
            this.groupBox_DiaDiem.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_DiaDiem.Size = new System.Drawing.Size(384, 114);
            this.groupBox_DiaDiem.TabIndex = 16;
            this.groupBox_DiaDiem.TabStop = false;
            this.groupBox_DiaDiem.Text = "  Địa điểm  ";
            // 
            // ucComboBox_DiaDiem
            // 
            this.ucComboBox_DiaDiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ucComboBox_DiaDiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ucComboBox_DiaDiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.ucComboBox_DiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComboBox_DiaDiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_DiaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_DiaDiem.Font = new System.Drawing.Font("Constantia", 11F);
            this.ucComboBox_DiaDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ucComboBox_DiaDiem.FormattingEnabled = true;
            this.ucComboBox_DiaDiem.ItemHeight = 47;
            this.ucComboBox_DiaDiem.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_DiaDiem.Location = new System.Drawing.Point(36, 38);
            this.ucComboBox_DiaDiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucComboBox_DiaDiem.Name = "ucComboBox_DiaDiem";
            this.ucComboBox_DiaDiem.Size = new System.Drawing.Size(312, 53);
            this.ucComboBox_DiaDiem.TabIndex = 0;
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_TimKiem.Controls.Add(this.textBox_TimKiem);
            this.groupBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Padding = new System.Windows.Forms.Padding(36, 11, 36, 23);
            this.groupBox_TimKiem.Size = new System.Drawing.Size(384, 102);
            this.groupBox_TimKiem.TabIndex = 15;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "  Tìm kiếm  ";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TimKiem.Font = new System.Drawing.Font("Constantia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimKiem.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox_TimKiem.Location = new System.Drawing.Point(36, 38);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(312, 34);
            this.textBox_TimKiem.TabIndex = 0;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucCustomButton1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 793);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // ucCustomButton1
            // 
            this.ucCustomButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.ucCustomButton1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.ucCustomButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucCustomButton1.BorderRadius = 0;
            this.ucCustomButton1.BorderSize = 0;
            this.ucCustomButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomButton1.FlatAppearance.BorderSize = 0;
            this.ucCustomButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucCustomButton1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCustomButton1.ForeColor = System.Drawing.Color.White;
            this.ucCustomButton1.Image = global::FinalProject.Properties.Resources.icons8_search_32;
            this.ucCustomButton1.Location = new System.Drawing.Point(5, 717);
            this.ucCustomButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucCustomButton1.Name = "ucCustomButton1";
            this.ucCustomButton1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ucCustomButton1.Size = new System.Drawing.Size(408, 71);
            this.ucCustomButton1.TabIndex = 19;
            this.ucCustomButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ucCustomButton1.TextColor = System.Drawing.Color.White;
            this.ucCustomButton1.UseVisualStyleBackColor = false;
            this.ucCustomButton1.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.icons8_job_seeker_96;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 112);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FDanhSachVL_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1621, 843);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FDanhSachVL_Name";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDanhSachVL_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox_FromDate.ResumeLayout(false);
            this.groupBox_KinhNghiem.ResumeLayout(false);
            this.groupBox_GioiTinh.ResumeLayout(false);
            this.groupBox_Luong.ResumeLayout(false);
            this.groupBox_Nganh.ResumeLayout(false);
            this.groupBox_DiaDiem.ResumeLayout(false);
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CongViec;
        private UCPagination ucPagination;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_FromDate;
        private System.Windows.Forms.GroupBox groupBox_KinhNghiem;
        private UCComboBox ucComboBox_KinhNghiem;
        private System.Windows.Forms.GroupBox groupBox_GioiTinh;
        private UCComboBox ucComboBox_GioiTinh;
        private System.Windows.Forms.GroupBox groupBox_Luong;
        private UCComboBox ucComboBox_Luong;
        private System.Windows.Forms.GroupBox groupBox_Nganh;
        private UCComboBox ucComboBox_Nganh;
        private System.Windows.Forms.GroupBox groupBox_DiaDiem;
        private UCComboBox ucComboBox_DiaDiem;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCCustomButton ucCustomButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDate;
    }
}