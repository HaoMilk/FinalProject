namespace FinalProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongTy")]
    public partial class CongTy
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;

        [StringLength(200)]
        public string TenCongTy { get; set; } = string.Empty;

        [StringLength(200)]
        public string DiaChi { get; set; } = string.Empty;

        [StringLength(100)]
        public string TenCEO { get; set; } = string.Empty;

        [StringLength(200)]
        public string MST { get; set; } = string.Empty;

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public int? UserId { get; set; }

        [StringLength(200)]
        public string WordURL { get; set; }
    }
}
