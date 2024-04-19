using FinalProject.Common.DAO;
using FinalProject.Common.DTO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.Common.BUS
{
    internal class CongTyBUS
    {
        CongTyDAO congTyDAO = new CongTyDAO();  
        public int Add(int id, string email, string tencongty, string dichi, string ceo, string mst)
        {
            var ct = new CongTy();
            ct.ID = id;
            ct.Email = email;
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.DiaChi = dichi;
            ct.CEO = ceo;
            ct.CreatedTime = DateTime.Now;
            ct.UpdatedTime = DateTime.Now;
            ct.IsDeleted = false;
            return congTyDAO.Add(ct);
        }

        public int Add(CongTy congTy)
        {
            return congTyDAO.Add(congTy);
        }

        public int Update(int id , string email, string tencongty, string dichi, string ceo, string mst )
        {
            var ct = new CongTy();
            ct.ID = id;
            ct.Email = email;
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.DiaChi = dichi;
            ct.CEO = ceo;
            ct.UpdatedTime = DateTime.Now;
            ct.IsDeleted = false;
            return congTyDAO.Edit(ct);
        }
        public int Delete(int idCongTy)
        {
            var congTy = new CongTy();
            congTy.ID = idCongTy;
            return congTyDAO.Delete(congTy);
        }

        public int SoftDelete(int idCongTy)
        {
            var congTy = new CongTy();
            congTy.ID = idCongTy;
            congTy.IsDeleted = true;
            congTy.UpdatedTime = DateTime.Now;
            return congTyDAO.SoftDelete(congTy);
        }

        public CongTy GetById(int id)
        {
            return congTyDAO.GetById(id);
        }

        public List<CongTy> GetAll()
        {
            return congTyDAO.GetAll();
        }
        public List<CongTy> Search(CongTyGetAllInput input)
        {
            return congTyDAO.GetAll(input);
        }

        public CongTy GetByUserId(int userId)
        {
            var input = new CongTyGetAllInput
            {
                UserId = userId
            };
            return congTyDAO.GetAll(input).FirstOrDefault();
        }
    }
}
