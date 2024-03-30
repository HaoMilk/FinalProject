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

  


    private void menuItem_Dsvl_Click(object sender, EventArgs e)
        {
            FAddViecLam fAddViecLam = new FAddViecLam();
            fAddViecLam.Show();
        }

        private void menuItem_VieclamUT_Click(object sender, EventArgs e)
        {

        }

        private void hồSơĐãDuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơChưaDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
;
        }

        private void menuItem_DsCty_Click(object sender, EventArgs e)
        {
            FDanhSachUngVien fDanhSachUngVien = new FDanhSachUngVien();
            fDanhSachUngVien.Show();
        }

        private void menuItem_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTin fThongTin = new FThongTin();
            fThongTin.Show();
        }

        private void menuItem_DoiMatKhau_Click(object sender, EventArgs e)
        {
            FDoiMatKhau fDoiMatKhau = new FDoiMatKhau();
            fDoiMatKhau.Show();
        }

        private void menuItem_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FCompanyHomePage_Load(object sender, EventArgs e)
        {

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

            if (!isAlwaysShowDashboard) this.Show();
        }
        #endregion DanhSachViecLam
    }
}
