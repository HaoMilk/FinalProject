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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.Company.GUI.Thong_tin
{
    public partial class FThongTinCongTy : Form
    {
        CongTyBUS cty_BUS = new CongTyBUS();
        public FThongTinCongTy()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            var Email = textBox_Email.Text;
            var MST = textBox_MST.Text;
            var Ten = textBox_TenCTy.Text;
            var DiaChi = textBox_DiaChi.Text;
            var TenCEO = textBox_CEO.Text;
            cty_BUS.Add(ID, Email, Ten, DiaChi, TenCEO, MST);
            MessageBox.Show("Thêm thành công");
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            var Email = textBox_Email.Text;
            var MST = textBox_MST.Text;
            var Ten = textBox_TenCTy.Text;
            var DiaChi = textBox_DiaChi.Text;
            var TenCEO = textBox_CEO.Text;
            cty_BUS.Update(ID, Email, Ten, DiaChi, TenCEO, MST);
            MessageBox.Show("Cập nhật thành công");
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            cty_BUS.Delete(ID);
            MessageBox.Show("Xoá thành công");

        }
    }
}
