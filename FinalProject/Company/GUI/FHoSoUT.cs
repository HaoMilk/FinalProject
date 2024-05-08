using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Company.GUI
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

        }

        private void TimKiem()
        {
            input.IdCongTy = LoggedUser.CongTy.ID;
            input.TrangThai = TrangThaiUngTuyen.GetKey(comboBox_TrangThai.Text);
            listUngTuyen = ungTuyenBUS.Search(input);

            var ucViewCVs = CreateCvList();
            flowLayoutPanel_Data.Controls.Clear();
            flowLayoutPanel_Data.SuspendLayout();
            flowLayoutPanel_Data.Controls.AddRange(ucViewCVs.ToArray());
            flowLayoutPanel_Data.ResumeLayout();
        }

        private List<UCViewCV> CreateCvList()
        {
            List<UCViewCV> uCViewCVs = new List<UCViewCV>();
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
            TimKiem();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void comboBox_TrangThai_SelectedValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
