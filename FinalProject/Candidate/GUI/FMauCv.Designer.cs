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
            this.richTextBox_Data = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Data
            // 
            this.richTextBox_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Data.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Data.Name = "richTextBox_Data";
            this.richTextBox_Data.Size = new System.Drawing.Size(1254, 628);
            this.richTextBox_Data.TabIndex = 0;
            this.richTextBox_Data.Text = "Hello World \nChào thế giới";
            // 
            // FMauCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 628);
            this.Controls.Add(this.richTextBox_Data);
            this.Name = "FMauCv";
            this.Text = "FMauCv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Data;
    }
}