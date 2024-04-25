using FinalProject.Common.BUS;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Common.GUI
{
    public partial class FDoiMatKhau : UCForm
    {
        private UserBUS userBUS = new UserBUS();
        public FDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var matKhauCu = textBox_MatKhauCu.Text;
            var matKhauMoi = textBox_MatKhauMoi.Text;
            var nhapLaiMatKhau = textBox_NhapLaiMatKhau.Text;
            if(string.IsNullOrEmpty(matKhauCu))
            {
                UCMessageBox.Show("Bạn chưa nhập mật khẩu cũ");
                return;
            }
            if (string.IsNullOrEmpty(matKhauMoi))
               
            {
                UCMessageBox.Show("Bạn chưa nhập mật khẩu mới");
                return;
            }
            if (string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                UCMessageBox.Show("Bạn chưa nhập lại mật khẩu");
                return;
            }
            if (matKhauCu != LoggedUser.User.Password)
            {
                UCMessageBox.Show("Sai mật khẩu! Vui lòng nhập lại.");
                return;
            }
            if(matKhauMoi == matKhauCu)
            {
                UCMessageBox.Show("Trùng mật khẩu cũ! Vui lòng nhập lại.");
                return;
            }
            if(matKhauMoi != nhapLaiMatKhau)
            {
                UCMessageBox.Show("Không trùng khớp mật khẩu mới!");
                return;
            }

            LoggedUser.User.Password = matKhauMoi;
            var result = userBUS.Update(LoggedUser.User); 
            if(result > 0)
            {
                UCMessageBox.Show("Lưu thành công!");
            }
            else
            {
                UCMessageBox.Show("Lưu thất bại!");
            }
        }

        private void FChangePassword_Load(object sender, EventArgs e)
        {
            textBox_TenDangNhap.Text = LoggedUser.User.Username;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
