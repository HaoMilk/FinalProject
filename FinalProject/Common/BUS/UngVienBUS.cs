using FinalProject.Common.DAO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web.UI.WebControls;

namespace FinalProject.Common.BUS
{
    public class UngVienBUS
    {
        private UngVienDAO ungVienDAO = new UngVienDAO();

        /// <summary>
        /// Kiểm tra xem ứng viên có id này đã tồn tại chưa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CheckExist(int id)
        {
            return ungVienDAO.CheckExist(id);
        }

        /// <summary>
        /// Đếm số lượng ứng viên hiện có
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return ungVienDAO.Count();
        }

        /// <summary>
        /// Thêm 1 ứng viên mới vào database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ten"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="diaChi"></param>
        /// <param name="sDT"></param>
        /// <param name="email"></param>
        /// <param name="chuyenMon"></param>
        /// <param name="trangThai"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Thêm 1 ứng viên mới vào database
        /// </summary>
        /// <param name="ungVien"></param>
        /// <returns></returns>
        public int Add(UngVien ungVien)
        {
            return ungVienDAO.Add(ungVien);
        }

        /// <summary>
        /// Cập nhật trạng thái của ứng viên
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trangThai"></param>
        /// <returns></returns>
        public int Update(int id, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string sdt, string email, string chuyenMon, 
            string trangThai, object avatar)
        {
            var ungVien = new UngVien()
            {
                Id = id,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                DiaChi = diaChi,
                SDT = sdt,
                Email = email,
                ChuyenMon = chuyenMon,
                TrangThai = trangThai,
                Avatar = null,
                UpdatedTime = DateTime.Now
            };

            return ungVienDAO.Update(ungVien);
        }

        /// <summary>
        /// Cập nhật thông tin của ứng viên
        /// </summary>
        /// <param name="ungVien"></param>
        /// <returns></returns>
        public int Update(UngVien ungVien)
        {
            return ungVienDAO.Update(ungVien);
        }

        /// <summary>
        /// Xóa ứng viên khỏi database dựa vào id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            var ungVien = new UngVien();
            ungVien.Id = id;
            return ungVienDAO.Delete(ungVien);
        }

        /// <summary>
        /// Gán IsDeleted = true cho ứng viên dựa vào id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int SoftDelete(int id)
        {
            var ungVien = new UngVien();
            ungVien.Id = id;
            ungVien.IsDeleted = true;
            ungVien.UpdatedTime = DateTime.Now;

            return ungVienDAO.SoftDelete(ungVien);
        }

        /// <summary>
        /// Lấy danh sách ứng viên dựa vào input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<UngVien> GetAll(UngVienGetAllInput input = null)
        {
            return ungVienDAO.GetAll(input);
        }

        /// <summary>
        /// Lấy 1 ứng viên dựa vào id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UngVien GetById(int id)
        {
            var input = new UngVienGetAllInput()
            {
                Id = id
            };
            var list = ungVienDAO.GetAll(input);
            return list.FirstOrDefault();
        }

        /// <summary>
        /// Lấy 1 ứng viên dựa vào userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UngVien GetByUserId(int userId)
        {
            var input = new UngVienGetAllInput()
            {
                UserId = userId
            };
            var list = ungVienDAO.GetAll(input);
            return list.FirstOrDefault();
        }
    }
}
