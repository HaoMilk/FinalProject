using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Entities
{
    public class UngTuyen
    {
        public static string TableName = "UngTuyen";

        public int Id { get; set; }
        public int CongViecId { get; set; }
        public int UngVienId { get; set; }
        public int CvId { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
        public bool IsDeleted { get; set; }
    }
}
