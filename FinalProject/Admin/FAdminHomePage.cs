
using FinalProject.Admin.GUI;
using FinalProject.Admin.GUI.CongTy;
using FinalProject.Admin.GUI.CongViec;
using FinalProject.Admin.GUI.UngVien;
using FinalProject.Admin.GUI.XetDuyet;
using FinalProject.Candidate.GUI;
using FinalProject.Common.GUI;
using FinalProject.Company.GUI.Thong_tin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Admin
{
    public partial class FAdminHomePage : Form
    {
        private bool isAlwaysShowDashboard = true;
        public FAdminHomePage()
        {
            InitializeComponent();
        }      
        
        #region ThongKe
        private void tsM_ThongKe_Click(object sender, EventArgs e)
        {
            this.OpenThongKe();
        }
        private void OpenThongKe()
        {
            if (!isAlwaysShowDashboard) this.Hide();
            FThongKe fThongKe = new FThongKe();
            fThongKe.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        private void ucMenuCard_ThongKe_MenuClick(object sender, EventArgs e)
        {
            this.OpenThongKe();
        }

        #endregion ThongKe

        #region XetDuyet


        private void OpenXetDuyet()
        {
            if (!isAlwaysShowDashboard) this.Hide();
            FXetDuyet fXetDuyet = new FXetDuyet();
            fXetDuyet.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }

        private void tSM_XetDuyet(object sender, EventArgs e)
        {
            this.OpenXetDuyet();
        }       

        private void ucMenuCard_XetDuyet_MenuClick(object sender, EventArgs e)
        {
            this.OpenXetDuyet();
        }

        #endregion XetDuyet

        #region CongViec
        private void ucMenuCard_CongViec_MenuClick(object sender, EventArgs e)
        {
            this.OpenCongViec();
        }
        private void menu_DanhSachCongViec_Click(object sender, EventArgs e)
        {
            this.OpenCongViec();
        }
        private void OpenCongViec()
        {
            if (!isAlwaysShowDashboard) this.Hide();
            FDanhSachCongViec fDanhSachCongViec = new FDanhSachCongViec();
            fDanhSachCongViec.ShowDialog(); 

            if (!isAlwaysShowDashboard) this.Show();
        }
        private void menu_ChinhSuaCongViec_Click(object sender, EventArgs e)
        {
            FChinhSuaCongViec fChinhSuaCongViec = new FChinhSuaCongViec();
            fChinhSuaCongViec.ShowDialog();
        }
        #endregion CongViec

        #region UngVien
        private void ucMenuCard_UngVien_MenuClick(object sender, EventArgs e)
        {
            this.OpenUngVien();
        }
        private void OpenUngVien()
        {
            if (!isAlwaysShowDashboard) this.Hide();
            FDanhSachUngVien fDanhSachUngVien = new FDanhSachUngVien();
            fDanhSachUngVien.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        private void menu_DanhSachUngVien_Click(object sender, EventArgs e)
        {
            this.OpenUngVien();

        }
        private void menu_ChinhSuaUngVien_Click(object sender, EventArgs e)
        {
            FChinhSuaUngVien fChinhSuaUngVien = new FChinhSuaUngVien();
            fChinhSuaUngVien.ShowDialog();
        }
        private void menu_TaiKhoanUngVien_Click_1(object sender, EventArgs e)
        {
            FTaiKhoanUngVien fTaiKhoanUngVien = new FTaiKhoanUngVien();
            fTaiKhoanUngVien.ShowDialog();
        }

        #endregion UngVien

        #region CongTy
        private void ucMenuCard_CongTy_MenuClick(object sender, EventArgs e)
        {
            this.OpenCongTy();
        }

        private void menu_ChinhSuaCongTy_Click(object sender, EventArgs e)
        {
            FChinhSuaCongTy fChinhSuaCongTy = new FChinhSuaCongTy();
            fChinhSuaCongTy.ShowDialog();
        }
        private void OpenCongTy()
        {
            if (!isAlwaysShowDashboard) this.Hide();
            FDanhSachCongTy fDanhSachCongTy = new FDanhSachCongTy();
            fDanhSachCongTy.ShowDialog();

            if (!isAlwaysShowDashboard) this.Show();
        }
        private void menu_DanhSachCongTy_Click(object sender, EventArgs e)
        {
            this.OpenCongTy();
        }
        private void menu_TaiKhoanMatKhau_Click(object sender, EventArgs e)
        {
            FTaiKhoanCty fTaiKhoanCty = new FTaiKhoanCty();
            fTaiKhoanCty.ShowDialog();
        }
        #endregion
    }
}
