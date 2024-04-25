﻿
using FinalProject.Admin.GUI;
using FinalProject.Admin.GUI.ThongKe;
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
        #endregion

        #region XetDuyet
        #endregion XetDuyet

        private void ucMenuCard_DangXuat_MenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
