using FinalProject.Common.DTO;
using FinalProject.Common.Helper;
using FinalProject.Database;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace FinalProject.Common.DAO
{
    internal class CongTyDAO
    {
        private readonly DatabaseConnection dbConnection;

        public CongTyDAO()
        {
            dbConnection = new DatabaseConnection();
        }

        public int CheckExist(int Id)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "SELECT COUNT(1) FROM CongTy WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Add(CongTy Cty)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = $@"INSERT INTO CongTy(Email, TenCongTy, DiaChi, TenCEO, MST, CreatedTime, IsDeleted, UserId) 
                        VALUES(@Email, @TenCongTy, @DiaChi, @TenCEO, @MST, @CreatedTime, 0, @UserId)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", Cty.ID);
                    cmd.Parameters.AddWithValue("@Email", Cty.Email);
                    cmd.Parameters.AddWithValue("@TenCongTy", Cty.TenCongTy);
                    cmd.Parameters.AddWithValue("@DiaChi", Cty.DiaChi);
                    cmd.Parameters.AddWithValue("@TenCEO", Cty.CEO);
                    cmd.Parameters.AddWithValue("@MST", Cty.MST);
                    cmd.Parameters.AddWithValue("@CreatedTime", Cty.CreatedTime);
                    cmd.Parameters.AddWithValue("@UserId", Cty.UserId);
                    return cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Edit(CongTy Cty)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = @"UPDATE CongTy SET 
                    Email = @Email,
                    TenCongTy = @TenCongTy, 
                    DiaChi = @DiaChi, 
                    TenCEO = @TenCEO,
                    MST = @MST
                    WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", Cty.ID);
                    cmd.Parameters.AddWithValue("@Email", Cty.Email);
                    cmd.Parameters.AddWithValue("@TenCongTy", Cty.TenCongTy);
                    cmd.Parameters.AddWithValue("@DiaChi", Cty.DiaChi);
                    cmd.Parameters.AddWithValue("@TenCEO", Cty.CEO);
                    cmd.Parameters.AddWithValue("@MST", Cty.MST);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int Delete(CongTy congTy)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM CongTy WHERE Id = {congTy.ID};";

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

        public int SoftDelete(CongTy congTy)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE CongViec 
                    SET IsDeleted = 1, 
                        UpdatedTime = '{congTy.UpdatedTime:yyyy-MM-dd hh:mm:ss}' 
                    WHERE Id = {congTy.ID};";

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

        public int Count()
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "SELECT COUNT(1) FROM CongTy WHERE IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CongTy> GetAll(CongTyGetAllInput input = null)
        {
            if (input == null)
            {
                input = new CongTyGetAllInput();
            }
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "SELECT * FROM CongTy WHERE IsDeleted = 0 ";
                    if (input.Id > 0)
                    {
                        query += $" AND ID = {input.Id} ";
                    }
                    if (input.TenCongTy != null)
                    {
                        query += $" AND TenCongTy LIKE N'%{input.TenCongTy}%' ";
                    }
                    if (input.UserId > 0)
                    {
                        query += $" AND UserId = {input.UserId} ";
                    }

                    SqlCommand cmd = new SqlCommand(query, connection);
                    List<CongTy> congTyList = new List<CongTy>();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CongTy congTy = new CongTy();
                        congTy.ID = reader.GetIntValue(0);
                        congTy.Email = reader.GetStringValue(1);
                        congTy.TenCongTy = reader.GetString(2);
                        congTy.DiaChi = reader.GetString(3);
                        congTy.CEO = reader.GetString(4);
                        congTy.MST = reader.GetString(5);
                        congTy.CreatedTime = reader.GetDateTimeValue(6);
                        congTy.UpdatedTime = reader.GetDateTimeValueNullable(7);
                        congTy.IsDeleted = reader.GetBooleanValue(8);
                        congTy.UserId = reader.GetIntValue(9);
                        congTyList.Add(congTy);
                    }

                    return congTyList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CongTy GetById(int id)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "SELECT * FROM CongTy WHERE ID = @ID AND IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        CongTy congTy = new CongTy();
                        congTy.ID = reader.GetIntValue(0);
                        congTy.Email = reader.GetStringValue(1);
                        congTy.TenCongTy = reader.GetStringValue(2);
                        congTy.DiaChi = reader.GetStringValue(3);
                        congTy.CEO = reader.GetStringValue(4);
                        congTy.MST = reader.GetStringValue(5);
                        congTy.CreatedTime = reader.GetDateTimeValue(6);
                        congTy.UpdatedTime = reader.GetDateTimeValueNullable(7);
                        congTy.IsDeleted = reader.GetBooleanValue(8);
                        congTy.UserId = reader.GetIntValue(9);

                        return congTy;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
