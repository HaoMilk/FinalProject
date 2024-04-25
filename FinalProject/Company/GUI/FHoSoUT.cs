    using FinalProject.Common;
    using FinalProject.Common.BUS;
    using FinalProject.Common.DAO;
    using FinalProject.Database.DTO;
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
    using System.Windows.Documents;
    using System.Windows.Forms;

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
            }

            private void FQlyCv_Load(object sender, EventArgs e)
            {
                LoadCvList();
            }

            private void LoadCvList()
            {
                var quantity = ucPagination.PageSize;
                var start = ucPagination.StartRecord;
                var end = ucPagination.EndRecord;

                var ucJobCards = CreateCvList(quantity);
                flowLayoutPanel_Data.Controls.Clear();

                foreach (var ucJobCard in ucJobCards)
                {
                    flowLayoutPanel_Data.Controls.Add(ucJobCard);
                }
            }

            private List<UCViewCV> CreateCvList(int quantity)
            {

                List<UCViewCV> uCViewCVs = new List<UCViewCV>();
                input.IdCongTy = LoggedUser.CongTy.ID;
                if (comboBox_TrangThai.Text == "Hồ sơ chưa duyệt" || comboBox_TrangThai.Text == "")
                {
                    input.TrangThai = TrangThaiUngTuyen.Submitted;
                }
                if (comboBox_TrangThai.Text == "Hồ sơ đã duyệt")
                {
                    input.TrangThai = TrangThaiUngTuyen.Approved;     
                }

                listUngTuyen = ungTuyenBUS.Search(input);
                for (int i = 0; i < listUngTuyen.Count; i++)
                    {
                        UCViewCV uCViewCV = new UCViewCV();
                        uCViewCV.Id = listUngTuyen[i].Id;
                        uCViewCV.CvName = listUngTuyen[i].TenCv;
                        uCViewCV.LastUpdatedTime = listUngTuyen[i].UpdatedTime ?? DateTime.Now;
                        uCViewCVs.Add(uCViewCV);
                    }
                    return uCViewCVs;
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
