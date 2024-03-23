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
                string query = $"SELECT COUNT(1) FROM UngTuyen WHERE Id = '{id}';";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }

        public int Count()
        {
            using (dbConnection.Connection)
            {
                string query = "SELECT COUNT(1) FROM UngTuyen WHERE IsDeleted = 0 ;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    return -1;
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
                string query = @"
                    SELECT UngTuyen.*, UngVien.HoTen, CongViec.Ten, Cv.Ten, CV.Link
                    FROM UngTuyen 
                    INNER JOIN UngVien ON UngTuyen.UngVienId = UngVien.Id
                    INNER JOIN CongViec ON UngTuyen.CongViecId = CongViec.Id
                    INNER JOIN CV ON UngTuyen.CvId = CV.Id
                    WHERE UngTuyen.IsDeleted = 0 AND UngVien.IsDeleted = 0 AND CongViec.IsDeleted = 0 AND CV.IsDeleted = 0 ";

                if (input.Id != 0)
                {
                    query += $" AND UngTuyen.Id = {input.Id}";
                }

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var ungTuyenDto = new UngTuyenDTO();
                        ungTuyenDto.Id = reader.GetInt32(1);
                        ungTuyenDto.CongViecId = reader.GetInt32(2);
                        ungTuyenDto.UngVienId = reader.GetInt32(3);
                        ungTuyenDto.CvId = reader.GetInt32(4);
                        ungTuyenDto.TrangThai = reader.GetString(5);
                        ungTuyenDto.MoTa = reader.GetString(6);
                        ungTuyenDto.TrangThai = reader.GetString(7);
                        ungTuyenDto.IsDeleted = reader.GetBoolean(8);
                        ungTuyenDto.CreatedTime = reader.GetDateTime(9);
                        ungTuyenDto.UpdatedTime = reader.IsDBNull(10) ? (DateTime?)null : reader.GetDateTime(10);
                        ungTuyenDto.TenUngVien = reader.GetString(11);
                        ungTuyenDto.TenCongViec = reader.GetString(12);
                        ungTuyenDto.TenCv = reader.GetString(13);
                        ungTuyenDto.LinkCv = reader.GetString(14);

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
            string query = "INSERT INTO UngTuyen (CongViecId, UngVienId, CvId, TrangThai, MoTa, IsDeleted, CreatedTime, UpdatedTime ) " +
                $"VALUES ({ungTuyen.CongViecId}, " +
                $" {ungTuyen.UngVienId}, {ungTuyen.CvId}, " +
                $" N'{ungTuyen.TrangThai}', N'{ungTuyen.MoTa}', " +
                $" 0, '{ungTuyen.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL); ";

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
                    return -1;
                }
            }
        }
        public int Update(UngTuyen UngTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE UngTuyen SET " +
                    $"TrangThai = N'{UngTuyen.TrangThai}', " +
                    $"MoTa = N'{UngTuyen.MoTa}', " +
                    $"UpdatedTime = '{UngTuyen.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {UngTuyen.Id};";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                    return -1;
                }
            }
        }
        public int Delete(UngTuyen UngTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM UngTuyen WHERE Id = {UngTuyen.Id};";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                    return -1;
                }
            }
        }

        public int SoftDelete(UngTuyen UngTuyen)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE UngTuyen SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{UngTuyen.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {UngTuyen.Id};";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                    return -1;
                }
            }
        }
    }
}
