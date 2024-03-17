using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Entities
{
    public class CV
    {
        public static string TableName = "CV";

        public int Id { get; set; }
        public string Ten { get; set; }
        public int UngVienId { get; set; }
        public string Link { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public bool IsDeleted { get; set; }
    }
}
