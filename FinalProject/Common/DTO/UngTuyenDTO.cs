using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.DTO
{
    public class UngTuyenDTO
    {
        public int Id { get; set; }
        public string TenCongViec { get; set; }
        public string TenCongTy { get; set; }
        public int CongViecId { get; set; }
        public int UngVienId { get; set; }
        public string TenUngVien { get; set; }
        public int CvId { get; set; }
        public string TenCv { get; set; }
        public string LinkCv { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime? ThoiGianPhongVan { get; set; }
        public string DiaDiemPhongVan { get; set; }
        public string NguoiPhongVan { get; set; }
        public string KetQuaPhongVan { get; set; }
    }
}
