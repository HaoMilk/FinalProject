namespace FinalProject.UC
{
    partial class UCPagination
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
            this.tableLayoutPanel_Pagination = new System.Windows.Forms.TableLayoutPanel();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.label_CurrentPage = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Pagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Pagination
            // 
            this.tableLayoutPanel_Pagination.ColumnCount = 3;
            this.tableLayoutPanel_Pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Pagination.Controls.Add(this.button_Previous, 0, 0);
            this.tableLayoutPanel_Pagination.Controls.Add(this.button_Next, 2, 0);
            this.tableLayoutPanel_Pagination.Controls.Add(this.label_CurrentPage, 1, 0);
            this.tableLayoutPanel_Pagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Pagination.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Pagination.Name = "tableLayoutPanel_Pagination";
            this.tableLayoutPanel_Pagination.RowCount = 1;
            this.tableLayoutPanel_Pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Pagination.Size = new System.Drawing.Size(500, 50);
            this.tableLayoutPanel_Pagination.TabIndex = 9;
            // 
            // button_Previous
            // 
            this.button_Previous.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Previous.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Previous.FlatAppearance.BorderSize = 5;
            this.button_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Previous.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Previous.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Previous.Image = global::FinalProject.Properties.Resources.icons8_previous_48;
            this.button_Previous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Previous.Location = new System.Drawing.Point(3, 0);
            this.button_Previous.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(160, 50);
            this.button_Previous.TabIndex = 1;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = false;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Next.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Next.FlatAppearance.BorderSize = 5;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Next.Image = global::FinalProject.Properties.Resources.icons8_last_48;
            this.button_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Next.Location = new System.Drawing.Point(335, 0);
            this.button_Next.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(162, 50);
            this.button_Next.TabIndex = 0;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // label_CurrentPage
            // 
            this.label_CurrentPage.AutoSize = true;
            this.label_CurrentPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_CurrentPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CurrentPage.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentPage.ForeColor = System.Drawing.SystemColors.Control;
            this.label_CurrentPage.Location = new System.Drawing.Point(169, 0);
            this.label_CurrentPage.Name = "label_CurrentPage";
            this.label_CurrentPage.Size = new System.Drawing.Size(160, 50);
            this.label_CurrentPage.TabIndex = 2;
            this.label_CurrentPage.Text = "0 / 0";
            this.label_CurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_Pagination);
            this.Name = "UCPagination";
            this.Size = new System.Drawing.Size(500, 50);
            this.tableLayoutPanel_Pagination.ResumeLayout(false);
            this.tableLayoutPanel_Pagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Pagination;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label label_CurrentPage;
    }
}
