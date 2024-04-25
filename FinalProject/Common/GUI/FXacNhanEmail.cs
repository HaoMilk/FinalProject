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
    public partial class FXacNhanEmail : UCForm
    {
        private UserBUS _userBUS = new UserBUS();
        public FXacNhanEmail()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            var otp = textBox_OTP.Text;
            var result = _userBUS.VerifyOtp(LoggedUser.User.Id, otp);
            if (result == true)
            {
                MessageBox.Show("Xác nhận email thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng");
            }
        }
    }
}
