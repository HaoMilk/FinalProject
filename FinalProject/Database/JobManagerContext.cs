using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FinalProject.Database
{
    public partial class JobManagerContext : DbContext
    {
        public JobManagerContext()
            : base("name=JobManagerContext")
        {
        }

        public virtual DbSet<CongTy> CongTy { get; set; }
        public virtual DbSet<CongViec> CongViec { get; set; }
        public virtual DbSet<CV> CV { get; set; }
        public virtual DbSet<Tinh> Tinh { get; set; }
        public virtual DbSet<UngTuyen> UngTuyen { get; set; }
        public virtual DbSet<UngVien> UngVien { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongViec>()
                .Property(e => e.MucLuong)
                .HasPrecision(18, 0);
        }
    }
}
