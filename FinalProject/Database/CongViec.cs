namespace FinalProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongViec")]
    public partial class CongViec
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Ten { get; set; } = string.Empty;

        [StringLength(500)]
        public string TenCongTy { get; set; } = string.Empty;

        [StringLength(100)]
        public string Nganh { get; set; } = string.Empty;

        [StringLength(100)]
        public string ViTriTuyenDung { get; set; } = string.Empty;

        public decimal? MucLuong { get; set; } = 0;

        [StringLength(255)]
        public string DiaDiem { get; set; } = string.Empty;

        [StringLength(255)]
        public string TrinhDoHocVan { get; set; } = string.Empty;

        [StringLength(20)]
        public string GioiTinh { get; set; } = string.Empty;

        [StringLength(100)]
        public string LienHe { get; set; } = string.Empty;

        [StringLength(2000)]
        public string MoTa { get; set; } = string.Empty;

        [StringLength(2000)]
        public string QuyenLoi { get; set; } = string.Empty;

        [StringLength(2000)]
        public string KinhNghiem { get; set; } = string.Empty;

        [StringLength(2000)]
        public string YeuCauUngVien { get; set; } = string.Empty;

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; } = DateTime.Now;

        public int? SoLuong { get; set; } = 0;

        public bool? IsDeleted { get; set; } = false;

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        public int? IdCongTy { get; set; }


        public bool CheckNull()
        {
            return string.IsNullOrEmpty(Ten) ||
                   string.IsNullOrEmpty(Nganh) ||
                   string.IsNullOrEmpty(ViTriTuyenDung) ||
                   string.IsNullOrEmpty(DiaDiem) ||
                   string.IsNullOrEmpty(TrinhDoHocVan) ||
                   string.IsNullOrEmpty(GioiTinh) ||
                   string.IsNullOrEmpty(LienHe) ||
                   string.IsNullOrEmpty(MoTa) ||
                   string.IsNullOrEmpty(QuyenLoi) ||
                   string.IsNullOrEmpty(KinhNghiem) ||
                   string.IsNullOrEmpty(YeuCauUngVien) ||
                   string.IsNullOrEmpty(TenCongTy) ||
                   MucLuong == default ||
                   SoLuong == default ||
                   IdCongTy == default ||
                   FromDate == default;
        }
    }
}
