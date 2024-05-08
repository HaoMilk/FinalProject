using FinalProject.Common.BUS;
using FinalProject.Common;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Database.DTO;

namespace FinalProject.Company.GUI
{
    public partial class FDanhSachUngTuyen : UCForm
    {
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();
        UngTuyenGetAllInput input = new UngTuyenGetAllInput();
        public int IDJob {  get; set; }
        public FDanhSachUngTuyen()
        {
            InitializeComponent();
        }
        private void LoadCvList()
        {
            //var quantity = ucPagination.PageSize;
            //var start = ucPagination.StartRecord;
            //var end = ucPagination.EndRecord;

            var ucJobCards = CreateCvList();
            flowLayoutPanel_HoSo.Controls.Clear();

            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_HoSo.Controls.Add(ucJobCard);
            }
        }
        private List<UCViewCV> CreateCvList()
        {

            List<UCViewCV> uCViewCVs = new List<UCViewCV>();
            input.IdCongTy = LoggedUser.CongTy.ID;
            input.IdCongViec = IDJob;
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

        private void FDanhSachUngTuyencs_Load(object sender, EventArgs e)
        {
            LoadCvList();
        }
    }
}
