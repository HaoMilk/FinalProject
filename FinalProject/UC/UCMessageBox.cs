using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.UC
{
    public partial class UCMessageBox : UCForm
    {
        private const string DefaultTitle = "Thông báo";
        public DialogResult Result { get; set; }

        public enum MessageBoxButtons
        {
            YesNo,
            YesNoCancel,
            OK
        }

        public UCMessageBox()
        {
            InitializeComponent();

            this.button_Cancel.Visible = false;
            this.button_Yes.Visible = true;
            this.button_No.Visible = false;
        }

        public UCMessageBox(string message, string title = DefaultTitle, MessageBoxButtons messageBoxType = MessageBoxButtons.OK)
        {
            InitializeComponent();

            label_Message.Text = message;
            label_Title.Text = title;

            switch (messageBoxType)
            {
                case MessageBoxButtons.YesNo:
                    this.button_Cancel.Visible = false;
                    this.button_Yes.Visible = true;
                    this.button_No.Visible = true;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.button_Cancel.Visible = true;
                    this.button_Yes.Visible = true;
                    this.button_No.Visible = true;
                    break;
                case MessageBoxButtons.OK:
                    this.button_Cancel.Visible = false;
                    this.button_Yes.Visible = true;
                    this.button_No.Visible = false;
                    break;
            }
        }

        public static DialogResult Show(string message, string title = DefaultTitle, MessageBoxButtons messageBoxType = MessageBoxButtons.OK)
        {
            var messageBox = new UCMessageBox(message, title, messageBoxType);
            messageBox.TopMost = true;
            messageBox.BringToFront();
            messageBox.ShowDialog();
            return messageBox.Result;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.Close();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Yes;
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.No;
            this.Close();
        }
    }
}
