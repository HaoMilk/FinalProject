namespace FinalProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CV")]
    public partial class CV
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Ten { get; set; } = string.Empty;

        public int? UngVienId { get; set; }

        [StringLength(500)]
        public string Link { get; set; } = string.Empty;

        [StringLength(2000)]
        public string MoTa { get; set; } = string.Empty;

        [StringLength(50)]
        public string TrangThai { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; } = false;

        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        public DateTime? UpdatedTime { get; set; }

        [StringLength(250)]
        public string ViTriUngTuyen { get; set; } = string.Empty;

        [StringLength(500)]
        public string KyNang { get; set; } = string.Empty;

        [StringLength(250)]
        public string NgoaiNgu { get; set; } = string.Empty;

        [StringLength(250)]
        public string TinHoc { get; set; } = string.Empty;

        [StringLength(500)]
        public string HocVan { get; set; } = string.Empty;

        [StringLength(500)]
        public string HoatDong { get; set; } = string.Empty;

        [StringLength(500)]
        public string ChungChi { get; set; } = string.Empty;

        [StringLength(500)]
        public string MucTieu { get; set; } = string.Empty;

        [StringLength(500)]
        public string KinhNghiem { get; set; } = string.Empty;
    }
}
