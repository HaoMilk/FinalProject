using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.DTO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;

namespace FinalProject.Company.GUI
{
    public partial class FHoSoUT : UCForm
    {
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<CongViec> listCongViec = new List<CongViec>();
        public FHoSoUT()
        {
            InitializeComponent();
        }

        private void FQlyCv_Load(object sender, EventArgs e)
        {
            LoadJobList();
        }

        #region JobList
        private void LoadJobList()
        {
            //ucPagination.TotalRecord = listCongViec.Count;
            var input = new CongViecGetAllInput();
            input.IdCongTy = LoggedUser.CongTy.ID;
            listCongViec = congViecBUS.Search(input);
            List<UCJobCard> uCViewJobs = new List<UCJobCard>();
            if (listCongViec != null && listCongViec.Count > 0)
            {
                for (int i = 0; i < listCongViec.Count; i++)
                {
                    UCJobCard uCViewJob = new UCJobCard();
                    uCViewJob.Id = listCongViec[i].Id;
                    uCViewJob.CongViec = listCongViec[i];
                    // Gán event UCViewJob_ViewClick cho EventHandler ViewClick
                    uCViewJob.ViewClick += UCViewJob_ViewClick;

                    uCViewJobs.Add(uCViewJob);
                }
            }

            flowLayoutPanel_Data.Controls.Clear();
            flowLayoutPanel_Data.SuspendLayout();
            flowLayoutPanel_Data.Controls.AddRange(uCViewJobs.ToArray());
            flowLayoutPanel_Data.ResumeLayout();
        }

        private void UCViewJob_ViewClick(object sender, EventArgs e)
        {
            var ucViewCV = sender as UCJobCard;
            FDanhSachUngTuyen fDanhSachUngTuyen = new FDanhSachUngTuyen();
            fDanhSachUngTuyen.IDJob = ucViewCV.Id;
            fDanhSachUngTuyen.ShowDialog();
        }

        #endregion JobList          

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            LoadJobList();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            LoadJobList();
        }
    }
}
