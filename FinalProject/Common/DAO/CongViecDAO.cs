using FinalProject.Common.Helper;
using FinalProject.Database;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Common.DAO
{
    public class CongViecDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM CongViec WHERE Id = '{id}';";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<CongViec> GetAll()
        {
            using (dbConnection.Connection)
            {
                var list = new List<CongViec>();
                string query = "SELECT * FROM CongViec WHERE IsDeleted = 0;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var congViec = new CongViec();
                        congViec.Id = reader.GetIntValue(0);
                        congViec.Ten = reader.GetStringValue(1);
                        congViec.TenCongTy = reader.GetStringValue(2);
                        congViec.Nganh = reader.GetStringValue(3);
                        congViec.ViTriTuyenDung = reader.GetStringValue(4);
                        congViec.MucLuong = reader.GetDecimalValue(5);
                        congViec.DiaDiem = reader.GetStringValue(6);
                        congViec.TrinhDoHocVan = reader.GetStringValue(7);
                        congViec.GioiTinh = reader.GetStringValue(8);
                        congViec.LienHe = reader.GetStringValue(9);
                        congViec.MoTa = reader.GetStringValue(10);
                        congViec.QuyenLoi = reader.GetStringValue(11);
                        congViec.KinhNghiem = reader.GetStringValue(14);
                        congViec.YeuCauUngVien = reader.GetStringValue(15);;
                        congViec.TrangThai = reader.GetStringValue(18);
                        congViec.SoLuong = reader.GetIntValue(19);
                        congViec.IsDeleted = reader.GetBooleanValue(21);
                        congViec.CreatedTime = reader.GetDateTimeValue(22);
                        congViec.UpdatedTime = reader.GetDateTimeValueNullable(23);
                        congViec.IdCongTy = reader.GetIntValue(24);

                        list.Add(congViec);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(CongViec congViec)
        {
            string query = $@"
                INSERT INTO CongViec (Ten, TenCongTy, Nganh, ViTriTuyenDung, MucLuong, DiaDiem, 
                    TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, KinhNghiem, KyNang, 
                    TrangThai, SoLuong, IsDeleted, CreatedTime, UpdatedTime, IdCongTy) 
                VALUES (@Ten, @TenCongTy, @Nganh, @ViTriTuyenDung, @MucLuong, @DiaDiem, 
                    @TrinhDoHocVan, @GioiTinh, @LienHe, @MoTa, @QuyenLoi, @KinhNghiem, @KyNang, 
                    , @TrangThai, @SoLuong , @IsDeleted, @CreatedTime, @UpdatedTime, @IdCongTy);";

            using (dbConnection.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@Ten", congViec.Ten);
                cmd.Parameters.AddWithValue("@TenCongTy", congViec.TenCongTy);
                cmd.Parameters.AddWithValue("@Nganh", congViec.Nganh);
                cmd.Parameters.AddWithValue("@ViTriTuyenDung", congViec.ViTriTuyenDung);
                cmd.Parameters.AddWithValue("@MucLuong", congViec.MucLuong);
                cmd.Parameters.AddWithValue("@DiaDiem", congViec.DiaDiem);
                cmd.Parameters.AddWithValue("@TrinhDoHocVan", congViec.TrinhDoHocVan);
                cmd.Parameters.AddWithValue("@GioiTinh", congViec.GioiTinh);
                cmd.Parameters.AddWithValue("@LienHe", congViec.LienHe);
                cmd.Parameters.AddWithValue("@MoTa", congViec.MoTa);
                cmd.Parameters.AddWithValue("@QuyenLoi", congViec.QuyenLoi);
                cmd.Parameters.AddWithValue("@KinhNghiem", congViec.KinhNghiem);
                cmd.Parameters.AddWithValue("@KyNang", congViec.YeuCauUngVien);
                cmd.Parameters.AddWithValue("@TrangThai", congViec.TrangThai);
                cmd.Parameters.AddWithValue("@SoLuong", congViec.SoLuong);
                cmd.Parameters.AddWithValue("@IsDeleted", congViec.IsDeleted);
                cmd.Parameters.AddWithValue("@CreatedTime", congViec.CreatedTime);
                cmd.Parameters.AddWithValue("@UpdatedTime", congViec.UpdatedTime);
                cmd.Parameters.AddWithValue("@IdCongTy", congViec.IdCongTy);           
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public int Update(CongViec CongViec)
        {
            using (dbConnection.Connection)
            {
                string query = @"UPDATE CongViec SET 
                        Ten = @Ten, 
                        TenCongTy = @TenCongTy, 
                        Nganh = @Nganh, 
                        ViTriTuyenDung = @ViTriTuyenDung, 
                        MucLuong = @MucLuong, 
                        DiaDiem = @DiaDiem, 
                        TrinhDoHocVan = @TrinhDoHocVan, 
                        GioiTinh = @GioiTinh, 
                        LienHe = @LienHe, 
                        MoTa = @MoTa, 
                        QuyenLoi = @QuyenLoi, 
                        KinhNghiem = @KinhNghiem, 
                        KyNang = @KyNang, 
                        TrangThai = @TrangThai, 
                        SoLuong = @SoLuong, 
                        IsDeleted = @IsDeleted, 
                        UpdatedTime = @UpdatedTime, 
                        IdCongTy = @IdCongTy 
                    WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@Ten", CongViec.Ten);
                cmd.Parameters.AddWithValue("@TenCongTy", CongViec.TenCongTy);
                cmd.Parameters.AddWithValue("@Nganh", CongViec.Nganh);
                cmd.Parameters.AddWithValue("@ViTriTuyenDung", CongViec.ViTriTuyenDung);
                cmd.Parameters.AddWithValue("@MucLuong", CongViec.MucLuong);
                cmd.Parameters.AddWithValue("@DiaDiem", CongViec.DiaDiem);
                cmd.Parameters.AddWithValue("@TrinhDoHocVan", CongViec.TrinhDoHocVan);
                cmd.Parameters.AddWithValue("@GioiTinh", CongViec.GioiTinh);
                cmd.Parameters.AddWithValue("@LienHe", CongViec.LienHe);
                cmd.Parameters.AddWithValue("@MoTa", CongViec.MoTa);
                cmd.Parameters.AddWithValue("@QuyenLoi", CongViec.QuyenLoi);
                cmd.Parameters.AddWithValue("@KinhNghiem", CongViec.KinhNghiem);
                cmd.Parameters.AddWithValue("@KyNang", CongViec.YeuCauUngVien);
                cmd.Parameters.AddWithValue("@TrangThai", CongViec.TrangThai);
                cmd.Parameters.AddWithValue("@SoLuong", CongViec.SoLuong);
                cmd.Parameters.AddWithValue("@IsDeleted", CongViec.IsDeleted);
                cmd.Parameters.AddWithValue("@UpdatedTime", CongViec.UpdatedTime);
                cmd.Parameters.AddWithValue("@IdCongTy", CongViec.IdCongTy);
                cmd.Parameters.AddWithValue("@Id", CongViec.Id);
                try
                {
                    MessageBox.Show("Thanh Cong");
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public int Delete(CongViec CongViec)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM CongViec WHERE Id = {CongViec.Id};";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int SoftDelete(CongViec congViec)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE CongViec 
                    SET IsDeleted = 1, 
                        UpdatedTime = '{congViec.UpdatedTime:yyyy-MM-dd hh:mm:ss}' 
                    WHERE Id = {congViec.Id};";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public CongViec GetById(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT * FROM CongViec WHERE Id = {id} ;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var congViec = new CongViec();
                        congViec.Id = reader.GetIntValue(0);
                        congViec.Ten = reader.GetStringValue(1);
                        congViec.TenCongTy = reader.GetStringValue(2);
                        congViec.Nganh = reader.GetStringValue(3);
                        congViec.ViTriTuyenDung = reader.GetStringValue(4);
                        congViec.MucLuong = reader.GetDecimalValue(5);
                        congViec.DiaDiem = reader.GetStringValue(6);
                        congViec.TrinhDoHocVan = reader.GetStringValue(7);
                        congViec.GioiTinh = reader.GetStringValue(8);
                        congViec.LienHe = reader.GetStringValue(9);
                        congViec.MoTa = reader.GetStringValue(10);
                        congViec.QuyenLoi = reader.GetStringValue(11);
                        congViec.KinhNghiem = reader.GetStringValue(14);
                        congViec.YeuCauUngVien = reader.GetStringValue(15);;
                        congViec.TrangThai = reader.GetStringValue(18);
                        congViec.SoLuong = reader.GetIntValue(19);
                        congViec.IsDeleted = reader.GetBooleanValue(21);
                        congViec.CreatedTime = reader.GetDateTimeValue(22);
                        congViec.UpdatedTime = reader.GetDateTimeValueNullable(23);
                        congViec.IdCongTy = reader.GetIntValue(24);
                        return congViec;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return null;
            }
        }
    }
}
