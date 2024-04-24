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
    public partial class Form_DangNhap : UCForm
    {
        private UserBUS userBUS = new UserBUS();
        private UngVienBUS ungVienBUS = new UngVienBUS();
        private CongTyBUS congTyBUS = new CongTyBUS();

        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            textBox_TenDangNhap.Text = "";
            textBox_MatKhau.Text = "";
            radioButton__UngVien.Checked = true;
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
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
                var user = userBUS.Login(username, password, UserRoleConst.Candidate);
                if (user == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return;
                }

                // Đăng nhập thành công, lưu thông tin người dùng vào biến toàn cục
                LoggedUser.UserId = user.Id;
                LoggedUser.UserRole = UserRoleConst.Candidate;
                LoggedUser.User = user;
                LoggedUser.UngVien = ungVienBUS.GetByUserId(user.Id);

                if (user.IsEmailVerified == false)
                {
                    userBUS.SendOtpVerifyEmail(user);
                }

                this.Hide();
                FCandidateHomePage fCandidateHomePage = new FCandidateHomePage();
                fCandidateHomePage.ShowDialog();
                this.ClearData();
                this.Show();
            }
            else if(radioButton_Admin.Checked)
            {
                var user = userBUS.Login(username, password, UserRoleConst.Admin);
                if (user == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return;
                }

                // Đăng nhập thành công, lưu thông tin người dùng vào biến toàn cục
                LoggedUser.UserId = user.Id;
                LoggedUser.UserRole = UserRoleConst.Admin;
                LoggedUser.User = user;

                this.Hide();
                FAdminHomePage fAdminHomePage = new FAdminHomePage();
                fAdminHomePage.ShowDialog();
                this.ClearData();
                this.Show();
            }    
            else if (radioButton_NhaTuyenDung.Checked)
            {
                var user = userBUS.Login(username, password, UserRoleConst.Employer);
                if (user == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return;
                }

                // Đăng nhập thành công, lưu thông tin người dùng vào biến toàn cục
                LoggedUser.UserId = user.Id;
                LoggedUser.UserRole = UserRoleConst.Employer;
                LoggedUser.User = user;
                LoggedUser.CongTy = congTyBUS.GetByUserId(user.Id);

                this.Hide();
                FCompanyHomePage fCompanyHomePage = new FCompanyHomePage();
                fCompanyHomePage.ShowDialog();
                this.ClearData();
                this.Show();
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Quên mật khẩu");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (String.IsNullOrEmpty(textBox_TenDangNhap.Text) || String.IsNullOrEmpty(textBox_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin Username / Password !");
                return false;
            }    
            return true;
        }

        private void linkLabel_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangKy fDangKy = new FDangKy();
            fDangKy.ShowDialog();
            this.Show();
        }

        private void Form_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_DangNhap_Click(sender, e);
            }
        }

        private void textBox_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_DangNhap_Click(sender, e);
            }
        }
    }
}
