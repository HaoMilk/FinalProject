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
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime? ThoiGianPhongVan { get; set; }
        public string DiaDiemPhongVan { get; set; }
        public string NguoiPhongVan { get; set; }
        public string KetQuaPhongVan { get; set; }
    }

    /// <summary>
    /// 1. Submitted -> 2. Approved (Hẹn lịch PV) / Rejected (Hủy CV) -> 3. Recruitmented
    /// </summary>
    public static class TrangThaiUngTuyen
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
