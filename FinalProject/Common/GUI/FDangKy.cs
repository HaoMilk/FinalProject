using FinalProject.Admin;
using FinalProject.Candidate.GUI;
using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Const;
using FinalProject.Company;
using FinalProject.Company.GUI.Thong_tin;
using FinalProject.Database.Entities;
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

namespace FinalProject
{
    public partial class FDangKy : UCForm
    {
        private UserBUS userBUS = new UserBUS();
        private UngVienBUS ungVienBUS = new UngVienBUS();
        private CongTyBUS congTyBUS = new CongTyBUS();

        public FDangKy()
        {
            InitializeComponent();
            //this.textBox_TenDangNhap.Text = "test";
            //this.textBox_MatKhau.Text = "123456";
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }

            // Kiểm tra thông tin đăng nhập
            var username = textBox_TenDangNhap.Text;
            var password = textBox_MatKhau.Text;

            if (radioButton__UngVien.Checked)
            {
                var result = userBUS.Signup(username, password, UserRoleConst.Candidate);
                if (result > 0)
                {
                    UCMessageBox.Show("Bạn đã đăng ký thành công, vui lòng đăng nhập!");
                    this.Close();
                }              
            }
            //else if(radioButton_Admin.Checked)
            //{
            //    var result = userBUS.Signup(username, password, UserRoleConst.Admin);
            //    if (result > 0)
            //    {
            //        UCMessageBox.Show("Bạn đã đăng ký thành công, vui lòng đăng nhập!");
            //        this.Close();
            //    }              
            //}    
            else if (radioButton_NhaTuyenDung.Checked)
            {
                var result = userBUS.Signup(username, password, UserRoleConst.Employer);
                if (result > 0)
                {
                    UCMessageBox.Show("Bạn đã đăng ký thành công, vui lòng đăng nhập!");
                    this.Close();
                }
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCMessageBox.Show("Quên mật khẩu");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (String.IsNullOrEmpty(textBox_TenDangNhap.Text) || String.IsNullOrEmpty(textBox_MatKhau.Text))
            {
                UCMessageBox.Show("Vui lòng nhập đủ thông tin Username / Password !");
                return false;
            }    
            return true;
        }

        private void linkLabel_DangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
