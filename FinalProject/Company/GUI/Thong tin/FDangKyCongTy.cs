using FinalProject.Common.BUS;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Company.GUI.Thong_tin
{
    public partial class FDangKyCongTy : Form
    {
        private CongTyBUS cty_BUS = new CongTyBUS();
        public FDangKyCongTy()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            string MST = textBox_MST.Text;
            string Ten = textBox_TenCTy.Text;
            string DiaChi = textBox_DiaChi.Text;
            string TenCEO = textBox_CEO.Text;
            cty_BUS.Add(MST, Ten, DiaChi, TenCEO);
        }
    }
}
