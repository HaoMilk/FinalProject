using FinalProject.Admin;
using FinalProject.BUS;
using FinalProject.Common;
using FinalProject.Common.Const;
using FinalProject.GUI.Candidate;
using FinalProject.GUI.Common;
using FinalProject.GUI.Company;
using FinalProject.UC;
using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FDangNhap : UCForm
    {
        private UserBUS userBUS = new UserBUS();
        private UngVienBUS ungVienBUS = new UngVienBUS();
        private CongTyBUS congTyBUS = new CongTyBUS();

        public FDangNhap()
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
            var UserName = textBox_TenDangNhap.Text;
            var password = textBox_MatKhau.Text;

            if (radioButton__UngVien.Checked)
            {
                var user = userBUS.Login(UserName, password, UserRoleConst.Candidate);
                if (user == null)
                {
                    UCMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return;
                }

                // Đăng nhập thành công, lưu thông tin người dùng vào biến toàn cục
                LoggedUser.UserId = user.Id;
                LoggedUser.UserRole = UserRoleConst.Candidate;
                LoggedUser.User = user;
                LoggedUser.UngVien = ungVienBUS.GetByUserId(user.Id);

                this.Hide();
                FCandidateHomePage fCandidateHomePage = new FCandidateHomePage();
                fCandidateHomePage.ShowDialog();
                this.ClearData();
                this.Show();
            }
            else if (radioButton_Admin.Checked)
            {
                var user = userBUS.Login(UserName, password, UserRoleConst.Admin);
                if (user == null)
                {
                    UCMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
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
                var user = userBUS.Login(UserName, password, UserRoleConst.Employer);
                if (user == null)
                {
                    UCMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
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
            textBox_TenDangNhap.Focus();
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FQuenMatKhau fQuenMatKhau = new FQuenMatKhau();
            fQuenMatKhau.ShowDialog();
            this.Show();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (String.IsNullOrEmpty(textBox_TenDangNhap.Text) || String.IsNullOrEmpty(textBox_MatKhau.Text))
            {
                UCMessageBox.Show("Vui lòng nhập đủ thông tin UserName / Password !");
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
