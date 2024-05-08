using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Helper;
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

namespace FinalProject.GUI.Common
{
    public partial class FQuenMatKhau : UCForm
    {
        private UserBUS userBUS = new UserBUS();
        public FQuenMatKhau()
        {
            InitializeComponent();
        }

        private void button_LayMatKhau_Click(object sender, EventArgs e)
        {
            var email = textBox_Email.Text;
            if(email.Contains("@")==false)
            {
                UCMessageBox.Show("Email không hợp lệ !");
                return;
            }
            var user = userBUS.GetUserByEmail(email);
            if(user == null)
            {
                UCMessageBox.Show("Người dùng không tồn tại!");
            }
            else
            {
                // Lưu thông tin user vào trong loggeduser;
                LoggedUser.User = user;

                // Gửi otp đến email user
                var output = userBUS.SendOtpVerifyEmail(user, "Xác thực tài khoản");
                // Gủi otp thành công thì mở form để người dùng nhập otp;
                if(output != null && output.IsSuccess)
                {
                    this.Hide();
                    FXacNhanEmail fXacNhanEmail = new FXacNhanEmail();
                    fXacNhanEmail.ShowDialog();

                    if(fXacNhanEmail.Result == true )
                    {

                        FDatLaiMatKhau fDatLaiMatKhau = new FDatLaiMatKhau();
                        fDatLaiMatKhau.ShowDialog();
                        
                    }
      
                }


            }
        }
    }
}
