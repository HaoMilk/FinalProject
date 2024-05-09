using FinalProject.Common.DTO;
using FinalProject.Common.Helper;
using FinalProject.DAO;
using FinalProject.Database;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.BUS
{
    public class CongViecBUS
    {
        #region EF6
        public List<CongViec> Search(CongViecGetAllInput input)
        {
            using (var db = new JobManagerContext())
            {
                var query = db.CongViec
                    .Where(x => x.IsDeleted == false)
                    .WhereIf(
                        !string.IsNullOrEmpty(input.Search),
                        x => x.TenCongTy.Contains(input.Search) || x.ViTriTuyenDung.Contains(input.Search))
                    .WhereIf(!string.IsNullOrWhiteSpace(input.DiaDiem), x => x.DiaDiem.Contains(input.DiaDiem))
                    .WhereIf(!string.IsNullOrWhiteSpace(input.Nganh), x => x.Nganh.Contains(input.Nganh))
                    .WhereIf(!string.IsNullOrWhiteSpace(input.KinhNghiem), x => x.KinhNghiem.Contains(input.KinhNghiem))
                    .WhereIf(input.MinLuong != null, x => x.MucLuong >= input.MinLuong)
                    .WhereIf(input.MaxLuong != null, x => x.MucLuong <= input.MaxLuong)
                    .WhereIf(!string.IsNullOrWhiteSpace(input.GioiTinh), x => x.GioiTinh == input.GioiTinh)
                    .WhereIf(input.FromDate != null, x => x.FromDate >= input.FromDate)
                    .WhereIf(input.ToDate != null, x => x.ToDate <= input.ToDate)
                    .WhereIf(input.IdCongTy != null, x => x.IdCongTy == input.IdCongTy)
                    .WhereIf(input.FromId != 0, x => x.Id >= input.FromId)
                    .WhereIf(input.ToId != 0, x => x.Id <= input.ToId);

                return query.ToList();
            }
        }

        public int CheckExist(int id)
        {
            using (var db = new JobManagerContext())
            {
                return db.CongViec.Count(x => x.Id == id);
            }
        }

        public int Add(string tenCongTy, int IdCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong, DateTime fromdate)
        {
            try
            {
                using (var db = new JobManagerContext())
                {
                    var ct = new CongViec();
                    ct.TenCongTy = tenCongTy;
                    ct.IdCongTy = IdCongTy;
                    ct.Ten = ten;
                    ct.Nganh = nganh;
                    ct.ViTriTuyenDung = viTriTuyenDung;
                    ct.MucLuong = mucLuong;
                    ct.DiaDiem = diaDiem;
                    ct.TrinhDoHocVan = trinhDoHocVan;
                    ct.GioiTinh = gioiTinh;
                    ct.LienHe = lienHe;
                    ct.MoTa = moTa;
                    ct.QuyenLoi = quyenLoi;
                    ct.KinhNghiem = kinhNghiem;
                    ct.YeuCauUngVien = yeuCauUngVien;
                    ct.SoLuong = soLuong;
                    ct.IsDeleted = false;
                    ct.CreatedTime = DateTime.Now;
                    ct.UpdatedTime = DateTime.Now;
                    ct.FromDate = fromdate;
                    db.CongViec.Add(ct);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                UCMessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int Update(int Id, int idCongTy, string tenCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong, DateTime fromdate)
        {
            try
            {
                using (var db = new JobManagerContext())
                {
                    var ct = db.CongViec.Find(Id);
                    ct.IdCongTy = idCongTy;
                    ct.TenCongTy = tenCongTy;
                    ct.Ten = ten;
                    ct.Nganh = nganh;
                    ct.ViTriTuyenDung = viTriTuyenDung;
                    ct.MucLuong = mucLuong;
                    ct.DiaDiem = diaDiem;
                    ct.TrinhDoHocVan = trinhDoHocVan;
                    ct.GioiTinh = gioiTinh;
                    ct.LienHe = lienHe;
                    ct.MoTa = moTa;
                    ct.QuyenLoi = quyenLoi;
                    ct.KinhNghiem = kinhNghiem;
                    ct.YeuCauUngVien = yeuCauUngVien;
                    ct.SoLuong = soLuong;
                    ct.UpdatedTime = DateTime.Now;
                    ct.FromDate = fromdate;
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                UCMessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int Delete(int id)
        {
            using (var db = new JobManagerContext())
            {
                var congViec = db.CongViec.Find(id);
                db.CongViec.Remove(congViec);
                return db.SaveChanges();
            }
        }

        public int SoftDelete(int id)
        {
            using (var db = new JobManagerContext())
            {
                var congViec = db.CongViec.Find(id);
                congViec.IsDeleted = true;
                congViec.UpdatedTime = DateTime.Now;
                return db.SaveChanges();
            }
        }
        public CongViec GetById(int id)
        {
            using (var db = new JobManagerContext())
            {
                return db.CongViec.Find(id);
            }
        }
        public List<CongViec> GetByIDCty(CongViecGetAllInput input, int comanyId)
        {
            using (var db = new JobManagerContext())
            {
                return db.CongViec.Where(x => x.IdCongTy == comanyId).ToList();
            }
        }
        #endregion EF6

        #region DAO
        private CongViecDAO congViecDAO = new CongViecDAO();
        public List<CongViec> SearchDAO(CongViecGetAllInput input)
        {
            return congViecDAO.GetAll(input);
        }

        public int CheckExistDAO(int id)
        {
            return congViecDAO.CheckExist(id);
        }

        public int AddDAO(string tenCongTy, int IdCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong, DateTime fromdate)
        {
            try
            {
                CongViec congViec = new CongViec();
                congViec.TenCongTy = tenCongTy;
                congViec.IdCongTy = IdCongTy;
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
                congViec.IsDeleted = false;
                congViec.CreatedTime = DateTime.Now;
                congViec.UpdatedTime = DateTime.Now;
                congViec.FromDate = fromdate;
                if (!congViec.CheckNull())
                {
                    return congViecDAO.Add(congViec);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                UCMessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int UpdateDAO(int Id, int idCongTy, string tenCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong, DateTime fromdate)
        {
            try
            {
                var congViec = new CongViec();
                congViec.Id = Id;
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
                congViec.UpdatedTime = DateTime.Now;
                congViec.FromDate = fromdate;
                if (!congViec.CheckNull())
                {
                    return congViecDAO.Update(congViec);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                UCMessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int DeleteDAO(int id)
        {
            var congViec = new CongViec();
            congViec.Id = id;
            return congViecDAO.Delete(congViec);
        }

        public int SoftDeleteDAO(int id)
        {
            var congViec = new CongViec();
            congViec.Id = id;
            congViec.IsDeleted = true;
            congViec.UpdatedTime = DateTime.Now;

            return congViecDAO.SoftDelete(congViec);
        }
        public CongViec GetByIdDAO(int id)
        {
            return congViecDAO.GetById(id);
        }
        public List<CongViec> GetByIDCtyDAO(CongViecGetAllInput input, int comanyId)
        {
            return congViecDAO.GetByIDCty(input, comanyId);
        }
        #endregion DAO
    }
}
