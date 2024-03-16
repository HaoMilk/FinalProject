using FinalProject.Candidate.GUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace FinalProject.UC
{
    public partial class UCJobCard : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button menu")]
        public event EventHandler MenuClick;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button view")]
        public event EventHandler ViewClick;

        private Size defaultCardSize = new Size(300, 250);

        #region Fields
        private int id;
        private string jobName;
        private DateTime lastUpdatedTime;

        private Color buttonViewBackground = Color.Cornsilk;
        private Color buttonMenuBackground = Color.LightCyan;
        private Color jobNameTextColor = SystemColors.Highlight;
        private Color lastUpdatedTimeTextColor = Color.Navy;
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
        [DisplayName("Job Name")]
        public string JobName
        {
            get { return jobName; }
            set
            {
                if (value == null)
                {
                    value = "Job Name";
                }
                jobName = value;
                this.label_CvName.Text = jobName;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
        [DisplayName("Last Updated Time")]
        public DateTime LastUpdatedTime
        {
            get { return lastUpdatedTime; }
            set
            {
                if (value == null)
                {
                    value = DateTime.Now;
                }
                lastUpdatedTime = value;
                this.label_UpdatedTime.Text = lastUpdatedTime.ToString("dd/MM/yyyy");
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
                if (value == null)
                {
                    value = Color.Cornsilk;
                }
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
                if (value == null)
                {
                    value = Color.Azure;
                }
                buttonMenuBackground = value;
                this.button_Menu.BackColor = buttonMenuBackground;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("JobNameTextColor")]
        public Color JobNameTextColor
        {
            get { return jobNameTextColor; }
            set
            {
                if (value == null)
                {
                    value = Color.RoyalBlue;
                }
                jobNameTextColor = value;
                this.label_CvName.ForeColor = jobNameTextColor;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        [DisplayName("LastUpdatedTimeTextColor")]
        public Color LastUpdatedTimeTextColor
        {
            get { return lastUpdatedTimeTextColor; }
            set
            {
                if (value == null)
                {
                    value = Color.RoyalBlue;
                }
                lastUpdatedTimeTextColor = value;
                this.label_UpdatedTime.ForeColor = lastUpdatedTimeTextColor;
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
            if (ViewClick != null)
            {
                ViewClick(this, e);
            }
            else
            {
                //MessageBox.Show($"View id = {id}");

                FChiTietCv fChiTietCv = new FChiTietCv();
                fChiTietCv.Id = id;
                fChiTietCv.CvName = jobName;
                fChiTietCv.CvUpdatedTime = lastUpdatedTime;
                fChiTietCv.ShowDialog();
            }
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            if (MenuClick != null)
            {
                MenuClick(this, e);
            }
            else
            {
                MessageBox.Show($"Menu id = {id}");
            }
        }
    }
}
