using FinalProject.Common.Const;
using FinalProject.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DTO
{
    public class CongViecGetAllInput
    {
        public string Search { get; set; }
        public string DiaDiem { get; set; }
        public string Nganh { get; set; }
        public string KinhNghiem {  get; set; }
        public decimal? MinLuong { get; set; }
        public decimal? MaxLuong { get; set; }
        public bool LuongThoaThuan { get; set; } = false;
        public decimal? MinKinhNghiem { get; set; }
        public decimal? MaxKinhNghiem { get; set; }
        public string GioiTinh { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? IdCongTy { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }

        public CongViecGetAllInput()
        {
            
        }

        public CongViecGetAllInput SetKinhNghiem(string kinhNgiem)
        {
            switch (kinhNgiem)
            {
                case KinhNghiemConsts.All:
                    this.MinKinhNghiem = null;
                    this.MaxKinhNghiem = null;
                    break;
                case KinhNghiemConsts.Duoi1Nam:
                    this.MinKinhNghiem = 0;
                    this.MaxKinhNghiem = 1;
                    break;
                case KinhNghiemConsts.Tu1Den2Nam:
                    this.MinKinhNghiem = 1;
                    this.MaxKinhNghiem = 2;
                    break;
                case KinhNghiemConsts.Tu2Den5Nam:
                    this.MinKinhNghiem = 2;
                    this.MaxKinhNghiem = 5;
                    break;
                case KinhNghiemConsts.Tren5Nam:
                    this.MinKinhNghiem = 5;
                    this.MaxKinhNghiem = null;
                    break;
                case KinhNghiemConsts.KhongYeuCau:
                    this.MinKinhNghiem = -1;
                    this.MaxKinhNghiem = -1;
                    break;
            }
            return this;
        }

        public CongViecGetAllInput SetMucLuong(string mucLuong)
        {
            switch (mucLuong)
            {
                case MucLuongConstants.All:
                    this.MinLuong = null;
                    this.MaxLuong = null;
                    this.LuongThoaThuan = false;
                    break;
                case MucLuongConstants.Duoi10Trieu:
                    this.MinLuong = 0;
                    this.MaxLuong = 10_000_000;
                    break;
                case MucLuongConstants.Tu10Den15Trieu:
                    this.MinLuong = 10_000_000;
                    this.MaxLuong = 15_000_000;
                    break;
                case MucLuongConstants.Tu15Den20Trieu:
                    this.MinLuong = 15_000_000;
                    this.MaxLuong = 20_000_000;
                    break;
                case MucLuongConstants.Tu20Den25Trieu:
                    this.MinLuong = 20_000_000;
                    this.MaxLuong = 25_000_000;
                    break;
                case MucLuongConstants.Tu25Den30Trieu:
                    this.MinLuong = 25_000_000;
                    this.MaxLuong = 30_000_000;
                    break;
                case MucLuongConstants.Tu30Den50Trieu:
                    this.MinLuong = 30_000_000;
                    this.MaxLuong = 50_000_000;
                    break;
                case MucLuongConstants.Tren50Trieu:
                    this.MinLuong = 50_000_000;
                    this.MaxLuong = null;
                    break;
                case MucLuongConstants.ThoaThuan:
                    this.MinLuong = null;
                    this.MaxLuong = null;
                    this.LuongThoaThuan = true;
                    break;
            }

            return this;
        }
    }
}
