using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Const
{
    public class TrangThaiUngTuyenConsts
    {
        public static Dictionary<string, string> Dict = new Dictionary<string, string>()
        {
            { "Submitted", "Hồ sơ chưa duyệt" },
            { "Approved", "Hồ sơ đã duyệt" },
            { "Rejected", "Hồ sơ bị loại" },
            { "Recruitmented", "Hồ sơ đã tuyển dụng" },
            { "Cancelled", "Hủy" }
        };

        public const string Submitted = "Submitted";
        public const string Approved = "Approved";
        public const string Rejected = "Rejected";
        public const string Recruitmented = "Recruitmented";
        public const string Cancelled = "Cancelled";

        public static string GetKey(string value)
        {
            foreach (var kvp in Dict)
            {
                if (kvp.Value == value)
                    return kvp.Key;
            }
            return null;
        }

        public static string GetValue(string key)
        {
            return Dict[key];
        }
    }
}
