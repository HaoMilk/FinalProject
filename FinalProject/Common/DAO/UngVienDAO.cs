using FinalProject.Common.Helper;
using FinalProject.Database;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
                    throw ex;
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
                    throw ex;
                }
            }
        }

        public List<UngVien> GetAll(UngVienGetAllInput input = null)
        {
            if (input == null)
            {
                input = new UngVienGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<UngVien>();
                string query = "SELECT * FROM UngVien WHERE IsDeleted = 0 ";
                if (input.Id > 0)
                {
                    query += $" AND Id = {input.Id} ";
                }

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var ungVien = new UngVien();
                        ungVien.Id = reader.GetIntValue(0);
                        ungVien.HoTen = reader.GetStringValue(1);
                        ungVien.NgaySinh = reader.GetDateTimeValue(2);
                        ungVien.GioiTinh = reader.GetStringValue(3);
                        ungVien.DiaChi = reader.GetStringValue(4);
                        ungVien.SDT = reader.GetStringValue(5);
                        ungVien.Email = reader.GetStringValue(6);
                        ungVien.ChuyenMon = reader.GetStringValue(7);
                        ungVien.TrangThai = reader.GetStringValue(8);
                        //ungVien.Avatar = new Bitmap(reader.GetStringValue(9));
                        ungVien.Avatar = null;
                        ungVien.IsDeleted = reader.GetBooleanValue(10);
                        ungVien.CreatedTime = reader.GetDateTimeValue(11);
                        ungVien.UpdatedTime = reader.GetDateTimeValueNullable(12);

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
                }
            }
        }
        public int Update(UngVien UngVien)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE UngVien SET " +
                    $" HoTen = N'{UngVien.HoTen}', " + 
                    $" NgaySinh = '{UngVien.NgaySinh:yyyy-MM-dd}', " +
                    $" GioiTinh = N'{UngVien.GioiTinh}', " +
                    $" DiaChi = N'{UngVien.DiaChi}', " +
                    $" SDT = N'{UngVien.SDT}', " +
                    $" Email = N'{UngVien.Email}'," +
                    $" ChuyenMon = N'{UngVien.ChuyenMon}', " +             
                    $" TrangThai = N'{UngVien.TrangThai}', " +
                    $" UpdatedTime = '{UngVien.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $" WHERE Id = {UngVien.Id};";

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
                }
            }
        }
        public UngVien GetById(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT * FROM  WHERE Id = {id} ;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var ungVien = new UngVien();
                        ungVien.Id = reader.GetIntValue(0);
                        ungVien.HoTen = reader.GetStringValue(1);
                        ungVien.NgaySinh = reader.GetDateTimeValue(2);
                        ungVien.GioiTinh = reader.GetStringValue(3);
                        ungVien.DiaChi = reader.GetStringValue(4);
                        ungVien.SDT = reader.GetStringValue(5);
                        ungVien.Email = reader.GetStringValue(6);
                        ungVien.ChuyenMon = reader.GetStringValue(7);
                        ungVien.TrangThai = reader.GetStringValue(8);
                        //ungVien.Avatar = new Bitmap(reader.GetStringValue(9));
                        ungVien.Avatar = null;
                        ungVien.IsDeleted = reader.GetBooleanValue(10);
                        ungVien.CreatedTime = reader.GetDateTimeValue(11);
                        ungVien.UpdatedTime = reader.GetDateTimeValueNullable(12);

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
