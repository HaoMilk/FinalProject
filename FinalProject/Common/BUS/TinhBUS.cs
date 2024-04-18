using FinalProject.Common.DAO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.BUS
{
    public class TinhBUS
    {
        private TinhDAO tinhDAO = new TinhDAO();

        public List<Tinh> GetAll()
        {
            return tinhDAO.GetAll();
        }

        public Dictionary<string, string> GetAllDictionary()
        {
            var listTinh = GetAll();
            var dictionary = new Dictionary<string, string>();
            foreach (var tinh in listTinh)
            {
                dictionary.Add(tinh.Code, tinh.Ten);
            }
            return dictionary;
        }

        public int CheckExist(int id)
        {
            return tinhDAO.CheckExist(id);
        }

        public int Add(int id, string code, string ten, string trangThai)
        {
            var tinh = new Tinh();
            tinh.Id = id;
            tinh.Code = code;
            tinh.Ten = ten;
            tinh.TrangThai = trangThai;
            tinh.IsDeleted = false;
            tinh.CreatedTime = DateTime.Now;
            tinh.UpdatedTime = null;

            return tinhDAO.Add(tinh);
        }

        public int Update(int id, string code, string ten, string trangThai, bool isDeleted)
        {
            var tinh = new Tinh();
            tinh.Id = id;
            tinh.Code = code;
            tinh.Ten = ten;
            tinh.TrangThai = trangThai;
            tinh.IsDeleted = isDeleted;
            tinh.UpdatedTime = DateTime.Now;

            return tinhDAO.Update(tinh);
        }

        public int Update(Tinh tinh)
        {
            return tinhDAO.Update(tinh);
        }

        public int Delete(int id)
        {
            var tinh = new Tinh();
            tinh.Id = id;
            return tinhDAO.Delete(tinh);
        }

        public int SoftDelete(int id)
        {
            var tinh = new Tinh();
            tinh.Id = id;
            tinh.IsDeleted = true;
            tinh.UpdatedTime = DateTime.Now;

            return tinhDAO.SoftDelete(tinh);
        }
    }
}
