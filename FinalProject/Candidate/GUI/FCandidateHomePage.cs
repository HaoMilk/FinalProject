using FinalProject.Common.GUI;
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
            this.Hide();

            FCandidateInfor fCandidateInfor = new FCandidateInfor();
            fCandidateInfor.ShowDialog();

            this.Show();
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
            this.Hide();

            FChangePassword fChangePassword = new FChangePassword();
            fChangePassword.ShowDialog();

            this.Show();
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
            this.Hide();

            FQlyCv fQlyCv = new FQlyCv();
            fQlyCv.ShowDialog();

            this.Show();
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
            this.Hide();

            FMauCv fMauCv = new FMauCv();
            fMauCv.ShowDialog();

            this.Show();
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
            this.Hide();

            FDanhSachVL_Name fDanhSachVL = new FDanhSachVL_Name();
            fDanhSachVL.ShowDialog();

            this.Show();
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
            this.Hide();

            FDanhSachCty fDanhSachCty = new FDanhSachCty();
            fDanhSachCty.ShowDialog();

            this.Show();
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
            this.Hide();

            FDanhSachDaUT fDanhSachDaUT = new FDanhSachDaUT();
            fDanhSachDaUT.ShowDialog();

            this.Show();
        }
        #endregion ViecLamDaUngTuyen

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
