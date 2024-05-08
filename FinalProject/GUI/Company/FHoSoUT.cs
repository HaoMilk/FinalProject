using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;

namespace FinalProject.GUI.Company
{
    public partial class FHoSoUT : UCForm
    {
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();
        UngTuyenGetAllInput input = new UngTuyenGetAllInput();

        public FHoSoUT()
        {
            InitializeComponent();
            comboBox_TrangThai.SelectedIndex = 0;
        }

        private void FQlyCv_Load(object sender, EventArgs e)
        {
            LoadCvList();
        }

        private void LoadCvList()
        {
            //var quantity = ucPagination.PageSize;
            //var start = ucPagination.StartRecord;
            //var end = ucPagination.EndRecord;

            var ucJobCards = CreateCvList();
            flowLayoutPanel_Data.Controls.Clear();

            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_Data.Controls.Add(ucJobCard);
            }
        }

        private List<UCViewCV> CreateCvList()
        {

            List<UCViewCV> uCViewCVs = new List<UCViewCV>();
            input.IdCongTy = LoggedUser.CongTy.ID;
            input.TrangThai = TrangThaiUngTuyen.GetKey(comboBox_TrangThai.Text);

            listUngTuyen = ungTuyenBUS.Search(input);

            for (int i = 0; i < listUngTuyen.Count; i++)
            {
                UCViewCV uCViewCV = new UCViewCV();
                uCViewCV.Id = listUngTuyen[i].Id;
                uCViewCV.CandidateId = listUngTuyen[i].UngVienId;
                uCViewCV.CVId = listUngTuyen[i].CvId;
                uCViewCV.CvName = listUngTuyen[i].TenCv;
                uCViewCV.LastUpdatedTime = listUngTuyen[i].UpdatedTime ?? DateTime.Now;
                uCViewCV.CvClick += UCViewCV_CvClick;
                uCViewCVs.Add(uCViewCV);
            }
            return uCViewCVs;
        }

        private void UCViewCV_CvClick(object sender, EventArgs e)
        {
            var ucViewCV = sender as UCViewCV;

            FViewCV fViewCV = new FViewCV();
            fViewCV.IdCV = ucViewCV.CVId;
            fViewCV.IdUT = ucViewCV.Id;
            fViewCV.IdUV = ucViewCV.CandidateId;

            fViewCV.ShowDialog();

            // Load lại data
            LoadCvList();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            LoadCvList();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            LoadCvList();
        }
    }
}
