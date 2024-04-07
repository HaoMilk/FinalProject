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
                if (input.UserId > 0)
                {
                    query += $" AND UserId = {input.UserId} ";
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
                        ungVien.UserId = reader.GetIntValue(13);

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
            string query = $@"
                INSERT INTO UngVien (HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, ChuyenMon, TrangThai, IsDeleted, CreatedTime, UpdatedTime, UserId) 
                VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @ChuyenMon, @TrangThai, 0, @CreatedTime, NULL, @UserId);";

            using (dbConnection.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@HoTen", UngVien.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", UngVien.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", UngVien.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", UngVien.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", UngVien.SDT);
                cmd.Parameters.AddWithValue("@Email", UngVien.Email);
                cmd.Parameters.AddWithValue("@ChuyenMon", UngVien.ChuyenMon);
                cmd.Parameters.AddWithValue("@TrangThai", UngVien.TrangThai);
                cmd.Parameters.AddWithValue("@CreatedTime", UngVien.CreatedTime);
                cmd.Parameters.AddWithValue("@UserId", UngVien.UserId);

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
                string query = $@"
                    UPDATE UngVien SET 
                        HoTen = @HoTen, 
                        NgaySinh = @NgaySinh, 
                        GioiTinh = @GioiTinh, 
                        DiaChi = @DiaChi, 
                        SDT = @SDT, 
                        Email = @Email, 
                        ChuyenMon = @ChuyenMon, 
                        TrangThai = @TrangThai, 
                        UpdatedTime = @UpdatedTime
                        WHERE Id = {UngVien.Id};";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@HoTen", UngVien.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", UngVien.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", UngVien.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", UngVien.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", UngVien.SDT);
                cmd.Parameters.AddWithValue("@Email", UngVien.Email);
                cmd.Parameters.AddWithValue("@ChuyenMon", UngVien.ChuyenMon);
                cmd.Parameters.AddWithValue("@TrangThai", UngVien.TrangThai);
                cmd.Parameters.AddWithValue("@UpdatedTime", UngVien.UpdatedTime);

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
                        ungVien.UserId = reader.GetIntValue(13);

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
