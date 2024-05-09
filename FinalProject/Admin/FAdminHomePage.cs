
using FinalProject.Admin.GUI;
using FinalProject.Admin.GUI.ThongKe;
using FinalProject.Admin.GUI.ThongKe.Class;
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
        public FAdminHomePage()
        {
            InitializeComponent();
        }
        #region ThongKe
        private void ucMenuCard_DashBoard_MenuClick(object sender, EventArgs e)
        {
            FDashBoard fDashBoard = new FDashBoard();
            fDashBoard.Show();
        }
        private void ucMenuCard_ViecLamUT_MenuClick(object sender, EventArgs e)
        {
            FThongKeCongViec fThongKeCongViec = new FThongKeCongViec();
            fThongKeCongViec.Show();
        }
        private void ucMenuCard_UngVien_MenuClick(object sender, EventArgs e)
        {
            FThongKeUngVien fThongKeUngVien = new FThongKeUngVien();
            fThongKeUngVien.Show();
        }
        #endregion

        private void ucMenuCard_DangXuat_MenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
