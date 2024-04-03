﻿using FinalProject.Common.DAO;
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
        public int Add(int id, string passWord, string email, string tencongty, string dichi, string ceo, string mst)
        {
            var ct = new CongTy();
            ct.ID = id;
            ct.PassWord = passWord;
            ct.Email = email;
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.Diachi = dichi;
            ct.CEO = ceo;
            ct.CreatedTime = DateTime.Now;
            ct.UpdatedTime = null;
            ct.IsDeleted = false;
            return congTyDAO.Add(ct);
        }
        public int Update(int id, string passWord, string email, string tencongty, string dichi, string ceo, string mst )
        {
            var ct = new CongTy();
            ct.ID = id;
            ct.PassWord = passWord;
            ct.Email = email;
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.Diachi = dichi;
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
    }
}
