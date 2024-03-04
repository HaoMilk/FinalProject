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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
