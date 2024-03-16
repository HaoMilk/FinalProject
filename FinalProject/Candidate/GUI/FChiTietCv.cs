using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Candidate.GUI
{
    public partial class FChiTietCv : Form
    {
        private int id;
        private string cvName;
        private DateTime cvUpdatedTime;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                this.Invalidate();
            }
        }

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

        public DateTime CvUpdatedTime
        {
            get { return cvUpdatedTime; }
            set
            {
                cvUpdatedTime = value;
                this.Invalidate();
            }
        }

        public FChiTietCv()
        {
            InitializeComponent();
        }

        private void label_CvName_Click(object sender, EventArgs e)
        {

        }

        private void FChiTietCv_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
