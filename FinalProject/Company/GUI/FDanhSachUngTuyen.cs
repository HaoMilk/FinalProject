using FinalProject.Common.BUS;
using FinalProject.Common;
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
using FinalProject.Database.Entities;

namespace FinalProject.Company.GUI
{
    public partial class FDanhSachUngTuyen : UCForm
    {
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();
        private int idCongViec;
        UngTuyenGetAllInput input = new UngTuyenGetAllInput();
        public int IDCongViec
        {
            get => idCongViec; 
            set
            {
                idCongViec = value;
            }
        }
        public FDanhSachUngTuyen()
        {
            InitializeComponent();
            comboBox_TrangThai.SelectedIndex = 0;
            LoadCVList();
        }

        private void LoadCVList()
        {
            List<UCViewCV> uCViewCVs = new List<UCViewCV>();
            input.IdCongTy = LoggedUser.CongTy.ID;
            input.IdCongViec = IDCongViec;
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

            flowLayoutPanel_DanhSachCV.Controls.Clear();
            flowLayoutPanel_DanhSachCV.SuspendLayout();
            flowLayoutPanel_DanhSachCV.Controls.AddRange(uCViewCVs.ToArray());
            flowLayoutPanel_DanhSachCV.ResumeLayout();
        }

        private void UCViewCV_CvClick(object sender, EventArgs e)
        {
            var ucViewCV = sender as UCViewCV;
            FViewCV fViewCV = new FViewCV();
            fViewCV.IdCV = ucViewCV.CVId;
            fViewCV.ShowDialog();
            LoadCVList();
        }

        private void comboBox_TrangThai_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCVList();
        }

        private void FDanhSachUngTuyen_Load(object sender, EventArgs e)
        {
        }

        private void FDanhSachUngTuyen_Shown(object sender, EventArgs e)
        {
            LoadCVList();
        }
    }
}
