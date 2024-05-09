using FinalProject.Common;
using FinalProject.GUI.Common;
using System;
using System.Windows.Forms;

namespace FinalProject.GUI.Company
{
    public partial class FCompanyHomePage : Form
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

        private void ucMenuCard_LichSuCongViec_MenuClick(object sender, EventArgs e)
        {

        }
    }
}