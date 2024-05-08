using FinalProject.GUI.Candidate;
using FinalProject.Database.Entities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace FinalProject.UC
{
    public partial class UCCvCard : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks view CV")]
        public event EventHandler CvClick;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks delete CV")]
        public event EventHandler CvDelete;

        private Size defaultCardSize = new Size(300, 250);

        #region Fields
        private int id = 0;
        private string cvName;
        private DateTime lastUpdatedTime;

        private Color cvNameTextColor = SystemColors.Highlight;
        private Color lastUpdatedTimeTextColor = Color.Navy;
        private Image bgImage;
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
                // this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
        public string CvName
        {
            get { return cvName; }
            set
            {
                if (value == null)
                {
                    value = "CV Name";
                }
                cvName = value;
                this.label_CvName.Text = cvName;
                // this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
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
                // this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
        public Color CvNameTextColor
        {
            get { return cvNameTextColor; }
            set
            {
                if (value == null)
                {
                    value = Color.RoyalBlue;
                }
                cvNameTextColor = value;
                this.label_CvName.ForeColor = cvNameTextColor;
                // this.Invalidate();
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
                // this.Invalidate();
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
                // this.Invalidate();
            }
        }

        #endregion Properties

        public UCCvCard()
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
            if (CvClick != null)
            {
                CvClick(this, e);
            }
            else
            {
                FTaoCv fTaoCv = new FTaoCv();
                fTaoCv.Id = this.Id;
                fTaoCv.ShowDialog();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (CvDelete != null)
            {
                CvDelete(this, e);
            }
        }
    }
}
