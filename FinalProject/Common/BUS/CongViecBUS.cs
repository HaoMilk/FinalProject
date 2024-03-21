using FinalProject.Common.DAO;
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

        public int CheckExist(int id)
        {
            return congViecDAO.CheckExist(id);
        }

        public int Add(int id, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string ngoaiNgu, string tinHoc,
             string kinhNghiem, string kyNang, DateTime fromDate,
             DateTime toDate, string trangThai, int soLuong,
             string link)
        {
            var congViec = new CongViec();
            congViec.Id = id;
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
            congViec.NgoaiNgu = ngoaiNgu;
            congViec.TinHoc = tinHoc;
            congViec.KinhNghiem = kinhNghiem;
            congViec.KyNang = kyNang;
            congViec.FromDate = fromDate ;
            congViec.ToDate =toDate;
            congViec.TrangThai = trangThai;
            congViec.SoLuong = soLuong;
            congViec.Link = link;
            congViec.IsDeleted = false;
            congViec.CreatedTime = DateTime.Now;
            congViec.UpdatedTime = null;

            return congViecDAO.Add(congViec);
        }

        public int Update(int id, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string ngoaiNgu, string tinHoc,
             string kinhNghiem, string kyNang, DateTime fromDate,
             DateTime toDate, string trangThai, int soLuong,
             string link, bool isDeleted)
        {
            var congViec = new CongViec();
            congViec.Id = id;
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
            congViec.NgoaiNgu = ngoaiNgu;
            congViec.TinHoc = tinHoc;
            congViec.KinhNghiem = kinhNghiem;
            congViec.KyNang = kyNang;
            congViec.FromDate = fromDate;
            congViec.ToDate = toDate;
            congViec.TrangThai = trangThai;
            congViec.SoLuong = soLuong;
            congViec.Link = link;
            congViec.IsDeleted = isDeleted;
            congViec.UpdatedTime = DateTime.Now;

            return congViecDAO.Update(congViec);
        }

        public int Update(CongViec congViec)
        {
            return congViecDAO.Update(congViec);
        }

        public int Delete(int id)
        {
            var congViec = new CongViec();
            congViec.Id = id;
            return congViecDAO.Delete(congViec);
        }

        public int SoftDelete(int id)
        {
            var congViec = new CongViec();
            congViec.Id = id;
            congViec.IsDeleted = true;
            congViec.UpdatedTime = DateTime.Now;

            return congViecDAO.SoftDelete(congViec);
        }
        public CongViec GetById(int id)
        {
            return congViecDAO.GetById(id);
        }
    }
}
