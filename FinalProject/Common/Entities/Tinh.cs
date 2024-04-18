using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Entities
{
    public class Tinh
    {
        public static string TableName = "Tinh";

        public int Id { get; set; }
        public string Code { get; set; }
        public string Ten { get; set; }
        public string TrangThai { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public override string ToString()
        {
            return $"{Ten}";
        }
    }
}
