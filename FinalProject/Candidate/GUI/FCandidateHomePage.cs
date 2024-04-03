using FinalProject.Common.GUI;
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

namespace FinalProject.Candidate.GUI
{
    public partial class FCandidateHomePage : UCForm
    {
        private bool isAlwaysShowDashboard = true;

        public FCandidateHomePage()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void FCandidateHomePage_Load(object sender, EventArgs e)
        {

        }

        #region ThongTinCaNhan
        private void menuItem_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.OpenThongTinCaNhan();
        }

        private void ucMenuCard_ThongTin_MenuClick(object sender, EventArgs e)
        {
            this.OpenThongTinCaNhan();
        }

        private void OpenThongTinCaNhan()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FCandidateInfor fCandidateInfor = new FCandidateInfor();
            fCandidateInfor.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion ThongTinCaNhan

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

        #region DanhSachCV
        private void menuItem_QlyCv_Click(object sender, EventArgs e)
        {
            this.OpenDanhSachCV();
        }

        private void ucMenuCard_DsCV_MenuClick(object sender, EventArgs e)
        {
            this.OpenDanhSachCV();
        }

        private void OpenDanhSachCV()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FQlyCv fQlyCv = new FQlyCv();
            fQlyCv.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion DanhSachCV

        #region MauCV
        private void menuItem_MauCv_Click(object sender, EventArgs e)
        {
            this.OpenMauCV();
        }

        private void ucMenuCard_MauCV_MenuClick(object sender, EventArgs e)
        {
            this.OpenMauCV();
        }

        private void OpenMauCV()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FMauCv fMauCv = new FMauCv();
            fMauCv.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion MauCV

        #region DangXuat
        private void menuItem_DangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ucMenuCard_DangXuat_MenuClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion DangXuat

        #region DanhSachViecLam
        private void menuItem_Dsvl_Click(object sender, EventArgs e)
        {
            this.OpenMenuDanhSachViecLam();
        }

        private void ucMenuCard_DsViecLam_MenuClick(object sender, EventArgs e)
        {
            this.OpenMenuDanhSachViecLam();
        }

        private void OpenMenuDanhSachViecLam()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FDanhSachVL_Name fDanhSachVL = new FDanhSachVL_Name();
            fDanhSachVL.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion DanhSachViecLam

        #region DanhSachCongTy
        private void menuItem_DsCty_Click(object sender, EventArgs e)
        {
            this.OpenDanhSachCongTy();
        }

        private void ucMenuCard_DsCty_MenuClick(object sender, EventArgs e)
        {
            this.OpenDanhSachCongTy();
        }

        private void OpenDanhSachCongTy()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FDanhSachCty fDanhSachCty = new FDanhSachCty();
            fDanhSachCty.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion DanhSachCongTy

        #region ViecLamDaUngTuyen
        private void menuItem_VieclamUT_Click(object sender, EventArgs e)
        {
            this.OpenDanhSachDaUT();
        }

        private void ucMenuCard_ViecLamUT_MenuClick(object sender, EventArgs e)
        {
            this.OpenDanhSachDaUT();
        }

        private void OpenDanhSachDaUT()
        {
            if (!isAlwaysShowDashboard) this.Hide();

            FDanhSachDaUT fDanhSachDaUT = new FDanhSachDaUT();
            fDanhSachDaUT.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion ViecLamDaUngTuyen
    }
}
