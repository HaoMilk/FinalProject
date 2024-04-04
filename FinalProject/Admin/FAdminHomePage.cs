
using FinalProject.Admin.GUI;
using FinalProject.Admin.GUI.CongTy;
using FinalProject.Admin.GUI.CongViec;
using FinalProject.Admin.GUI.UngVien;
using FinalProject.Admin.XetDuyet;
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

        private void menu_TaiKhoanMatKhau_Click(object sender, EventArgs e)
        {
            FTaiKhoanCty fTaiKhoanCty = new FTaiKhoanCty();
            fTaiKhoanCty.ShowDialog();
        }


        private void menu_TaiKhoanUngVien_Click_1(object sender, EventArgs e)
        {
            FTaiKhoanUngVien fTaiKhoanUngVien = new FTaiKhoanUngVien();
            fTaiKhoanUngVien.ShowDialog();
        }

        private void menu_DanhSachUngVien_Click(object sender, EventArgs e)
        {
            FDanhSachUngVien fDanhSachUngVien = new FDanhSachUngVien();
            fDanhSachUngVien .ShowDialog();

        }

        private void menu_DanhSachCongTy_Click(object sender, EventArgs e)
        {
            FDanhSachCongTy fDanhSachCongTy = new FDanhSachCongTy();    
            fDanhSachCongTy .ShowDialog();
        }

        private void menu_DanhSachCongViec_Click(object sender, EventArgs e)
        {
            FDanhSachCongViec fDanhSachCongViec = new FDanhSachCongViec();
            fDanhSachCongViec.ShowDialog();
        }

        private void thêmỨngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChinhSuaUngVien fChinhSuaUngVien = new FChinhSuaUngVien();
            fChinhSuaUngVien.ShowDialog();
        }

        private void tàiKhoảnVàMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDoiMatKhau fDoiMatKhau = new FDoiMatKhau();
            fDoiMatKhau.ShowDialog();
        }

        private void chỉnhSửaCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChinhSuaCongTy fChinhSuaCongTy = new FChinhSuaCongTy();
            fChinhSuaCongTy.ShowDialog();
        }

        private void chỉnhSửaCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChinhSuaCongViec fChinhSuaCongViec = new FChinhSuaCongViec();
            fChinhSuaCongViec.ShowDialog();
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

            if(!isAlwaysShowDashboard) this.Show();
        }
        private void ucMenuCard1_MenuClick(object sender, EventArgs e)
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
        private void ucMenuCard_XetDuyet_MenuClick(object sender, EventArgs e)
        {
            this.OpenXetDuyet();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OpenXetDuyet();
        }
        #endregion XetDuyet
    }
}
