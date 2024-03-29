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
    public class CvDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM CV WHERE Id = '{id}';";
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
                string query = "SELECT COUNT(1) FROM CV WHERE IsDeleted = 0 ;";
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

        public List<CV> GetAll(CvGetAllInput input = null)
        {
            if (input == null)
            {
                input = new CvGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<CV>();
                string query = "SELECT * FROM CV WHERE IsDeleted = 0 ";
                if (input.Id > 0)
                {
                    query += $" AND Id = {input.Id} ";
                }
                if (input.UngVienId > 0)
                {
                    query += $" AND UngVienId = {input.UngVienId} ";
                }

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var cv = new CV();
                        cv.Id = reader.GetInt32(0);
                        cv.Ten = reader.GetString(1);
                        cv.UngVienId = reader.GetInt32(2);
                        cv.Link = reader.GetString(3);
                        cv.MoTa = reader.GetString(4);
                        cv.TrangThai = reader.GetString(5);
                        cv.IsDeleted = reader.GetBoolean(6);
                        cv.CreatedTime = reader.GetDateTime(7);
                        cv.UpdatedTime = reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8);
                       // cv.ViTriUngTuyen = reader.GetString(9);
                      //  cv.KyNang = reader.GetString(10);
                       // cv.NgoaiNgu = reader.GetString(11);
                       // cv.TinHoc = reader.GetString(12);
                        //cv.HocVan = reader.GetString(13);
                       // cv.HoatDong = reader.GetString(14);
                        //cv.ChungChi = reader.GetString(15);
                        //cv.MucTieu = reader.GetString(16);
                        //cv.KinhNghiem = reader.GetString(17);
                       
                        list.Add(cv);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(CV CV)
        {
            string query = "INSERT INTO CV (Ten, UngVienId, Link, MoTa, TrangThai, IsDeleted, CreatedTime, UpdatedTime," +
                " ViTriUngTuyen,KyNang,  NgoaiNgu , TinHoc, HocVan, HoatDong, ChungChi, MucTieu, KinhNghiem) " +
                $"VALUES (N'{CV.Ten}', {CV.UngVienId}, " +
                $" N'{CV.Link}', N'{CV.MoTa}'," +
                $" N'{CV.TrangThai}', 0," +
                $" '{CV.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL," +
                $" N'{CV.ViTriUngTuyen}', N'{CV.KyNang}'," +
                $" N'{CV.NgoaiNgu}',N'{CV.TinHoc}', N'{CV.HocVan}'," +
                $" N'{CV.HoatDong}', N'{CV.ChungChi}'," +
                $" N'{CV.MucTieu}', N'{CV.KinhNghiem}'); ";


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
        public int Update(CV CV)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE CV SET " +
                    $"Ten = N'{CV.Ten}', " + 
                    $"MoTa = N'{CV.MoTa}', " +
                    $"Link = N'{CV.Link}', " +             
                    $"TrangThai = '{CV.TrangThai}', " +
                    $"UpdatedTime = '{CV.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {CV.Id};";

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
        public int Delete(CV CV)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM CV WHERE Id = {CV.Id};";

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

        public int SoftDelete(CV CV)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE CV SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{CV.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {CV.Id};";

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
