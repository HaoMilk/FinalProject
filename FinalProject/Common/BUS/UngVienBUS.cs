using FinalProject.Common.DAO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Common.BUS
{
    public class UngVienBUS
    {
        private UngVienDAO ungVienDAO = new UngVienDAO();

        public int CheckExist(int id)
        {
            return ungVienDAO.CheckExist(id);
        }

        public int Count()
        {
            return ungVienDAO.Count();
        }

        public int Add(int id, string ten, DateTime ngaySinh, string gioiTinh,
            string diaChi, string sDT, string email, string chuyenMon, string trangThai)
        {
            var ungVien = new UngVien();
            ungVien.Id = id;
            ungVien.HoTen = ten;
            ungVien.NgaySinh = ngaySinh;
            ungVien.GioiTinh = gioiTinh;
            ungVien.DiaChi = diaChi;
            ungVien.SDT = sDT;
            ungVien.Email = email;
            ungVien.ChuyenMon = chuyenMon;
            ungVien.TrangThai = trangThai;
            ungVien.IsDeleted = false;
            ungVien.CreatedTime = DateTime.Now;
            ungVien.UpdatedTime = null;
            

            return ungVienDAO.Add(ungVien);
        }

        public int Add(UngVien ungVien)
        {
            return ungVienDAO.Add(ungVien);
        }

        public int Update(int id, string trangThai)
        {
            var ungVien = new UngVien()
            {
                Id = id,
                TrangThai = trangThai,       
                UpdatedTime = DateTime.Now
            };

            return ungVienDAO.Update(ungVien);
        }

        public int Update(UngVien ungVien)
        {
            return ungVienDAO.Update(ungVien);
        }

        public int Delete(int id)
        {
            var ungVien = new UngVien();
            ungVien.Id = id;
            return ungVienDAO.Delete(ungVien);
        }

        public int SoftDelete(int id)
        {
            var ungVien = new UngVien();
            ungVien.Id = id;
            ungVien.IsDeleted = true;
            ungVien.UpdatedTime = DateTime.Now;

            return ungVienDAO.SoftDelete(ungVien);
        }

        public List<UngVien> GetAll(CvGetAllInput input = null)
        {
            return ungVienDAO.GetAll(input);
        }

        public UngVien GetById(int id)
        {
            var input = new CvGetAllInput()
            {
                Id = id
            };
            var list = ungVienDAO.GetAll(input);
            return list.FirstOrDefault();
        }

        public List<UngVien> GetByUngVienId(int ungVienId)
        {
            var input = new CvGetAllInput()
            {
                UngVienId = ungVienId
            };
            var list = GetAll(input);
            return list;
        }
    }
}
