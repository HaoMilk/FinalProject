using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Admin.GUI.XetDuyet
{
    public partial class FXetDuyet : Form
    {
        public FXetDuyet()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUngVien_Click(object sender, EventArgs e)
        {
            FXetDuyetUngVien fXetDuyetUngVien = new FXetDuyetUngVien();
            fXetDuyetUngVien.ShowDialog();
        }

        private void btnCongTy_Click(object sender, EventArgs e)
        {
            FXetDuyetCongTy fXetDuyetCongTy = new FXetDuyetCongTy();
            fXetDuyetCongTy.ShowDialog();
        }
    }
}
