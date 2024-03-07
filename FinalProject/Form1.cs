using FinalProject.Candidate.GUI;
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
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            FCandidateHomePage fCandidateHomePage = new FCandidateHomePage();
            fCandidateHomePage.ShowDialog();

            // Show lại
            this.Show();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Đăng ký thành công");
        }
    }
}
