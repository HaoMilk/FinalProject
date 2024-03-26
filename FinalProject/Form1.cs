using FinalProject.Admin;
using FinalProject.Candidate.GUI;
using FinalProject.Company;
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
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();
            if (radioButton__UngVien.Checked)
            {
                FCandidateHomePage fCandidateHomePage = new FCandidateHomePage();
                fCandidateHomePage.ShowDialog();
            }
            else if(radioButton_Admin.Checked)
            {
                FAdminHomePage fAdminHomePage = new FAdminHomePage();
                fAdminHomePage.ShowDialog();
            }    
            else if (radioButton_NhaTuyenDung.Checked)
            {
                FCompanyHomePage fCompanyHomePage = new FCompanyHomePage();
                fCompanyHomePage.ShowDialog();
            }

            // Show lại
            this.Show();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Đăng ký thành công");
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
    }
}
