using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Const
{
    public class MucLuongConstants
    {
        public const string All = "Tất cả mức lương";
        public const string Duoi10Trieu = "Dưới 10 triệu";
        public const string Tu10Den15Trieu = "10 - 15 triệu";
        public const string Tu15Den20Trieu = "15 - 20 triệu";
        public const string Tu20Den25Trieu = "20 - 25 triệu";
        public const string Tu25Den30Trieu = "25 - 30 triệu";
        public const string Tu30Den50Trieu = "30 - 50 triệu";
        public const string Tren50Trieu = "Trên 50 triệu";
        public const string ThoaThuan = "Thỏa thuận";
       
        public static List<string> GetMucLuongList()
        {
            var mucLuongList = new List<string>
            {
                All,
                Duoi10Trieu,
                Tu10Den15Trieu,
                Tu15Den20Trieu,
                Tu20Den25Trieu,
                Tu25Den30Trieu,
                Tu30Den50Trieu,
                Tren50Trieu,
                ThoaThuan
            };
            return mucLuongList;
        }
    }

    public enum MucLuongEnum
    {
        All,
        Duoi10Trieu,
        Tu10Den15Trieu,
        Tu15Den20Trieu,
        Tu20Den25Trieu,
        Tu25Den30Trieu,
        Tu30Den50Trieu,
        Tren50Trieu,
        ThoaThuan
    }

    public static class MucLuongExtension
    {
        public static string ToFriendlyString(this MucLuongEnum mucLuongEnum)
        {
            switch (mucLuongEnum)
            {
                case MucLuongEnum.All:
                    return MucLuongConstants.All;
                case MucLuongEnum.Duoi10Trieu:
                    return MucLuongConstants.Duoi10Trieu;
                case MucLuongEnum.Tu10Den15Trieu:
                    return MucLuongConstants.Tu10Den15Trieu;
                case MucLuongEnum.Tu15Den20Trieu:
                    return MucLuongConstants.Tu15Den20Trieu;
                case MucLuongEnum.Tu20Den25Trieu:
                    return MucLuongConstants.Tu20Den25Trieu;
                case MucLuongEnum.Tu25Den30Trieu:
                    return MucLuongConstants.Tu25Den30Trieu;
                case MucLuongEnum.Tu30Den50Trieu:
                    return MucLuongConstants.Tu30Den50Trieu;
                case MucLuongEnum.Tren50Trieu:
                    return MucLuongConstants.Tren50Trieu;
                case MucLuongEnum.ThoaThuan:
                    return MucLuongConstants.ThoaThuan;
                default:
                    return MucLuongConstants.All;
            }
        }
    }
}
