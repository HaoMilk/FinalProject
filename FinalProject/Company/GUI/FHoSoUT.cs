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
            private UngTuyenDAO ungTuyenDAO = new UngTuyenDAO();
            private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();

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
                listUngTuyen = ungTuyenDAO.GetAll(new UngTuyenGetAllInput {Id = LoggedUser.CongTy.ID});

                List<UCViewCV> uCViewCVs = new List<UCViewCV>();

                if (listUngTuyen.Count == 0)
                {
                    return uCViewCVs;
                }
                if (comboBox_TrangThai.Text == "Hồ sơ chưa duyệt")
                {
                var filteredList = listUngTuyen.Where(ungTuyen => ungTuyen.TrangThai == "watting").ToList();
                }
                if (comboBox_TrangThai.Text == "Hồ sơ đã duyệt")
                {
                    var filteredList = listUngTuyen.Where(ungTuyen => ungTuyen.TrangThai == "approved").ToList();
                }

            for (int i = 0; i < listUngTuyen.Count; i++)
                {
                    UCViewCV uCViewCV = new UCViewCV();
                    uCViewCV.Id = listUngTuyen[i].CvId;
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


            private void textBox_TenCv_KeyDown(object sender, KeyEventArgs e)
            {
            }

            private void button_TimKiem_Click(object sender, EventArgs e)
            {
                LoadCvList();
            }
        }
    }
