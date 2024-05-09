using FinalProject.Common;
using FinalProject.BUS;
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
    public partial class FXacNhanEmail : UCForm
    {
        public bool Result {  get; set; }
        private UserBUS _userBUS = new UserBUS();
        public FXacNhanEmail()
        {
            InitializeComponent();
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            var otp = textBox_OTP.Text;
            var result = _userBUS.VerifyOtp(LoggedUser.User.Id, otp);
            this.Result = result;
            if (result == true)
            {
                UCMessageBox.Show("Xác nhận email thành công");
                this.Close();
            }
            else
            {
                UCMessageBox.Show("Mã OTP không đúng");
            }
        }
    }
}
