using FinalProject.Common.BUS;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Const
{
    public static class TinhConsts
    {
        private static TinhBUS tinhBUS = new TinhBUS();
        public static Dictionary<string, string> TinhDictionary = tinhBUS.GetAllDictionary();
        public static List<Tinh> ListTinh = tinhBUS.GetAll();
    }
}
