using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common
{
    public static class LoggedUser
    {
        public static int UserId { get; set; }
        public static string UserRole { get; set; }
        public static UngVien UngVien { get; set; }
        public static CongTy CongTy { get; set; }
        public static User User { get; set; }
    }
}
