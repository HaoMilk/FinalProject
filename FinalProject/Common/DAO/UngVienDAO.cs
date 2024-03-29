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
    public class UngVienDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM UngVien WHERE Id = '{id}';";
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
                string query = "SELECT COUNT(1) FROM UngVien WHERE IsDeleted = 0 ;";
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

        public List<UngVien> GetAll(CvGetAllInput input = null)
        {
            if (input == null)
            {
                input = new CvGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<UngVien>();
                string query = "SELECT * FROM UngVien WHERE IsDeleted = 0 ";
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
                        var ungVien = new UngVien();
                        ungVien.Id = reader.GetInt32(0);
                        ungVien.HoTen = reader.GetString(1);
                        ungVien.NgaySinh = reader.GetDateTime(2);
                        ungVien.GioiTinh = reader.GetString(3);
                        ungVien.DiaChi = reader.GetString(4);
                        ungVien.SDT = reader.GetString(5);
                        ungVien.Email = reader.GetString(6);
                        ungVien.ChuyenMon = reader.GetString(7);
                        ungVien.TrangThai = reader.GetString(8);
                        ungVien.IsDeleted = reader.GetBoolean(9);
                        ungVien.CreatedTime = reader.GetDateTime(10);
                        ungVien.UpdatedTime = reader.IsDBNull(11) ? (DateTime?)null : reader.GetDateTime(11);
                       // ungVien.ViTriUngTuyen = reader.GetString(9);
                      //  ungVien.KyNang = reader.GetString(10);
                       // ungVien.NgoaiNgu = reader.GetString(11);
                       // ungVien.TinHoc = reader.GetString(12);
                        //ungVien.HocVan = reader.GetString(13);
                       // ungVien.HoatDong = reader.GetString(14);
                        //ungVien.ChungChi = reader.GetString(15);
                        //ungVien.MucTieu = reader.GetString(16);
                        //ungVien.KinhNghiem = reader.GetString(17);
                       
                        list.Add(ungVien);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(UngVien UngVien)
        {
            string query = "INSERT INTO UngVien (HoTen, NgaySinh, GioiTinh, DiaChi, " +
                ", SDT, Email, ChuyenMon, TrangThai, IsDeleted, CreatedTime, UpdatedTime) " +
                $"VALUES (N'{UngVien.HoTen}', {UngVien.NgaySinh}, " +
                $" N'{UngVien.GioiTinh}', N'{UngVien.DiaChi}', N'{UngVien.SDT}'" +
                $" N'{UngVien.Email}', N'{UngVien.ChuyenMon}', N'{UngVien.TrangThai}', 0," +
                $" '{UngVien.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL); ";


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
        public int Update(UngVien UngVien)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE UngVien SET " +
                    $"Ten = N'{UngVien.HoTen}', " + 
                    $"NgaySinh = N'{UngVien.NgaySinh}', " +
                    $"GioiTinh = N'{UngVien.GioiTinh}', " +
                    $" DiaChi = N'{UngVien.DiaChi}', " +
                    $" SDT = N'{UngVien.SDT}', " +
                    $" Email = N'{UngVien.Email}'," +
                    $" ChuyenMon = N'{UngVien.ChuyenMon}' " +             
                    $"TrangThai = '{UngVien.TrangThai}', " +
                    $"UpdatedTime = '{UngVien.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {UngVien.Id};";

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
        public int Delete(UngVien UngVien)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM UngVien WHERE Id = {UngVien.Id};";

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

        public int SoftDelete(UngVien UngVien)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE UngVien SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{UngVien.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {UngVien.Id};";

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
        public UngVien GetByUngVienId(int id)
        {
            using (dbConnection.Connection)
            {
                UngVien ungVien;
                string query = $"SELECT * FROM  WHERE Id = {id} ;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ungVien = new UngVien();
                        ungVien.HoTen = reader.GetString(0);
                       

                        return ungVien;
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
