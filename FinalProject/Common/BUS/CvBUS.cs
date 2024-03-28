using FinalProject.Common.DAO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Common.BUS
{
    public class CvBUS
    {
        private CvDAO cvDAO = new CvDAO();

        public int CheckExist(int id)
        {
            return cvDAO.CheckExist(id);
        }

        public int Count()
        {
            return cvDAO.Count();
        }

        public int Add(int id, string ten, int ungVienId, string link,
            string moTa, string trangThai, string viTriUngTuyen, string kyNang,
            string ngoaiNgu, string tinHoc, string hocVan, string hoatDong, string chungChi, string mucTieu, string kinhNghiem)
        {
            var cv = new CV();
            cv.Id = id;
            cv.Ten = ten;
            cv.UngVienId = ungVienId;
            cv.Link = link;
            cv.MoTa = moTa;
            cv.TrangThai = trangThai;
            cv.IsDeleted = false;
            cv.CreatedTime = DateTime.Now;
            cv.UpdatedTime = null;
            cv.ViTriUngTuyen = viTriUngTuyen;
            cv.KyNang = kyNang;
            cv.NgoaiNgu = ngoaiNgu;
            cv.TinHoc = tinHoc;
            cv.HocVan = hocVan;
            cv.HoatDong = hoatDong;
            cv.ChungChi = chungChi;
            cv.MucTieu = mucTieu;
            cv.KinhNghiem = kinhNghiem;

            return cvDAO.Add(cv);
        }

        public int Add(CV cv)
        {
            return cvDAO.Add(cv);
        }

        public int Update(int id, string trangThai, string moTa)
        {
            var cv = new CV()
            {
                Id = id,
                TrangThai = trangThai,
                MoTa = moTa,
                UpdatedTime = DateTime.Now
            };

            return cvDAO.Update(cv);
        }

        public int Update(CV cv)
        {
            return cvDAO.Update(cv);
        }

        public int Delete(int id)
        {
            var cv = new CV();
            cv.Id = id;
            return cvDAO.Delete(cv);
        }

        public int SoftDelete(int id)
        {
            var cv = new CV();
            cv.Id = id;
            cv.IsDeleted = true;
            cv.UpdatedTime = DateTime.Now;

            return cvDAO.SoftDelete(cv);
        }

        public List<CV> GetAll(CvGetAllInput input = null)
        {
            return cvDAO.GetAll(input);
        }

        public CV GetById(int id)
        {
            var input = new CvGetAllInput()
            {
                Id = id
            };
            var list = cvDAO.GetAll(input);
            return list.FirstOrDefault();
        }

        public List<CV> GetByUngVienId(int ungVienId)
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
