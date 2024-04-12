using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
