namespace FinalProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tinh")]
    public partial class Tinh
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; } = string.Empty;

        [StringLength(50)]
        public string Ten { get; set; } = string.Empty;

        [StringLength(20)]
        public string TrangThai { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; } = false;

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        public override string ToString()
        {
            return $"{Ten}";
        }
    }
}
