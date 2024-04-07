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
        public string Email { get; set; }
        public string TenCongTy { get; set; }
        public string DiaChi { get; set; }
        public string CEO { get; set; }
        public string MST { get; set; }
        public string Giayphep { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
    }
}
