using System.Windows.Forms;

namespace FinalProject.Candidate.GUI
{
    partial class FCandidateInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCandidateInfor));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Container = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ChangeAvatar = new System.Windows.Forms.Button();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            this.button_XacNhanEmail = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ucComboBox_TrangThaiEmail = new FinalProject.UC.UCComboBox();
            this.groupBox_TrangThai = new System.Windows.Forms.GroupBox();
            this.ucComboBox_TrangThai = new FinalProject.UC.UCComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox_ChuyenMon = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ucComboBox_Gender = new FinalProject.UC.UCComboBox();
            this.pictureBox_Avatar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime_Birthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Container.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox_TrangThai.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ỨNG VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_Container
            // 
            this.tableLayoutPanel_Container.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel_Container.ColumnCount = 3;
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel_Container.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox8, 1, 3);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox_TrangThai, 0, 3);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox6, 0, 4);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox5, 1, 2);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel_Container.Controls.Add(this.pictureBox_Avatar, 2, 0);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel_Container.Controls.Add(this.groupBox, 0, 0);
            this.tableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Container.Location = new System.Drawing.Point(0, 98);
            this.tableLayoutPanel_Container.Name = "tableLayoutPanel_Container";
            this.tableLayoutPanel_Container.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel_Container.RowCount = 5;
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Container.Size = new System.Drawing.Size(1200, 552);
            this.tableLayoutPanel_Container.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_ChangeAvatar);
            this.flowLayoutPanel1.Controls.Add(this.button_DoiMatKhau);
            this.flowLayoutPanel1.Controls.Add(this.button_Save);
            this.flowLayoutPanel1.Controls.Add(this.button_XacNhanEmail);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(883, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel_Container.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 200);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // button_ChangeAvatar
            // 
            this.button_ChangeAvatar.AutoSize = true;
            this.button_ChangeAvatar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_ChangeAvatar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button_ChangeAvatar.FlatAppearance.BorderSize = 0;
            this.button_ChangeAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangeAvatar.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangeAvatar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_ChangeAvatar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ChangeAvatar.Location = new System.Drawing.Point(16, 15);
            this.button_ChangeAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_ChangeAvatar.Name = "button_ChangeAvatar";
            this.button_ChangeAvatar.Size = new System.Drawing.Size(128, 72);
            this.button_ChangeAvatar.TabIndex = 24;
            this.button_ChangeAvatar.Text = "Đổi Avatar";
            this.button_ChangeAvatar.UseVisualStyleBackColor = false;
            this.button_ChangeAvatar.Click += new System.EventHandler(this.button_ChangeAvatar_Click);
            // 
            // button_DoiMatKhau
            // 
            this.button_DoiMatKhau.BackColor = System.Drawing.Color.DarkOrange;
            this.button_DoiMatKhau.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_DoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button_DoiMatKhau.FlatAppearance.BorderSize = 0;
            this.button_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DoiMatKhau.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DoiMatKhau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_DoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_DoiMatKhau.Location = new System.Drawing.Point(152, 15);
            this.button_DoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(126, 72);
            this.button_DoiMatKhau.TabIndex = 27;
            this.button_DoiMatKhau.Text = "Đổi mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = false;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // button_XacNhanEmail
            // 
            this.button_XacNhanEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.button_XacNhanEmail.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button_XacNhanEmail.FlatAppearance.BorderSize = 0;
            this.button_XacNhanEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XacNhanEmail.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XacNhanEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_XacNhanEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_XacNhanEmail.Location = new System.Drawing.Point(150, 93);
            this.button_XacNhanEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_XacNhanEmail.Name = "button_XacNhanEmail";
            this.button_XacNhanEmail.Size = new System.Drawing.Size(128, 72);
            this.button_XacNhanEmail.TabIndex = 28;
            this.button_XacNhanEmail.Text = "Xác nhận email";
            this.button_XacNhanEmail.UseVisualStyleBackColor = false;
            this.button_XacNhanEmail.Click += new System.EventHandler(this.button_XacNhanEmail_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Save.Location = new System.Drawing.Point(16, 93);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(126, 72);
            this.button_Save.TabIndex = 29;
            this.button_Save.Text = "Lưu";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ucComboBox_TrangThaiEmail);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(456, 332);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox8.Size = new System.Drawing.Size(418, 90);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Trạng thái email";
            // 
            // ucComboBox_TrangThaiEmail
            // 
            this.ucComboBox_TrangThaiEmail.BackColor = System.Drawing.Color.Azure;
            this.ucComboBox_TrangThaiEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucComboBox_TrangThaiEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_TrangThaiEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBox_TrangThaiEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_TrangThaiEmail.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_TrangThaiEmail.FormattingEnabled = true;
            this.ucComboBox_TrangThaiEmail.ItemHeight = 27;
            this.ucComboBox_TrangThaiEmail.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_TrangThaiEmail.Location = new System.Drawing.Point(6, 31);
            this.ucComboBox_TrangThaiEmail.Name = "ucComboBox_TrangThaiEmail";
            this.ucComboBox_TrangThaiEmail.SelectedItem = null;
            this.ucComboBox_TrangThaiEmail.Size = new System.Drawing.Size(406, 33);
            this.ucComboBox_TrangThaiEmail.TabIndex = 0;
            // 
            // groupBox_TrangThai
            // 
            this.groupBox_TrangThai.Controls.Add(this.ucComboBox_TrangThai);
            this.groupBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_TrangThai.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TrangThai.Location = new System.Drawing.Point(26, 332);
            this.groupBox_TrangThai.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_TrangThai.Name = "groupBox_TrangThai";
            this.groupBox_TrangThai.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_TrangThai.Size = new System.Drawing.Size(418, 90);
            this.groupBox_TrangThai.TabIndex = 25;
            this.groupBox_TrangThai.TabStop = false;
            this.groupBox_TrangThai.Text = "Trạng thái tài khoản";
            // 
            // ucComboBox_TrangThai
            // 
            this.ucComboBox_TrangThai.BackColor = System.Drawing.Color.Azure;
            this.ucComboBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucComboBox_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBox_TrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_TrangThai.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_TrangThai.FormattingEnabled = true;
            this.ucComboBox_TrangThai.ItemHeight = 27;
            this.ucComboBox_TrangThai.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_TrangThai.Location = new System.Drawing.Point(6, 31);
            this.ucComboBox_TrangThai.Name = "ucComboBox_TrangThai";
            this.ucComboBox_TrangThai.SelectedItem = null;
            this.ucComboBox_TrangThai.Size = new System.Drawing.Size(406, 33);
            this.ucComboBox_TrangThai.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.tableLayoutPanel_Container.SetColumnSpan(this.groupBox6, 2);
            this.groupBox6.Controls.Add(this.richTextBox_ChuyenMon);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(26, 434);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(848, 92);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chuyên môn";
            // 
            // richTextBox_ChuyenMon
            // 
            this.richTextBox_ChuyenMon.BackColor = System.Drawing.Color.Azure;
            this.richTextBox_ChuyenMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_ChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_ChuyenMon.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ChuyenMon.Location = new System.Drawing.Point(6, 31);
            this.richTextBox_ChuyenMon.Name = "richTextBox_ChuyenMon";
            this.richTextBox_ChuyenMon.Size = new System.Drawing.Size(836, 55);
            this.richTextBox_ChuyenMon.TabIndex = 0;
            this.richTextBox_ChuyenMon.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_Email);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(456, 230);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(418, 90);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.Azure;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Email.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Email.Location = new System.Drawing.Point(6, 31);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(406, 32);
            this.textBox_Email.TabIndex = 4;
            this.textBox_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Phone);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(418, 90);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số điện thoại";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.BackColor = System.Drawing.Color.Azure;
            this.textBox_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Phone.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Phone.Location = new System.Drawing.Point(6, 31);
            this.textBox_Phone.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(406, 32);
            this.textBox_Phone.TabIndex = 4;
            this.textBox_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Address);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(456, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(418, 90);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Địa chỉ";
            // 
            // textBox_Address
            // 
            this.textBox_Address.BackColor = System.Drawing.Color.Azure;
            this.textBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Address.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Address.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Address.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Address.Location = new System.Drawing.Point(6, 31);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(406, 32);
            this.textBox_Address.TabIndex = 4;
            this.textBox_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ucComboBox_Gender);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(26, 128);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(418, 90);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới tính";
            // 
            // ucComboBox_Gender
            // 
            this.ucComboBox_Gender.BackColor = System.Drawing.Color.Azure;
            this.ucComboBox_Gender.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucComboBox_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ucComboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBox_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucComboBox_Gender.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucComboBox_Gender.FormattingEnabled = true;
            this.ucComboBox_Gender.ItemHeight = 27;
            this.ucComboBox_Gender.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_Gender.Location = new System.Drawing.Point(6, 31);
            this.ucComboBox_Gender.Name = "ucComboBox_Gender";
            this.ucComboBox_Gender.SelectedItem = null;
            this.ucComboBox_Gender.Size = new System.Drawing.Size(406, 33);
            this.ucComboBox_Gender.TabIndex = 0;
            // 
            // pictureBox_Avatar
            // 
            this.pictureBox_Avatar.BackColor = System.Drawing.Color.Azure;
            this.pictureBox_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Avatar.Location = new System.Drawing.Point(914, 52);
            this.pictureBox_Avatar.Margin = new System.Windows.Forms.Padding(34, 32, 34, 32);
            this.pictureBox_Avatar.Name = "pictureBox_Avatar";
            this.pictureBox_Avatar.Padding = new System.Windows.Forms.Padding(34, 32, 34, 32);
            this.tableLayoutPanel_Container.SetRowSpan(this.pictureBox_Avatar, 3);
            this.pictureBox_Avatar.Size = new System.Drawing.Size(232, 242);
            this.pictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Avatar.TabIndex = 15;
            this.pictureBox_Avatar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_Birthday);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(456, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(418, 90);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Năm sinh";
            // 
            // dateTime_Birthday
            // 
            this.dateTime_Birthday.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTime_Birthday.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dateTime_Birthday.CalendarTitleBackColor = System.Drawing.Color.SteelBlue;
            this.dateTime_Birthday.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.dateTime_Birthday.CalendarTrailingForeColor = System.Drawing.Color.LightSteelBlue;
            this.dateTime_Birthday.CustomFormat = "yyyy-MM-dd";
            this.dateTime_Birthday.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTime_Birthday.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_Birthday.Location = new System.Drawing.Point(6, 31);
            this.dateTime_Birthday.Margin = new System.Windows.Forms.Padding(1);
            this.dateTime_Birthday.Name = "dateTime_Birthday";
            this.dateTime_Birthday.Size = new System.Drawing.Size(406, 32);
            this.dateTime_Birthday.TabIndex = 11;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBox_Name);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(26, 26);
            this.groupBox.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(418, 90);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Họ và Tên";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.Azure;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Name.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Name.Location = new System.Drawing.Point(4, 29);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(410, 32);
            this.textBox_Name.TabIndex = 4;
            this.textBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FCandidateInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tableLayoutPanel_Container);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FCandidateInfor";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.FCandidateInfor_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel_Container, 0);
            this.tableLayoutPanel_Container.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox_TrangThai.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Container;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.PictureBox pictureBox_Avatar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_Birthday;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.GroupBox groupBox4;
        private FinalProject.UC.UCComboBox ucComboBox_Gender;
        private System.Windows.Forms.RichTextBox richTextBox_ChuyenMon;
        private GroupBox groupBox8;
        private FinalProject.UC.UCComboBox ucComboBox_TrangThaiEmail;
        private GroupBox groupBox_TrangThai;
        private FinalProject.UC.UCComboBox ucComboBox_TrangThai;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_ChangeAvatar;
        private Button button_DoiMatKhau;
        private Button button_XacNhanEmail;
        private Button button_Save;
    }
}