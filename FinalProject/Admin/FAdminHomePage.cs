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
    }
}
