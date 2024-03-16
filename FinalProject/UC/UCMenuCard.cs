using FinalProject.Candidate.GUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.UC
{
    public partial class UCMenuCard : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler MenuClick;

        private Size defaultCardSize = new Size(200, 150);

        #region Fields
        private int id;
        private string menuName;
        private Color buttonBackColor = Color.Cornsilk;
        private Color buttonTextColor = Color.RoyalBlue;
        private Image menuImage;
        #endregion Fields

        #region Properties
        public Size CardSize
        {
            get { return this.Size; }
        }

        public Size DefaultCardSize
        {
            get { return defaultCardSize; }
        }

        [Category("CUSTOMIZE DATA")]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                this.Invalidate();
            }
        }

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
                this.button_View.Text = menuName;
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
                    value = Color.Cornsilk;
                }
                buttonBackColor = value;
                this.button_View.BackColor = buttonBackColor;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Color ButtonTextColor
        {
            get { return buttonTextColor; }
            set
            {
                if (value == null)
                {
                    value = Color.RoyalBlue;
                }
                buttonTextColor = value;
                this.button_View.ForeColor = buttonTextColor;
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
                this.pictureBox_Image.BackgroundImage = menuImage;
                this.Invalidate();
            }
        }
        #endregion Properties

        public UCMenuCard()
        {
            InitializeComponent();
        }

        public Size ScaleSize(float scale)
        {
            var size = new Size((int)(defaultCardSize.Width * scale), (int)(defaultCardSize.Height * scale));
            this.Size = size;
            return size;
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            if (MenuClick != null)
            {
                MenuClick(this, e);
            }
        }
    }
}
