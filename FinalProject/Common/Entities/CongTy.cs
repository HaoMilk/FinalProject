using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Entities
{
    public class CongTy
    {
        public int ID { get; set; }
        public string Email { get; set; } = string.Empty;
        public string TenCongTy { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string CEO { get; set; } = string.Empty;
        public string MST { get; set; } = string.Empty;
        public string Giayphep { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int UserId { get; set; }
    }
}
