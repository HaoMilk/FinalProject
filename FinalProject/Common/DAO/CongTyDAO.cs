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
                return -1;
            }
        }

        public int Add(CongTy Cty)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "INSERT INTO CongTy(ID, Email, TenCongTy, DiaChi, TenCEO, MST) VALUES(@ID, @Email, @TenCongTy, @DiaChi, @TenCEO, @MST)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", Cty.ID);
                    cmd.Parameters.AddWithValue("@Email", Cty.Email);
                    cmd.Parameters.AddWithValue("@TenCongTy", Cty.TenCongTy);
                    cmd.Parameters.AddWithValue("@DiaChi", Cty.Diachi);
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
        public int Edit(CongTy Cty)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = @"UPDATE CongTy SET 
                    ID = @ID,
                    Email = @Email,
                    TenCongTy = @TenCongTy, 
                    DiaChi = @DiaChi, 
                    TenCEO = @TenCEO,
                    MST = @MST
                    WHERE MST = @ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", Cty.ID);
                    cmd.Parameters.AddWithValue("@Email", Cty.Email);
                    cmd.Parameters.AddWithValue("@TenCongTy", Cty.TenCongTy);
                    cmd.Parameters.AddWithValue("@DiaChi", Cty.Diachi);
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
        public List<CongTy> GetAll()
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "SELECT * FROM CongTy WHERE IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    List<CongTy> congTyList = new List<CongTy>();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CongTy congTy = new CongTy();
                        congTy.ID = reader.GetInt32(0);
                        congTy.Email = reader.GetString(1);
                        congTy.TenCongTy = reader.GetString(2);
                        congTy.Diachi = reader.GetString(3);
                        congTy.CEO = reader.GetString(4);
                        congTy.MST = reader.GetString(5);
                        congTy.CreatedTime = reader.GetDateTime(6);
                        congTy.UpdatedTime = reader.GetDateTime(7);
                        congTy.IsDeleted = reader.GetBoolean(8);
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
                        congTy.ID = reader.GetInt32(0);
                        congTy.Email = reader.GetString(1);
                        congTy.TenCongTy = reader.GetString(2);
                        congTy.Diachi = reader.GetString(3);
                        congTy.CEO = reader.GetString(4);
                        congTy.MST = reader.GetString(5);
                        congTy.CreatedTime = reader.GetDateTime(6);
                        congTy.UpdatedTime = reader.GetDateTime(7);
                        congTy.IsDeleted = reader.GetBoolean(8);

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
