using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace FinalProject.Database.Entities
{
    public class UngVien
    {
        public static string TableName = "UngVien";

        public int Id { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; } = DateTime.Now;
        public string GioiTinh { get; set; } = string.Empty;

        public string DiaChi { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty ;
        public string Email { get; set; } = string.Empty;
        public string ChuyenMon { get; set; } = string.Empty;
        public string TrangThai { get; set; } = string.Empty;
        public Image Avatar { get; set; }
        public string AvatarString { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        public int UserId { get; set; }
        public bool CheckNull()
        {
            var properties = new object[] { Id, NgaySinh, HoTen, GioiTinh, DiaChi, SDT, Email, ChuyenMon, Avatar };
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

            return false;
        }
    }
}
