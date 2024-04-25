using FinalProject.Candidate.GUI;
using FinalProject.Common.Helper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
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
        private int borderRadious = 20;
        private Color menuBackColor = Color.Azure;
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
                // this.Invalidate();
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
                // this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Color MenuBackColor
        {
            get { return menuBackColor; }
            set
            {
                if (value == null)
                {
                    value = Color.Azure;
                }
                menuBackColor = value;
                this.BackColor = menuBackColor;
                // this.Invalidate();
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
                // this.Invalidate();
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
                this.button_View.ForeColor = value;
                //this.button_View.FlatAppearance.BorderColor = value;
                // this.Invalidate();
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
                // this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public int BorderRadious { get => borderRadious; set => borderRadious = value; }
        #endregion Properties

        public UCMenuCard()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
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
            else
            {
                UCMessageBox.Show("Menu clicked");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            Rectangle gradientRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            Brush borderBrush = new LinearGradientBrush(gradientRectangle, this.buttonBackColor, this.buttonBackColor, 0.0f);
            Brush backgroundBrush = new LinearGradientBrush(gradientRectangle, this.menuBackColor, this.menuBackColor, 0.0f);

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            GuiHelper.FillRoundedRectangle(gradientRectangle, this.borderRadious, graphics, backgroundBrush, borderBrush);

            this.BackColor = Color.Transparent;
        }
    }
}
