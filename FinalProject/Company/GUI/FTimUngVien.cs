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

            dataGridView_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   // Turn off autosize
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

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            var input = new UngTuyenGetAllInput() { 
                IdCongTy = LoggedUser.CongTy.ID ,
                TenUngVien = textBox_TenUngVien.Text.Trim(),
            };
            listUngTuyen = ungTuyenBUS.Search(input);
            dataGridView_Data.DataSource = MappingData(listUngTuyen);

            dataGridView_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   // Turn off autosize
            dataGridView_Data.AllowUserToResizeRows = true;                                 // Turn on letting user size columns
            dataGridView_Data.AllowUserToOrderColumns = true;
        }

        private void dataGridView_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= listUngTuyen.Count) return;
            var row = dataGridView_Data.Rows[e.RowIndex];
            // convert row to UngVienUngTuyenDTO
            var item = new UngVienUngTuyenDTO()
            {
                Id = (int)row.Cells["Id"].Value,
                TenCongViec = (string)row.Cells["TenCongViec"].Value,
                TenCongTy = (string)row.Cells["TenCongTy"].Value,
                TenUngVien = (string)row.Cells["TenUngVien"].Value,
                TenCv = (string)row.Cells["TenCv"].Value,
                LinkCv = (string)row.Cells["LinkCv"].Value,
                TrangThai = (string)row.Cells["TrangThai"].Value,
                MoTa = (string)row.Cells["MoTa"].Value
            };
            FViewCV fViewCV = new FViewCV();
            fViewCV.IdCV = listUngTuyen[e.RowIndex].CvId;
            fViewCV.IdUT = item.Id;
            fViewCV.IdUV = listUngTuyen[e.RowIndex].UngVienId;
            fViewCV.ShowDialog();
        }
    }
}
