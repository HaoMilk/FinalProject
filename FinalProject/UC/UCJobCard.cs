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
        public Color ButtonMenuBackground
        {
            get { return buttonMenuBackground; }
            set
            {
                buttonMenuBackground = value;
                this.button_menu.BackColor = buttonMenuBackground;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE UI")]
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
        [DisplayName("TextColor for label UpdatedTime")]
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
            MessageBox.Show($"View id = {id}");
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Menu id = {id}");
        }
    }
}
