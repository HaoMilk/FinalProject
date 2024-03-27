using FinalProject.Admin.GUI.CongTy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Admin
{
    public partial class FDanhSachCongTy : Form
    {
        public FDanhSachCongTy()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FChinhSuaCongTy fChinhSuaCongTy = new FChinhSuaCongTy();
            fChinhSuaCongTy.Show();
        }
    }
}
