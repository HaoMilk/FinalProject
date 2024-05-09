using FinalProject.Common.DTO;
using FinalProject.DAO;
using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.BUS
{
    internal class CongTyBUS
    {
        #region EF6
        public int Add(int id, string email, string tencongty, string dichi, string ceo, string mst)
        {
            using(var db = new JobManagerContext())
            {
                var ct = new CongTy();
                ct.ID = id;
                ct.Email = email;
                ct.MST = mst;
                ct.TenCongTy = tencongty;
                ct.DiaChi = dichi;
                ct.TenCEO = ceo;
                ct.CreatedTime = DateTime.Now;
                ct.UpdatedTime = DateTime.Now;
                ct.IsDeleted = false;
                db.CongTy.Add(ct);
                return db.SaveChanges();
            }
        }

        public int Add(CongTy congTy)
        {
            using (var db = new JobManagerContext())
            {
                db.CongTy.Add(congTy);
                return db.SaveChanges();
            }
        }

        public int Update(int id, string email, string tencongty, string dichi, string ceo, string mst)
        {
           using (var db = new JobManagerContext())
            {
                var ct = db.CongTy.Find(id);
                ct.Email = email;
                ct.MST = mst;
                ct.TenCongTy = tencongty;
                ct.DiaChi = dichi;
                ct.TenCEO = ceo;
                ct.UpdatedTime = DateTime.Now;
                ct.IsDeleted = false;
                return db.SaveChanges();
            }
        }

        public int Delete(int idCongTy)
        {
            using (var db = new JobManagerContext())
            {
                var congTy = db.CongTy.Find(idCongTy);
                db.CongTy.Remove(congTy);
                return db.SaveChanges();
            }
        }

        public int SoftDelete(int idCongTy)
        {
            using (var db = new JobManagerContext())
            {
                var congTy = db.CongTy.Find(idCongTy);
                congTy.IsDeleted = true;
                congTy.UpdatedTime = DateTime.Now;
                return db.SaveChanges();
            }
        }

        public CongTy GetById(int id)
        {
            using (var db = new JobManagerContext())
            {
                return db.CongTy.Find(id);
            }
        }

        public List<CongTy> GetAll()
        {
            using (var db = new JobManagerContext())
            {
                return db.CongTy.ToList();
            }
        }

        public List<CongTy> Search(CongTyGetAllInput input)
        {
            using (var db = new JobManagerContext())
            {
                var query = db.CongTy.AsQueryable();
                if (input.Id > 0)
                {
                    query = query.Where(x => x.ID == input.Id);
                }
                if (!string.IsNullOrEmpty(input.TenCongTy))
                {
                    query = query.Where(x => x.TenCongTy.Contains(input.TenCongTy));
                }
                if (input.UserId > 0)
                {
                    query = query.Where(x => x.UserId == input.UserId);
                }
                return query.ToList();
            }
        }

        public CongTy GetByUserId(int userId)
        {
            using (var db = new JobManagerContext())
            {
                return db.CongTy.FirstOrDefault(x => x.UserId == userId);
            }
        }

        public int AddFileWord(string url, int id)
        {
            using (var db = new JobManagerContext())
            {
                var congTy = db.CongTy.Find(id);
                congTy.WordURL = url;
                return db.SaveChanges();
            }
        }
        #endregion EF6

        #region DAO
        CongTyDAO congTyDAO = new CongTyDAO();

        public int AddDAO(int id, string email, string tencongty, string dichi, string ceo, string mst)
        {
            var ct = new CongTy();
            ct.ID = id;
            ct.Email = email;
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.DiaChi = dichi;
            ct.TenCEO = ceo;
            ct.CreatedTime = DateTime.Now;
            ct.UpdatedTime = DateTime.Now;
            ct.IsDeleted = false;
            return congTyDAO.Add(ct);
        }

        public int AddDAO(CongTy congTy)
        {
            return congTyDAO.Add(congTy);
        }

        public int UpdateDAO(int id, string email, string tencongty, string dichi, string ceo, string mst)
        {
            var ct = new CongTy();
            ct.ID = id;
            ct.Email = email;
            ct.MST = mst;
            ct.TenCongTy = tencongty;
            ct.DiaChi = dichi;
            ct.TenCEO = ceo;
            ct.UpdatedTime = DateTime.Now;
            ct.IsDeleted = false;
            return congTyDAO.Edit(ct);
        }

        public int DeleteDAO(int idCongTy)
        {
            var congTy = new CongTy();
            congTy.ID = idCongTy;
            return congTyDAO.Delete(congTy);
        }

        public int SoftDeleteDAO(int idCongTy)
        {
            var congTy = new CongTy();
            congTy.ID = idCongTy;
            congTy.IsDeleted = true;
            congTy.UpdatedTime = DateTime.Now;
            return congTyDAO.SoftDelete(congTy);
        }

        public CongTy GetByIdDAO(int id)
        {
            return congTyDAO.GetById(id);
        }

        public List<CongTy> GetAllDAO()
        {
            return congTyDAO.GetAll();
        }

        public List<CongTy> SearchDAO(CongTyGetAllInput input)
        {
            return congTyDAO.GetAll(input);
        }

        public CongTy GetByUserIdDAO(int userId)
        {
            var input = new CongTyGetAllInput
            {
                UserId = userId
            };
            return congTyDAO.GetAll(input).FirstOrDefault();
        }

        public int AddFileWordDAO(string url, int id)
        {
            return congTyDAO.AddfileWord(url, id);
        }
        #endregion DAO
    }
}
