using FinalProject.Common.Helper;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.UC
{
    public partial class UCCtyCard : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ViewClick;

        private int id;
        private CongTy congTy;

        [Category("CUSTOMIZE DATA")]
        public int Id
        {
            get => id;
            set => id = value;
        }

        [Category("CUSTOMIZE DATA")]
        public CongTy CongTy
        {
            get => congTy;
            set
            {
                congTy = value;
                // this.Invalidate();
            }
        }

        public UCCtyCard()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            if (ViewClick != null)
            {
                ViewClick(this, e);
            }
            else
            {
                UCMessageBox.Show($"Cty {id}");
            }
        }

        private void UCCtyCard_Load(object sender, EventArgs e)
        {
            if (congTy != null)
            {
                label_Name.Text = congTy.TenCongTy;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            Rectangle gradientRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            Brush borderBrush = new LinearGradientBrush(gradientRectangle, Color.DarkOrange, Color.DarkOrange, 0.0f);
            Brush backgroundBrush = new LinearGradientBrush(gradientRectangle, Color.Azure, Color.Azure, 0.0f);

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            GuiHelper.FillRoundedRectangle(gradientRectangle, 20, graphics, backgroundBrush, borderBrush);

            this.BackColor = Color.Transparent;
        }
    }
}
