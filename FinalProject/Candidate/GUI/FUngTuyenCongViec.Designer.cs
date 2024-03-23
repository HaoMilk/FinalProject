namespace FinalProject.Candidate.GUI
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_JobName = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_TenUngVien = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_TenCongTy = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_TenCongViec = new System.Windows.Forms.TextBox();
            this.groupBox_MoTa = new System.Windows.Forms.GroupBox();
            this.richTextBox_MoTa = new System.Windows.Forms.RichTextBox();
            this.ucComboBox_Cv = new FinalProject.UC.UCComboBox();
            this.panel_Top.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_MoTa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(20, 20);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel_Top.Size = new System.Drawing.Size(760, 40);
            this.panel_Top.TabIndex = 6;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::FinalProject.Properties.Resources.icons8_close_96;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(716, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(44, 30);
            this.button_Close.TabIndex = 1;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_JobName
            // 
            this.label_JobName.BackColor = System.Drawing.Color.Goldenrod;
            this.label_JobName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_JobName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JobName.ForeColor = System.Drawing.SystemColors.Control;
            this.label_JobName.Location = new System.Drawing.Point(20, 60);
            this.label_JobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_JobName.Name = "label_JobName";
            this.label_JobName.Size = new System.Drawing.Size(760, 39);
            this.label_JobName.TabIndex = 7;
            this.label_JobName.Text = "CÔNG VIỆC";
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
            this.button_Submit.Location = new System.Drawing.Point(20, 459);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(760, 47);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 164);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_TenUngVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(374, 75);
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
            this.textBox_TenUngVien.Location = new System.Drawing.Point(10, 33);
            this.textBox_TenUngVien.Name = "textBox_TenUngVien";
            this.textBox_TenUngVien.Size = new System.Drawing.Size(354, 30);
            this.textBox_TenUngVien.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ucComboBox_Cv);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(383, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(374, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_TenCongTy);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(374, 75);
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
            this.textBox_TenCongTy.Location = new System.Drawing.Point(10, 33);
            this.textBox_TenCongTy.Name = "textBox_TenCongTy";
            this.textBox_TenCongTy.Size = new System.Drawing.Size(354, 30);
            this.textBox_TenCongTy.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_TenCongViec);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(383, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(374, 75);
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
            this.textBox_TenCongViec.Location = new System.Drawing.Point(10, 33);
            this.textBox_TenCongViec.Name = "textBox_TenCongViec";
            this.textBox_TenCongViec.Size = new System.Drawing.Size(354, 30);
            this.textBox_TenCongViec.TabIndex = 1;
            // 
            // groupBox_MoTa
            // 
            this.groupBox_MoTa.Controls.Add(this.richTextBox_MoTa);
            this.groupBox_MoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_MoTa.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MoTa.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_MoTa.Location = new System.Drawing.Point(20, 263);
            this.groupBox_MoTa.Name = "groupBox_MoTa";
            this.groupBox_MoTa.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_MoTa.Size = new System.Drawing.Size(760, 196);
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
            this.richTextBox_MoTa.Location = new System.Drawing.Point(10, 35);
            this.richTextBox_MoTa.Name = "richTextBox_MoTa";
            this.richTextBox_MoTa.Size = new System.Drawing.Size(740, 151);
            this.richTextBox_MoTa.TabIndex = 0;
            this.richTextBox_MoTa.Text = "";
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
            this.ucComboBox_Cv.ItemHeight = 26;
            this.ucComboBox_Cv.Items = new FinalProject.UC.ComboBoxItem[0];
            this.ucComboBox_Cv.Location = new System.Drawing.Point(10, 33);
            this.ucComboBox_Cv.Name = "ucComboBox_Cv";
            this.ucComboBox_Cv.Size = new System.Drawing.Size(354, 32);
            this.ucComboBox_Cv.TabIndex = 0;
            // 
            // FUngTuyenCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.groupBox_MoTa);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_JobName);
            this.Controls.Add(this.panel_Top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUngTuyenCongViec";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUngTuyenCongViec";
            this.Load += new System.EventHandler(this.FUngTuyenCongViec_Load);
            this.panel_Top.ResumeLayout(false);
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

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Close;
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