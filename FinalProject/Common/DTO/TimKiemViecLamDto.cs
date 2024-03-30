using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.DTO
{
    public class TimKiemViecLamDto
    {
        public string Search { get; set; }
        public string DiaDiem { get; set; }
        public string NgheNghiep { get; set; }
        public decimal? MinLuong { get; set; }
        public decimal? MaxLuong { get; set; }
        public bool LuongThoaThuan { get; set; } = false;
        public decimal? MinKinhNghiem { get; set; }
        public decimal? MaxKinhNghiem { get; set; }
    }
}
