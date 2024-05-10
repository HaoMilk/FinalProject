using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DTO
{
    public class UngVienUngTuyenDTO
    {
        public int Id { get; set; }
        public string TenCongViec { get; set; }
        public string TenCongTy { get; set; }
        public string TenUngVien { get; set; }
        public int CvId { get; set; }
        public string TenCv { get; set; }
        public string LinkCv { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
    }
}
