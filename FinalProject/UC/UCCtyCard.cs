using FinalProject.Company.GUI.Thong_tin;
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
    public partial class UCCtyCard : UserControl
    {
        private int id;
        private string name;
        private string address;

        public int Id
        {
            get => id;
            set => id = value;
        }

        [Category("CUSTOMIZE DATA")]
        public string Name
        {
            get => name;
            set
            {
                if (value == null)
                {
                    value = "Công ty";
                }
                name = value;
                label_Name.Text = name;
                this.Invalidate();
            }
        }

        [Category("CUSTOMIZE DATA")]
        public string Address
        {
            get => address;
            set
            {
                if (value == null)
                {
                    value = "Địa chỉ công ty";
                }
                address = value;
                this.Invalidate();
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
            FThongTinCongTy fThongTinCongTy = new FThongTinCongTy();
            fThongTinCongTy.Id = id;
            fThongTinCongTy.ShowDialog();
        }
    }
}
