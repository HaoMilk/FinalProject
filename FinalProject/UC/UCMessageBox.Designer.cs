namespace FinalProject.UC
{
    partial class UCMessageBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button_No, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Yes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Message, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 272);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_No
            // 
            this.button_No.BackColor = System.Drawing.Color.SteelBlue;
            this.button_No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_No.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_No.ForeColor = System.Drawing.SystemColors.Control;
            this.button_No.Location = new System.Drawing.Point(224, 222);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(106, 47);
            this.button_No.TabIndex = 2;
            this.button_No.Text = "Không";
            this.button_No.UseVisualStyleBackColor = false;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Yes
            // 
            this.button_Yes.BackColor = System.Drawing.Color.Chocolate;
            this.button_Yes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Yes.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Yes.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Yes.Location = new System.Drawing.Point(113, 222);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(105, 47);
            this.button_Yes.TabIndex = 1;
            this.button_Yes.Text = "Đồng ý";
            this.button_Yes.UseVisualStyleBackColor = false;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Cancel.Location = new System.Drawing.Point(3, 222);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(104, 47);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Huỷ";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.SetColumnSpan(this.label_Title, 3);
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Location = new System.Drawing.Point(3, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(327, 52);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Title";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_Message, 3);
            this.label_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Message.Location = new System.Drawing.Point(3, 62);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(327, 157);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "Message";
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(353, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCMessageBox";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Message;
    }
}
