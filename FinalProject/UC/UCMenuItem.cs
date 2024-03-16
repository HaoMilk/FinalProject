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
    public partial class UCMenuItem : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler MenuClick;

        private string menuName;
        private Image menuImage;
        private Color menuColor;
        private Color buttonBackColor;
        private Color buttonForeColor;

        [Category("CUSTOMIZE DATA")]
        public string MenuName
        {
            get { return menuName; }
            set
            {
                if (value == null)
                {
                    value = "Menu";
                }
                menuName = value;
                this.button.Text = menuName;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Image MenuImage
        {
            get { return menuImage; }
            set
            {
                if (value == null)
                {
                    value = Properties.Resources.job_search;
                }
                menuImage = value;
                this.pictureBox_MenuImage.BackgroundImage = menuImage;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Color MenuColor
        {
            get { return menuColor; }
            set
            {
                menuColor = value;
                this.BackColor = menuColor;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Color ButtonBackColor
        {
            get { return buttonBackColor; }
            set
            {
                if (value == null)
                {
                    value = Color.CadetBlue;
                }
                buttonBackColor = value;
                this.button.BackColor = buttonBackColor;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Color ButtonForeColor
        {
            get { return buttonForeColor; }
            set
            {
                if (value == null)
                {
                    value = Color.White;
                }
                buttonForeColor = value;
                this.button.ForeColor = buttonForeColor;
                this.Invalidate();
            }
        }
        public UCMenuItem()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (this.MenuClick != null)
            {
                this.MenuClick(this, e);
            }    
        }
    }
}
