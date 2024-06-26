﻿using FinalProject.Common.BUS;
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

namespace FinalProject.Common.GUI
{
    public partial class FDatLaiMatKhau : UCForm
    {
        private UserBUS userBUS = new UserBUS();
        public FDatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var matKhauMoi = textBox_MatKhauMoi.Text;
            var nhapLaiMatKhau = textBox_NhapLaiMatKhau.Text;
            // Đặt lại mật khẩu mới và kiểm tra lại mật khẩu mới
            if (string.IsNullOrEmpty(matKhauMoi))
            {
                UCMessageBox.Show("Bạn chưa nhập mật khẩu mới");
                textBox_MatKhauMoi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                UCMessageBox.Show("Bạn chưa nhập lại mật khẩu");
                textBox_NhapLaiMatKhau.Focus();
                return;
            }
            if(matKhauMoi != nhapLaiMatKhau)
            {
                UCMessageBox.Show("Không trùng khớp mật khẩu mới!");
                textBox_NhapLaiMatKhau.Focus();
                return;
            }
            // Mã hóa mật khẩu bằng MD5;
            LoggedUser.User.Password = matKhauMoi.ToMD5();
            var result = userBUS.Update(LoggedUser.User); 
            if(result > 0)
            {
                UCMessageBox.Show("Lưu thành công!");
                this.Close();
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
    }
}
