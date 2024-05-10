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

        public bool CheckNull()
        {
            var properties = new object[] { Ten, Nganh, ViTriTuyenDung, MucLuong, DiaDiem, TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, KinhNghiem, YeuCauUngVien, SoLuong, IdCongTy, FromDate };

            foreach (var property in properties)
            {
                if (IsNull(property))
                {
                    return true; // Trả về true nếu có bất kỳ thuộc tính nào null hoặc mặc định
                }
            }

            return false; // Trả về false nếu tất cả các thuộc tính đều không null hoặc mặc định
        }

        public bool IsNull(object obj)
        {
            // Kiểm tra cho chuỗi
            if (obj is string && string.IsNullOrEmpty((string)obj))
            {
                return true;
            }
            if (obj is decimal && (decimal)obj == default(decimal))
            {
                return true;
            }
            if (obj is int && (int)obj == default(int))
            {
                return true;
            }
            if (obj is DateTime && (DateTime)obj == default(DateTime))
            {
                return true;
            }

            return false;
        }
    }

}
