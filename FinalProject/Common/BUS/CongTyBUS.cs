using FinalProject.Common.DAO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.BUS
{
    internal class CongTyBUS
    {
        CongTyDAO congTyDAO = new CongTyDAO();  
        public void Add(string mst, String tencongty, string dichi, string tenCEO)
        {
            var ct = new CongTy();
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.Diachi = dichi;
            ct.TenCEO = tenCEO;
            congTyDAO.Add(ct);
        }
    }
}
