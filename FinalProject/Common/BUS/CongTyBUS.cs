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
        public int Add(string mst, String tencongty, string dichi, string tenCEO)
        {
            var ct = new CongTy();
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.Diachi = dichi;
            ct.TenCEO = tenCEO;
            return congTyDAO.Add(ct);
        }
        public int Edit(string mst, String tencongty, string dichi, string tenCEO)
        {  var ct = new CongTy();
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.Diachi = dichi;
            ct.TenCEO = tenCEO;
            return congTyDAO.Edit(ct);
        }
    }
}
