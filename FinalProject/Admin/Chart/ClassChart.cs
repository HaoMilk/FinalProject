using FinalProject.Admin.GUI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Admin.Chart
{
    public class ClassChart : DbContext
    {
        public ClassChart() 
           : base("name = CongViec")
        {
        }
        public virtual DbSet<FThongKe> charts {  get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
