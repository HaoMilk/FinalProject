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
    public partial class FDsCv : Form
    {
        public FDsCv()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void FDsCv_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {

        }
    }
}
