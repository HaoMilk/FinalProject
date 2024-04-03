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
    public partial class FThongTin : Form
    {
        CongTyBUS cty_BUS = new CongTyBUS();
        public FThongTin()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            var PassWord = textBox_Pass.Text;
            var Email = textBox_Email.Text;
            var MST = textBox_TenCTy.Text;
            var Ten = textBox_ID.Text;
            var DiaChi = textBox_Pass.Text;
            var TenCEO = textBox_Email.Text;
            cty_BUS.Add(ID, PassWord, Email, Ten, DiaChi, TenCEO, MST);
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            var PassWord = textBox_Pass.Text;
            var Email = textBox_Email.Text;
            var MST = textBox_TenCTy.Text;
            var Ten = textBox_ID.Text;
            var DiaChi = textBox_Pass.Text;
            var TenCEO = textBox_Email.Text;
            cty_BUS.Update(ID, PassWord, Email, Ten, DiaChi, TenCEO, MST);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
