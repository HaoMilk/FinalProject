using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.DTO;
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
    public partial class FTimUngVien : UCForm
    {
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();
        private CvBUS cvBUS = new CvBUS();
        private List<CV> listCV = new List<CV>();

        public FTimUngVien()
        {
            InitializeComponent();
        }

        private void FTimUngVien_Load(object sender, EventArgs e)
        {
            var input = new UngTuyenGetAllInput() { IdCongTy = LoggedUser.CongTy.ID };
            listUngTuyen = ungTuyenBUS.Search(input);
            dataGridView_Data.DataSource = MappingData(listUngTuyen);

            dataGridView_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;   // Turn off autosize
            dataGridView_Data.AllowUserToResizeRows = true;                                 // Turn on letting user size columns
            dataGridView_Data.AllowUserToOrderColumns = true;
        }

        private List<UngVienUngTuyenDTO> MappingData(List<UngTuyenDTO> sourceData)
        {
            var result = new List<UngVienUngTuyenDTO>();
            foreach (var item in sourceData)
            {
                var cv = cvBUS.GetById(item.CvId);
                result.Add(new UngVienUngTuyenDTO()
                {
                    Id = item.Id,
                    TenCongViec = item.TenCongViec,
                    TenCongTy = item.TenCongTy,
                    TenUngVien = item.TenUngVien,
                    TenCv = cv.Ten,
                    LinkCv = cv.Link,
                    TrangThai = item.TrangThai,
                    MoTa = item.MoTa
                });
            }
            return result;
        }
    }
}
