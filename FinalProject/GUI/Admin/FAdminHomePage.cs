using FinalProject.Admin.GUI.ThongKe;
using System;
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
        #endregion

        #region XetDuyet
        #endregion XetDuyet

        private void ucMenuCard_DangXuat_MenuClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
