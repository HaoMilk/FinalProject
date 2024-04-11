using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Entities
{
    public class CongViec
    {
        public static string TableName = "CongViec";

        public int Id { get; set; }
        public string Ten { get; set; }
        public string Nganh { get; set; }
        public string ViTriTuyenDung { get; set; }
        public decimal MucLuong { get; set; }
        public string DiaDiem { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string GioiTinh { get; set; }
        public string LienHe { get; set; }
        public string MoTa { get; set; }
        public string QuyenLoi { get; set; }
        public string KinhNghiem { get; set; }
        public string YeuCauUngVien { get; set; }
        public int SoLuong { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime FromDate { get; set; }  
        public int IdCongTy { get; set; }
        public string TenCongTy { get; set; }

        public bool CheckNull( )
        {
            return string.IsNullOrEmpty(Ten) ||
                   string.IsNullOrEmpty(Nganh) ||
                   string.IsNullOrEmpty(ViTriTuyenDung) ||
                   string.IsNullOrEmpty(DiaDiem) ||
                   string.IsNullOrEmpty(TrinhDoHocVan) ||
                   string.IsNullOrEmpty(GioiTinh) ||
                   string.IsNullOrEmpty(LienHe) ||
                   string.IsNullOrEmpty(MoTa) ||
                   string.IsNullOrEmpty(QuyenLoi) ||
                   string.IsNullOrEmpty(KinhNghiem) ||
                   string.IsNullOrEmpty(YeuCauUngVien) ||
                   string.IsNullOrEmpty(TenCongTy) ||
                   MucLuong == default ||
                   SoLuong == default ||
                   IdCongTy == default ||
                   FromDate == default;
        }
    }

}
