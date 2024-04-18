﻿using System.Collections.Generic;

namespace FinalProject.Common.Const
{
    public class NgheNghiepConstants
    {
        public const string All = "Tất cả ngành nghề";
        public const string ITPhanMem = "IT Phần mềm";
        public const string KinhDoanh_BanHang = "Kinh doanh / Bán hàng";
        public const string Marketing = "Marketing";
        public const string TruyenThong_QuangCao = "Truyền thông / Quảng cáo";
        public const string HanhChinh_VanPhong = "Hành chính / Văn phòng";
        public const string DichVuKhachHang = "Dịch vụ khách hàng";
        public const string TuVan = "Tư vấn";

        public static List<string> GetNgheNghiepList()
        {
            var ngheNghiepList = new List<string>
            {
                All,
                ITPhanMem,
                KinhDoanh_BanHang,
                Marketing,
                TruyenThong_QuangCao,
                HanhChinh_VanPhong,
                DichVuKhachHang,
                TuVan
            };
            return ngheNghiepList;
        }
    }

    public enum NgheNghiepEnum
    {
        All,
        ITPhanMem,
        KinhDoanh_BanHang,
        Marketing,
        TruyenThong_QuangCao,
        HanhChinh_VanPhong,
        DichVuKhachHang,
        TuVan
    }

    public static class NgheNghiepExtension
    {
        public static string ToFriendlyString(this NgheNghiepEnum ngheNghiepEnum)
        {
            switch (ngheNghiepEnum)
            {
                case NgheNghiepEnum.All:
                    return NgheNghiepConstants.All;
                case NgheNghiepEnum.ITPhanMem:
                    return NgheNghiepConstants.ITPhanMem;
                case NgheNghiepEnum.KinhDoanh_BanHang:
                    return NgheNghiepConstants.KinhDoanh_BanHang;
                case NgheNghiepEnum.Marketing:
                    return NgheNghiepConstants.Marketing;
                case NgheNghiepEnum.TruyenThong_QuangCao:
                    return NgheNghiepConstants.TruyenThong_QuangCao;
                case NgheNghiepEnum.HanhChinh_VanPhong:
                    return NgheNghiepConstants.HanhChinh_VanPhong;
                case NgheNghiepEnum.DichVuKhachHang:
                    return NgheNghiepConstants.DichVuKhachHang;
                case NgheNghiepEnum.TuVan:
                    return NgheNghiepConstants.TuVan;
                default:
                    return NgheNghiepConstants.All;
            }
        }
    }
}