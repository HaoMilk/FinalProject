using FinalProject.Common.DAO;
using FinalProject.Common.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.LinkLabel;

namespace FinalProject.Common.BUS
{
    public class CongViecBUS
    {
        private CongViecDAO congViecDAO = new CongViecDAO();
        public List<CongViec> Search(CongViecGetAllInput input)
        {
            return congViecDAO.GetAll(input);
        }

        public int CheckExist(int id)
        {
            return congViecDAO.CheckExist(id);
        }

        public int Add(string tenCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong, DateTime fromdate)
        {
            try
            {
                CongViec congViec = new CongViec();
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
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int Update(int Id, int idCongTy, string tenCongTy, string ten, string nganh, string viTriTuyenDung,
            decimal mucLuong, string diaDiem, string trinhDoHocVan,
            string gioiTinh, string lienHe, string moTa,
            string quyenLoi, string kinhNghiem, string yeuCauUngVien, int soLuong , DateTime fromdate)
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
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int Delete(int id)
        {
            var congViec = new CongViec();
            congViec.Id = id;
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
