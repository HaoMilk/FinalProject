using FinalProject.Common.DAO;
using FinalProject.Common.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace FinalProject.Common.BUS
{
    public class CongViecBUS
    {
        private CongViecDAO congViecDAO = new CongViecDAO();
        public List<CongViec> GetAll()
        {
            return congViecDAO.GetAll();
        }

        public List<CongViec> Search(CongViecGetAllInput input)
        {
            return congViecDAO.GetAll(input);
        }

        public int CheckExist(int id)
        {
            return congViecDAO.CheckExist(id);
        }

        public int Add(int idCongTy, string tenCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong)
        {
            var congViec = new CongViec();
            congViec.IdCongTy = idCongTy;
            congViec.TenCongTy = tenCongTy;
            congViec.Ten = ten;
            congViec.Nganh =nganh;
            congViec.ViTriTuyenDung = viTriTuyenDung;
            congViec.MucLuong = mucLuong;
            congViec.DiaDiem = diaDiem;
            congViec.TrinhDoHocVan = trinhDoHocVan;
            congViec.GioiTinh = gioiTinh;
            congViec.LienHe = lienHe;
            congViec.MoTa = moTa;
            congViec.QuyenLoi = quyenLoi;
            congViec.KinhNghiem = kinhNghiem;
            congViec.YeuCauUngVien = yeuCauUngVien;
            congViec.SoLuong = soLuong;
            congViec.IsDeleted = false;
            congViec.CreatedTime = DateTime.Now;
            congViec.UpdatedTime = DateTime.Now;

            return congViecDAO.Add(congViec);
        }

        public int Update(int idCongTy, string tenCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong, bool isDeleted)
        {
            var congViec = new CongViec();
            congViec.IdCongTy = idCongTy;
            congViec.TenCongTy = tenCongTy;
            congViec.Ten = ten;
            congViec.Nganh = nganh;
            congViec.ViTriTuyenDung = viTriTuyenDung;
            congViec.MucLuong = mucLuong;
            congViec.DiaDiem = diaDiem;
            congViec.TrinhDoHocVan = trinhDoHocVan;
            congViec.GioiTinh = gioiTinh;
            congViec.LienHe = lienHe;
            congViec.MoTa = moTa;
            congViec.QuyenLoi = quyenLoi;
            congViec.KinhNghiem = kinhNghiem;
            congViec.YeuCauUngVien = yeuCauUngVien;
            congViec.SoLuong = soLuong;
            congViec.IsDeleted = isDeleted;
            congViec.UpdatedTime = DateTime.Now;

            return congViecDAO.Update(congViec);
        }

        public int Update(CongViec congViec)
        {
            return congViecDAO.Update(congViec);
        }

        public int Delete(int idCongTy)
        {
            var congViec = new CongViec();
            congViec.IdCongTy = idCongTy;
            return congViecDAO.Delete(congViec);
        }

        public int SoftDelete(int idCongTy)
        {
            var congViec = new CongViec();
            congViec.IdCongTy = idCongTy;
            congViec.IsDeleted = true;
            congViec.UpdatedTime = DateTime.Now;

            return congViecDAO.SoftDelete(congViec);
        }
        public CongViec GetById(int id)
        {
            return congViecDAO.GetById(id);
        }
        public List<CongViec> GetByIDCty(int id)
        {
            return congViecDAO.GetByIDCty(id);
        }
    }
}
