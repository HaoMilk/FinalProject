using FinalProject.Common.DTO;
using FinalProject.Common.Helper;
using FinalProject.Database.DTO;
using System;
using System.Collections.Generic;
using System.IO;
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

        public SendEmailBySMTPOutput SendEmailPhongVan(UngTuyenDTO dto)
        {
            var title = "Thông báo lịch phỏng vấn";
            var content = File.ReadAllText("Resources/Templates/HenLichPhongVan.html", encoding: Encoding.UTF8);
            content = content.Replace("@EmailTitle", title);
            content = content.Replace("@EmailContent", title);
            content = content.Replace("@TenUngVien", dto.TenUngVien);
            content = content.Replace("@TenCongViec", dto.TenCongViec);
            content = content.Replace("@TenCongTy", dto.TenCongTy);
            content = content.Replace("@ThoiGianPhongVan", dto.ThoiGianPhongVan.Value.ToString("hh:mm, dd/MM/yyyy"));
            content = content.Replace("@DiaDiemPhongVan", dto.DiaDiemPhongVan);

            var input = new SendEmailBySMTPInput
            {
                Title = title,
                Content = content,
                Recipient = new List<string> { dto.Email }
            };
            var output = MailHelper.SendEmailBySMTP(input);
            return output;
        }

        public SendEmailBySMTPOutput SendEmailKetQuaPhongVan(UngTuyenDTO dto)
        {
            var title = "Thông báo kết quả phỏng vấn";
            var content = File.ReadAllText("Resources/Templates/KetQuaPhongVan.html", encoding: Encoding.UTF8);
            content = content.Replace("@EmailTitle", title);
            content = content.Replace("@EmailContent", title);
            content = content.Replace("@TenUngVien", dto.TenUngVien);
            content = content.Replace("@TenCongViec", dto.TenCongViec);
            content = content.Replace("@TenCongTy", dto.TenCongTy);
            content = content.Replace("@KetQuaPhongVan", dto.KetQuaPhongVan);

            var input = new SendEmailBySMTPInput
            {
                Title = title,
                Content = content,
                Recipient = new List<string> { dto.Email }
            };
            var output = MailHelper.SendEmailBySMTP(input);
            return output;
        }

        public SendEmailBySMTPOutput SendEmailTuChoiHoSoPhongVan(UngTuyenDTO dto)
        {
            var title = "Thông báo hồ sơ ứng tuyển";
            var content = File.ReadAllText("Resources/Templates/TuChoiHoSoPhongVan.html", encoding: Encoding.UTF8);
            content = content.Replace("@EmailTitle", title);
            content = content.Replace("@EmailContent", title);
            content = content.Replace("@TenUngVien", dto.TenUngVien);
            content = content.Replace("@TenCongViec", dto.TenCongViec);
            content = content.Replace("@TenCongTy", dto.TenCongTy);

            var input = new SendEmailBySMTPInput
            {
                Title = title,
                Content = content,
                Recipient = new List<string> { dto.Email }
            };
            var output = MailHelper.SendEmailBySMTP(input);
            return output;
        }
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
