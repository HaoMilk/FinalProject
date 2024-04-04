using FinalProject.Database;
using FinalProject.Database.Entities;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace FinalProject.Common.DAO
{
    internal class CongTyDAO
    {
        private readonly DatabaseConnection dbConnection;

        public CongTyDAO()
        {
            dbConnection = new DatabaseConnection();
        }

        public int CheckExist(string MST)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "SELECT COUNT(1) FROM CongTy WHERE MST = @MST";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MST", MST);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log or rethrow)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }
        }

        public int Add(CongTy Cty)
        {
            try
            {
                using (var connection = dbConnection.Connection)
                {
                    string query = "INSERT INTO CongTy(ID, PassWord, Email, TenCongTy, DiaChi, TenCEO, MST) VALUES(@ID, @PassWord, @Email, @TenCongTy, @DiaChi, @TenCEO, @MST)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", Cty.ID);
                    cmd.Parameters.AddWithValue("@PassWord", Cty.PassWord);
                    cmd.Parameters.AddWithValue("@Email", Cty.Email);
                    cmd.Parameters.AddWithValue("@TenCongTy", Cty.TenCongTy);
                    cmd.Parameters.AddWithValue("@DiaChi", Cty.Diachi);
                    cmd.Parameters.AddWithValue("@TenCEO", Cty.CEO);
                    cmd.Parameters.AddWithValue("@MST", Cty.MST);
                    MessageBox.Show("Thêm Thành Công");
                    return cmd.ExecuteNonQuery();
                    
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log or rethrow)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
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
                    PassWord = @PassWord,
                    Email = @Email,
                    TenCongTy = @TenCongTy, 
                    DiaChi = @DiaChi, 
                    TenCEO = @TenCEO,
                    MST = @MST
                    WHERE MST = @ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", Cty.ID);
                    cmd.Parameters.AddWithValue("@PassWord", Cty.PassWord);
                    cmd.Parameters.AddWithValue("@Email", Cty.Email);
                    cmd.Parameters.AddWithValue("@TenCongTy", Cty.TenCongTy);
                    cmd.Parameters.AddWithValue("@DiaChi", Cty.Diachi);
                    cmd.Parameters.AddWithValue("@TenCEO", Cty.CEO);
                    cmd.Parameters.AddWithValue("@MST", Cty.MST);
                    MessageBox.Show("Cập nhật thành công");
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return -1;
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
                    MessageBox.Show("Xoá Thành Công");
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
                // Handle exception (log or rethrow)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }
        }

    }
}
