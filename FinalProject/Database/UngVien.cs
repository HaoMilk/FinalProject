namespace FinalProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UngVien")]
    public partial class UngVien
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; } = string.Empty;

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string GioiTinh { get; set; } = string.Empty;

        [StringLength(100)]
        public string DiaChi { get; set; } = string.Empty;

        [StringLength(20)]
        public string SDT { get; set; } = string.Empty;

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;

        public string ChuyenMon { get; set; } = string.Empty;

        [StringLength(50)]
        public string TrangThai { get; set; } = string.Empty;

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        public bool? IsDeleted { get; set; } = false;

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        public int? UserId { get; set; }
    }
}
