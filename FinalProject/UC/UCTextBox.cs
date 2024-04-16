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
    public partial class UCTextBox : RichTextBox
    {
        public UCTextBox()
        {
            InitializeComponent();

            // Set default 1 line height and align middle center text
            this.Multiline = false;
            // align middle center text in the textbox 
            this.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
