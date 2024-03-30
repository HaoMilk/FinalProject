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
                    string query = "INSERT INTO CongTy(MST, TenCongTy, DiaChi, TenCEO)" + $"VALUES ('{Cty.MST}', '{Cty.TenCongTy}', '{Cty.Diachi}', '{Cty.TenCEO})";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    MessageBox.Show("Thanh Cong");
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
