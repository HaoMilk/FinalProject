using FinalProject.Common.DTO;
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

        public List<CongViec> GetAll(CongViecGetAllInput input)
        {
            if (input == null)
            {
                input = new CongViecGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<CongViec>();
                string query = "SELECT * FROM CongViec WHERE IsDeleted = 0 ";

                if (input.FromId > 0 && input.ToId > input.FromId)
                {
                    query = query + $" AND (Id >= {input.FromId} AND Id < {input.ToId}) ";
                }

                if (!string.IsNullOrWhiteSpace(input.Search))
                {
                    query = query + $" AND ViTriTuyenDung LIKE '{input.Search}' ";
                }
/*                if (input.NgheNghiep != "Tất cả ngành nghề")
                {
                    query = query + $" AND Nganh LIKE {input.NgheNghiep} ";
                }*/
                if (input.MinLuong.HasValue || input.MaxLuong.HasValue )
                {
                    query += " AND (";
                    if (input.MinLuong.HasValue)
                    {
                        query += $" MucLuong >= {input.MinLuong} ";
                    }
                    if (input.MaxLuong.HasValue)
                    {
                        if (input.MinLuong.HasValue)
                        {
                            query += " AND ";
                        }
                        query += $" MucLuong <= {input.MaxLuong} ";
                    }
                    query += ")";

                }

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CongViec congViec = ReadValue(reader);
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
                INSERT INTO CongViec ( Ten, TenCongTy, Nganh, ViTriTuyenDung, MucLuong, DiaDiem, 
                    TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, KinhNghiem, YeuCauUngVien,
                    FromDate, SoLuong, IsDeleted, CreatedTime, UpdatedTime, IdCongTy) 
                VALUES (@Id, @Ten, @TenCongTy, @Nganh, @ViTriTuyenDung, @MucLuong, @DiaDiem, 
                    @TrinhDoHocVan, @GioiTinh, @LienHe, @MoTa, @QuyenLoi, @KinhNghiem, @YeuCauUngVien, 
                    @FromDate, @SoLuong , @IsDeleted, @CreatedTime, @UpdatedTime, @IdCongTy);";

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
                cmd.Parameters.AddWithValue("@YeuCauUngVien", congViec.YeuCauUngVien);
                cmd.Parameters.AddWithValue("@FromDate", congViec.FromDate);
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
        public int Update(CongViec congViec)
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
                YeuCauUngVien = @YeuCau, 
                FromDate = @FromDate,
                SoLuong = @SoLuong, 
                IsDeleted = @IsDeleted, 
                UpdatedTime = @UpdatedTime,            
                IdCongTy = @IdCongTy 
                WHERE Id = @Id";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                    cmd.Parameters.AddWithValue("@Id", congViec.Id);
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
                    cmd.Parameters.AddWithValue("@YeuCau", congViec.YeuCauUngVien);
                    cmd.Parameters.AddWithValue("@SoLuong", congViec.SoLuong);
                    cmd.Parameters.AddWithValue("@IsDeleted", congViec.IsDeleted);
                    cmd.Parameters.AddWithValue("@UpdatedTime", congViec.UpdatedTime);
                    cmd.Parameters.AddWithValue("@IdCongTy", congViec.IdCongTy);
                    cmd.Parameters.AddWithValue("@FromDate", congViec.FromDate);
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
                        return ReadValue(reader); ;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return null;
            }
        }
        public List<CongViec> GetByIDCty(int companyId)
        {
            List<CongViec> congViecList = new List<CongViec>();
            using (dbConnection.Connection)
            {
                string query = @"SELECT *FROM CongViec cv
                         JOIN CongTy ct ON cv.IdCongTy = ct.Id
                         WHERE cv.IdCongTy = @CompanyId";
                SqlCommand command = new SqlCommand(query, dbConnection.Connection);
                command.Parameters.AddWithValue("@CompanyId", companyId);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CongViec congViec = ReadValue(reader);
                        congViecList.Add(congViec);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ hoặc ghi log
                    throw ex;
                }
            }
            return congViecList;
        }
        public CongViec ReadValue(SqlDataReader reader)
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
            congViec.KinhNghiem = reader.GetStringValue(12);
            congViec.YeuCauUngVien = reader.GetStringValue(13); ;
            congViec.FromDate = reader.GetDateTimeValue(14);
            congViec.SoLuong = reader.GetIntValue(16);
            congViec.IsDeleted = reader.GetBooleanValue(17);
            congViec.CreatedTime = reader.GetDateTimeValue(18);
            congViec.UpdatedTime = reader.GetDateTimeValueNullable(19);
            congViec.IdCongTy = reader.GetIntValue(20);
            return congViec;
        }
    }

}
