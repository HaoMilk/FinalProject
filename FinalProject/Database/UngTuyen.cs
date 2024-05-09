namespace FinalProject.Database
{
    using FinalProject.Common.DTO;
    using FinalProject.Common.Helper;
    using FinalProject.Database.DTO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;
    using System.Text;

    [Table("UngTuyen")]
    public partial class UngTuyen
    {
        public int Id { get; set; }

        public int? CongViecId { get; set; }

        public int? UngVienId { get; set; }

        public int? CvId { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; } = string.Empty;

        [StringLength(200)]
        public string MoTa { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; } = false;

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianPhongVan { get; set; } = DateTime.Now;

        [StringLength(200)]
        public string DiaDiemPhongVan { get; set; } = string.Empty;

        [StringLength(50)]
        public string NguoiPhongVan { get; set; } = string.Empty;

        [StringLength(200)]
        public string KetQuaPhongVan { get; set; } = string.Empty;


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
}
