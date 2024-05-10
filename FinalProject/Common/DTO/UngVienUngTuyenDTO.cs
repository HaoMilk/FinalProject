using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DTO
{
    public class UngVienUngTuyenDTO
    {
        public int Id { get; set; }

        [DisplayName("Tên công việc")]
        public string TenCongViec { get; set; }

        [DisplayName("Tên công ty")]
        public string TenCongTy { get; set; }

        [DisplayName("Tên ứng viên")]
        public string TenUngVien { get; set; }

        [DisplayName("Tên CV")]
        public string TenCv { get; set; }

        [DisplayName("Link CV")]
        public string LinkCv { get; set; }

        [DisplayName("Trạng thái")]
        public string TrangThai { get; set; }

        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
    }
}
