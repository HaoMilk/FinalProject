using FinalProject.Admin;
using FinalProject.Common;
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
    public partial class FCompanyHomePage : UCForm
    {
        private bool isAlwaysShowDashboard = true;
        public FCompanyHomePage()
        {
            InitializeComponent();
        }

        private void ucMenuCard_DoiMatKhau_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FDoiMatKhau fChangePassword = new FDoiMatKhau();
            fChangePassword.ShowDialog();
            this.Show();
        }


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
            fThongTin.Id = LoggedUser.CongTy.ID;
            fThongTin.ShowDialog();
            this.Show();
        }

        private void ucMenuCard_HSChuaDuyet_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FHoSoUT fHSChuaDuyet = new FHoSoUT();
            fHSChuaDuyet.ShowDialog();
            this.Show();

        }

        private void ucMenuCard_DSViecLam_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FDanhSachViecLam fDanhSachViecLam = new FDanhSachViecLam();
            fDanhSachViecLam.ShowDialog();
            this.Show();
        }

        private void ucMenuCard_DSUngVien_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FTimUngVien fTimUngVien = new FTimUngVien();
            fTimUngVien.ShowDialog();
            this.Show();
        }
    }
}