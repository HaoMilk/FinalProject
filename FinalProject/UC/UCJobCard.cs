using FinalProject.Candidate.GUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.UC
{
    public partial class UCJobCard : UserControl
    {
        private Size defaultCardSize = new Size(300, 250);

        #region Fields
        private int id;
        private string cvName;
        private DateTime cvUpdatedTime;

        private Color buttonViewBackground = Color.Cornsilk;
        private Color buttonMenuBackground = Color.LightCyan;
        private Color labelCvNameTextColor = SystemColors.Highlight;
        private Color labelUpdatedTimeTextColor = Color.Navy;
        private Image bgImage;
        private Image buttonViewImage;
        private Image buttonMenuImage;
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
        [DisplayName("ID")]
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
        [DisplayName("CV Name")]
        public string CvName
        {
            get { return cvName; }
            set
            {
                cvName = value;
                this.label_CvName.Text = cvName;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
        [DisplayName("Updated Time")]
        public DateTime CvUpdatedTime
        {
            get { return cvUpdatedTime; }
            set
            {
                cvUpdatedTime = value;
                this.label_UpdatedTime.Text = cvUpdatedTime.ToString("dd/MM/yyyy");
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("BackColor View")]
        public Color ButtonViewBackground
        {
            get { return buttonViewBackground; }
            set
            {
                buttonViewBackground = value;
                this.button_View.BackColor = buttonViewBackground;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("BackColor Menu")]
        public Color ButtonMenuBackground
        {
            get { return buttonMenuBackground; }
            set
            {
                buttonMenuBackground = value;
                this.button_Menu.BackColor = buttonMenuBackground;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("TextColor CvName")]
        public Color LabelCvNameTextColor
        {
            get { return labelCvNameTextColor; }
            set
            {
                labelCvNameTextColor = value;
                this.label_CvName.ForeColor = labelCvNameTextColor;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("TextColor UpdatedTime")]
        public Color LabelUpdatedTimeTextColor
        {
            get { return labelUpdatedTimeTextColor; }
            set
            {
                labelUpdatedTimeTextColor = value;
                this.label_UpdatedTime.ForeColor = labelUpdatedTimeTextColor;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("Background Image")]
        public Image BgImage
        {
            get { return bgImage; }
            set
            {
                if (value == null)
                {
                    value = Properties.Resources.default_cv;
                }
                bgImage = value;
                this.BackgroundImage = bgImage;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("ButtonView Image")]
        public Image ButtonViewImage
        {
            get { return buttonViewImage; }
            set
            {
                if (value == null)
                {
                    value = Properties.Resources.icons8_view_96;
                }
                buttonViewImage = value;
                this.button_View.BackgroundImage = buttonViewImage;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("ButtonMenu Image")]
        public Image ButtonMenuImage
        {
            get { return buttonMenuImage; }
            set
            {
                if (value == null)
                {
                    value = Properties.Resources.icons8_menu_96;
                }
                buttonMenuImage = value;
                this.button_Menu.BackgroundImage = buttonMenuImage;
                this.Invalidate();
            }
        }
        #endregion Properties

        public UCJobCard()
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
            FChiTietCv fChiTietCv = new FChiTietCv(); 
            fChiTietCv.Id = id;
            fChiTietCv.CvName = cvName;
            fChiTietCv.CvUpdatedTime = cvUpdatedTime;
            fChiTietCv.ShowDialog();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Menu id = {id}");
        }
    }
}
