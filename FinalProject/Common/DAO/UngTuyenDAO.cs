using FinalProject.Common.Helper;
using FinalProject.Database;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DAO
{
    public class UngTuyenDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM ungTuyen WHERE Id = '{id}';";
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

        public int Count()
        {
            using (dbConnection.Connection)
            {
                string query = "SELECT COUNT(1) FROM ungTuyen WHERE IsDeleted = 0 ;";
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

        public List<UngTuyenDTO> GetAll(UngTuyenGetAllInput input = null)
        {
            if (input == null)
            {
                input = new UngTuyenGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<UngTuyenDTO>();
                string query = $@"
                    SELECT ungTuyen.*, UngVien.HoTen, CongViec.Ten, CongViec.TenCongTy, Cv.Ten, CV.Link, UngVien.Email
                    FROM ungTuyen 
                    INNER JOIN UngVien ON ungTuyen.UngVienId = UngVien.Id
                    INNER JOIN CongViec ON ungTuyen.CongViecId = CongViec.Id
                    INNER JOIN CV ON ungTuyen.CvId = CV.Id
                    INNER JOIN CongTy ON CongViec.IdCongTy = CongTy.ID
                    WHERE ungTuyen.IsDeleted = 0 AND UngVien.IsDeleted = 0 AND CongViec.IsDeleted = 0 
                          AND CV.IsDeleted = 0 ";

                if (input.Id != 0)
                {
                    query += $" AND ungTuyen.Id = {input.Id}";
                }
                if (!string.IsNullOrWhiteSpace(input.TrangThai))
                {
                    query += $" AND ungTuyen.TrangThai = N'{input.TrangThai}' ";
                }
                if(input.IdCongTy!=0)
                {
                    query += $"AND CongTy.ID = '{input.IdCongTy}'";
                }
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var ungTuyenDto = new UngTuyenDTO();
                        ungTuyenDto.Id = reader.GetIntValue(0);
                        ungTuyenDto.CongViecId = reader.GetIntValue(1);
                        ungTuyenDto.UngVienId = reader.GetIntValue(2);
                        ungTuyenDto.CvId = reader.GetIntValue(3);
                        ungTuyenDto.TrangThai = reader.GetStringValue(4);
                        ungTuyenDto.MoTa = reader.GetStringValue(5);
                        ungTuyenDto.IsDeleted = reader.GetBooleanValue(6);
                        ungTuyenDto.CreatedTime = reader.GetDateTimeValue(7);
                        ungTuyenDto.UpdatedTime = reader.GetDateTimeValueNullable(8);
                        ungTuyenDto.ThoiGianPhongVan = reader.GetDateTimeValueNullable(9);
                        ungTuyenDto.DiaDiemPhongVan = reader.GetStringValue(10);
                        ungTuyenDto.NguoiPhongVan = reader.GetStringValue(11);
                        ungTuyenDto.KetQuaPhongVan = reader.GetStringValue(12);
                        ungTuyenDto.TenUngVien = reader.GetStringValue(13);
                        ungTuyenDto.TenCongViec = reader.GetStringValue(14);
                        ungTuyenDto.TenCongTy = reader.GetStringValue(15);
                        ungTuyenDto.TenCv = reader.GetStringValue(16);
                        ungTuyenDto.LinkCv = reader.GetStringValue(17);
                        ungTuyenDto.Email = reader.GetStringValue(18);

                        list.Add(ungTuyenDto);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(UngTuyen ungTuyen)
        {
            string query = $@"
            INSERT INTO ungTuyen (CongViecId, UngVienId, CvId, TrangThai, MoTa, IsDeleted, CreatedTime, UpdatedTime )
            VALUES ({ungTuyen.CongViecId}, {ungTuyen.UngVienId}, {ungTuyen.CvId}, N'{ungTuyen.TrangThai}',
                N'{ungTuyen.MoTa}', 0, '{ungTuyen.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL
            );";

            using (dbConnection.Connection)
            {
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
        public int Update(UngTuyen ungTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $@" UPDATE UngTuyen SET UpdatedTime = @UpdatedTime ";

                if (ungTuyen.ThoiGianPhongVan.HasValue)
                {
                    query += $", ThoiGianPhongVan = @ThoiGianPhongVan ";
                }
                if (!string.IsNullOrEmpty(ungTuyen.DiaDiemPhongVan))
                {
                    query += $", DiaDiemPhongVan = @DiaDiemPhongVan ";
                }
                if (!string.IsNullOrEmpty(ungTuyen.NguoiPhongVan))
                {
                    query += $", NguoiPhongVan = @NguoiPhongVan ";
                }
                if (!string.IsNullOrEmpty(ungTuyen.KetQuaPhongVan))
                {
                    query += $", KetQuaPhongVan = @KetQuaPhongVan ";
                }
                if (!string.IsNullOrEmpty(ungTuyen.TrangThai))
                {
                    query += $", TrangThai = @TrangThai ";
                }
                if (!string.IsNullOrEmpty(ungTuyen.MoTa))
                {
                    query += $", MoTa = @MoTa ";
                }
                query += "  WHERE Id = @Id;";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                    cmd.Parameters.AddWithValue("@Id", ungTuyen.Id);
                    cmd.Parameters.AddWithValue("@UpdatedTime", ungTuyen.UpdatedTime ?? DateTime.Now);
                    cmd.Parameters.AddWithValue("@ThoiGianPhongVan", ungTuyen.ThoiGianPhongVan ?? DateTime.Now);
                    cmd.Parameters.AddWithValue("@DiaDiemPhongVan", ungTuyen.DiaDiemPhongVan ?? string.Empty);
                    cmd.Parameters.AddWithValue("@NguoiPhongVan", ungTuyen.NguoiPhongVan ?? string.Empty);
                    cmd.Parameters.AddWithValue("@KetQuaPhongVan", ungTuyen.KetQuaPhongVan ?? string.Empty);
                    cmd.Parameters.AddWithValue("@TrangThai", ungTuyen.TrangThai ?? string.Empty);
                    cmd.Parameters.AddWithValue("@MoTa", ungTuyen.MoTa ?? string.Empty);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public int Delete(UngTuyen UngTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM ungTuyen WHERE Id = {UngTuyen.Id};";

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

        public int SoftDelete(UngTuyen UngTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE ungTuyen 
                    SET IsDeleted = 1, 
                        UpdatedTime = '{UngTuyen.UpdatedTime:yyyy-MM-dd hh:mm:ss}' 
                    WHERE Id = {UngTuyen.Id};";

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
        public int UpdateTrangThai(UngTuyen ungTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE ungTuyen 
                    SET TrangThai = N'{ungTuyen.TrangThai}'  
                    WHERE Id = {ungTuyen.Id};";

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
    }
}
