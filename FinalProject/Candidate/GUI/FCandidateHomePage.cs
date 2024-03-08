﻿using FinalProject.Common.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Candidate.GUI
{
    public partial class FCandidateHomePage : Form
    {
        public FCandidateHomePage()
        {
            InitializeComponent();
        }

        private void FCandidateHomePage_Load(object sender, EventArgs e)
        {

        }

        private void menu_TrangCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void menu_CongTy_Click(object sender, EventArgs e)
        {

        }

        private void menu_HoSo_Click(object sender, EventArgs e)
        {

        }

        private void menu_ViecLam_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FCandidateInfor fCandidateInfor = new FCandidateInfor();
            fCandidateInfor.ShowDialog();
        }

        private void menuItem_DoiMatKhau_Click(object sender, EventArgs e)
        {
            FChangePassword fChangePassword = new FChangePassword();
            fChangePassword.ShowDialog();
        }

        private void menuItem_QlyCv_Click(object sender, EventArgs e)
        {
            FQlyCv fQlyCv = new FQlyCv();
            fQlyCv.ShowDialog();
        }

        private void menuItem_MauCv_Click(object sender, EventArgs e)
        {
            FMauCv fMauCv = new FMauCv();
            fMauCv.ShowDialog();
        }

        private void menuItem_DangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuItem_Dsvl_Click(object sender, EventArgs e)
        {
            FDanhSachVL_Name fDanhSachVL = new FDanhSachVL_Name();
            fDanhSachVL.ShowDialog();
        }
    }
}
