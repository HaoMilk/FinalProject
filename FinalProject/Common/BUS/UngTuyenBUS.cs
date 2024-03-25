using FinalProject.Common.DAO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace FinalProject.Common.BUS
{
    public class UngTuyenBUS
    {
        private UngTuyenDAO ungTuyenDAO = new UngTuyenDAO();
        public List<UngTuyenDTO> GetAll()
        {
            return ungTuyenDAO.GetAll();
        }

        public int CheckExist(int id)
        {
            return ungTuyenDAO.CheckExist(id);
        }

        public int Count()
        {
            return ungTuyenDAO.Count();
        }

        public int Add(int id, int congViecId, int ungVienId, int cvId, string trangThai, string moTa)
        {
            var ungTuyen = new UngTuyen();
            ungTuyen.Id = id;
            ungTuyen.CongViecId = congViecId;
            ungTuyen.UngVienId = ungVienId;
            ungTuyen.CvId = cvId;
            ungTuyen.TrangThai = trangThai;
            ungTuyen.MoTa = moTa;
            ungTuyen.IsDeleted = false;
            ungTuyen.CreatedTime = DateTime.Now;
            ungTuyen.UpdatedTime = null;

            return ungTuyenDAO.Add(ungTuyen);
        }

        public int Add(UngTuyen ungTuyen)
        {
            return ungTuyenDAO.Add(ungTuyen);
        }

        public int Update(int id, string trangThai, string moTa)
        {
            var ungTuyen = new UngTuyen()
            {
                Id = id,
                TrangThai = trangThai,
                MoTa = moTa,
                UpdatedTime = DateTime.Now
            };

            return ungTuyenDAO.Update(ungTuyen);
        }

        public int Update(UngTuyen ungTuyen)
        {
            return ungTuyenDAO.Update(ungTuyen);
        }

        public int Delete(int id)
        {
            var ungTuyen = new UngTuyen();
            ungTuyen.Id = id;
            return ungTuyenDAO.Delete(ungTuyen);
        }

        public int SoftDelete(int id)
        {
            var ungTuyen = new UngTuyen();
            ungTuyen.Id = id;
            ungTuyen.IsDeleted = true;
            ungTuyen.UpdatedTime = DateTime.Now;

            return ungTuyenDAO.SoftDelete(ungTuyen);
        }

        public UngTuyenDTO GetById(int id)
        {
            var input = new UngTuyenGetAllInput()
            {
                Id = id
            };
            var list = ungTuyenDAO.GetAll(input);
            return list.FirstOrDefault();
        }
    }
}
