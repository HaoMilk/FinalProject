using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Candidate.Constants
{
    public class KinhNghiemConstants
    {
        public const string All = "Tất cả kinh nghiệm";
        public const string Duoi1Nam = "Dưới 1 năm";
        public const string Tu1Den2Nam = "1 - 2 năm";
        public const string Tu2Den5Nam = "2 - 5 năm";
        public const string Tren5Nam = "Trên 5 năm";
        public const string KhongYeuCau = "Không yêu cầu";

        public static List<string> GetKinhNghiemList()
        {
            var kinhNghiemList = new List<string>
            {
                All,
                Duoi1Nam,
                Tu1Den2Nam,
                Tu2Den5Nam,
                Tren5Nam,
                KhongYeuCau
            };
            return kinhNghiemList;
        }
    }

    public enum KinhNghiemEnum
    {
        All,
        Duoi1Nam,
        Tu1Den2Nam,
        Tu2Den5Nam,
        Tren5Nam,
        KhongYeuCau
    }

    public static class KinhNghiemExtension
    {
        public static string ToFriendlyString(this KinhNghiemEnum kinhNghiemEnum)
        {
            switch (kinhNghiemEnum)
            {
                case KinhNghiemEnum.All:
                    return KinhNghiemConstants.All;
                case KinhNghiemEnum.Duoi1Nam:
                    return KinhNghiemConstants.Duoi1Nam;
                case KinhNghiemEnum.Tu1Den2Nam:
                    return KinhNghiemConstants.Tu1Den2Nam;
                case KinhNghiemEnum.Tu2Den5Nam:
                    return KinhNghiemConstants.Tu2Den5Nam;
                case KinhNghiemEnum.Tren5Nam:
                    return KinhNghiemConstants.Tren5Nam;
                case KinhNghiemEnum.KhongYeuCau:
                    return KinhNghiemConstants.KhongYeuCau;
                default:
                    return KinhNghiemConstants.All;
            }
        }
    }
}
