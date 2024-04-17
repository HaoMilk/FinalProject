﻿using FinalProject.Admin;
using FinalProject.Common.GUI;
using FinalProject.Company.GUI;
using FinalProject.Company.GUI.Thong_tin;
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

namespace FinalProject.Company
{
    public partial class FCompanyHomePage : Form
    {
        private bool isAlwaysShowDashboard = true;
        public FCompanyHomePage()
        {
            InitializeComponent();
        }

        #region DanhSachViecLam
        private void ToolStripMenuItem_ChinhSuaCongViec_Click(object sender, EventArgs e)
        {
            this.OpenMenuDanhSachViecLam();
        }

        private void OpenMenuDanhSachViecLam()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FDSViecLam fDanhSachVL = new FDSViecLam();
            fDanhSachVL.ShowDialog();

            if (!isAlwaysShowDashboard) this.ShowDialog();
        }
        #endregion DanhSachViecLam
        #region DoiMatKhau
        private void menuItem_DoiMatKhau_Click(object sender, EventArgs e)
        {
            this.OpenDoiMatKhau();
        }

        private void ucMenuCard_DoiMatKhau_MenuClick(object sender, EventArgs e)
        {
            this.OpenDoiMatKhau();
        }

        private void OpenDoiMatKhau()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FDoiMatKhau fChangePassword = new FDoiMatKhau();
            fChangePassword.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion DoiMatKhau

        private void ucMenuCard_TaoViecLam_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FCreateJob fCreateJob = new FCreateJob();
            fCreateJob.ShowDialog();
            this.Show();
        }


        private void ucMenuCard_DangXuat_MenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucMenuCard_ThongTin_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FThongTinCongTy fThongTin = new FThongTinCongTy();
            fThongTin.ShowDialog();
            this.Show();
        }

        private void ucMenuCard_HSChuaDuyet_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FHSChuaDuyet fHSChuaDuyet = new FHSChuaDuyet();
            fHSChuaDuyet.ShowDialog();
            this.Show();

        }



        private void ucMenuCard_DSViecLam_MenuClick(object sender, EventArgs e)
        {
            this.OpenMenuDanhSachViecLam();
        }

        private void ucMenuCard_LichSuCongViec_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FDanhSachViecLam fDanhSachViecLam = new FDanhSachViecLam();
            fDanhSachViecLam.ShowDialog();
            this.Show();
        }
    }
}
