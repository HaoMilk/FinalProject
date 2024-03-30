using FinalProject.Common.BUS;
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
    public partial class FThongTin : Form
    {
        CongTyBUS cty_BUS = new CongTyBUS();
        public FThongTin()
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

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            string MST = textBox_MST.Text;
            string Ten = textBox_TenCTy.Text;
            string DiaChi = textBox_DiaChi.Text;
            string TenCEO = textBox_CEO.Text;
            cty_BUS.Edit(MST, Ten, DiaChi, TenCEO);
        }
    }
}
