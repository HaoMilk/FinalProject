using FinalProject.Admin;
using FinalProject.Common.GUI;
using FinalProject.Company.GUI;
using FinalProject.Company.GUI.Thong_tin;
using FinalProject.Company.GUI.Ung_tuyen;
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

        private void ucMenuCard_TaoViecLam_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FCongViec fAddViecLam = new FCongViec();
            fAddViecLam.ShowDialog();
            this.Show();
        }


        private void ucMenuCard_DangXuat_MenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucMenuCard_ViecLamUT_MenuClick(object sender, EventArgs e)
        {
            this.OpenMenuDanhSachViecLam();
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

        private void ucMenuCard_DoiMatKhau_MenuClick(object sender, EventArgs e)
        {
            this.Hide();
            FThongTinCongTy fThongTin = new FThongTinCongTy();
            fThongTin.ShowDialog();
            this.Show();
        }
    }
}
