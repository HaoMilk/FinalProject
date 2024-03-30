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
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string ViTriUngTuyen {  get; set; }
        public string KyNang { get; set; }
        public string NgoaiNgu { get; set; }
        public string TinHoc { get; set; }
        public string HocVan { get; set; }
        public string HoatDong { get; set; }
        public string ChungChi { get; set; }
        public string MucTieu { get; set; }
        public string KinhNghiem { get; set; }

    }
}
