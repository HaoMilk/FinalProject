namespace FinalProject.Candidate.GUI
{
    partial class FMauCv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMauCv));
            this.richTextBox_Data = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dev01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dev02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tester01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tester02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Data
            // 
            this.richTextBox_Data.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Data.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Data.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.richTextBox_Data.Location = new System.Drawing.Point(0, 82);
            this.richTextBox_Data.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.richTextBox_Data.Name = "richTextBox_Data";
            this.richTextBox_Data.Size = new System.Drawing.Size(976, 537);
            this.richTextBox_Data.TabIndex = 0;
            this.richTextBox_Data.Text = "Hello World \nChào thế giới";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.menuStrip1.Font = new System.Drawing.Font("Constantia", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolStripMenuItem,
            this.testerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(976, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dev01ToolStripMenuItem,
            this.dev02ToolStripMenuItem});
            this.developerToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.developerToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.developerToolStripMenuItem.Image = global::FinalProject.Properties.Resources.dev_24;
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // dev01ToolStripMenuItem
            // 
            this.dev01ToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.dev01ToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.dev01ToolStripMenuItem.Image = global::FinalProject.Properties.Resources.angular;
            this.dev01ToolStripMenuItem.Name = "dev01ToolStripMenuItem";
            this.dev01ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.dev01ToolStripMenuItem.Text = "Dev01";
            this.dev01ToolStripMenuItem.Click += new System.EventHandler(this.dev01ToolStripMenuItem_Click);
            // 
            // dev02ToolStripMenuItem
            // 
            this.dev02ToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.dev02ToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.dev02ToolStripMenuItem.Image = global::FinalProject.Properties.Resources.csharp;
            this.dev02ToolStripMenuItem.Name = "dev02ToolStripMenuItem";
            this.dev02ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.dev02ToolStripMenuItem.Text = "Dev02";
            this.dev02ToolStripMenuItem.Click += new System.EventHandler(this.dev02ToolStripMenuItem_Click);
            // 
            // testerToolStripMenuItem
            // 
            this.testerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tester01ToolStripMenuItem,
            this.tester02ToolStripMenuItem});
            this.testerToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.testerToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.testerToolStripMenuItem.Image = global::FinalProject.Properties.Resources.tester_female_24;
            this.testerToolStripMenuItem.Name = "testerToolStripMenuItem";
            this.testerToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.testerToolStripMenuItem.Text = "Tester";
            // 
            // tester01ToolStripMenuItem
            // 
            this.tester01ToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.tester01ToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.tester01ToolStripMenuItem.Image = global::FinalProject.Properties.Resources.bug;
            this.tester01ToolStripMenuItem.Name = "tester01ToolStripMenuItem";
            this.tester01ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.tester01ToolStripMenuItem.Text = "Tester01";
            this.tester01ToolStripMenuItem.Click += new System.EventHandler(this.tester01ToolStripMenuItem_Click);
            // 
            // tester02ToolStripMenuItem
            // 
            this.tester02ToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.tester02ToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.tester02ToolStripMenuItem.Image = global::FinalProject.Properties.Resources.react;
            this.tester02ToolStripMenuItem.Name = "tester02ToolStripMenuItem";
            this.tester02ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.tester02ToolStripMenuItem.Text = "Tester02";
            this.tester02ToolStripMenuItem.Click += new System.EventHandler(this.tester02ToolStripMenuItem_Click);
            // 
            // FMauCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(976, 619);
            this.Controls.Add(this.richTextBox_Data);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMauCv";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Mẫu CV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.richTextBox_Data, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dev01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dev02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tester01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tester02ToolStripMenuItem;
    }
}