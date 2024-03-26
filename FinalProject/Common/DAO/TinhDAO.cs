using FinalProject.Database;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DAO
{
    public class TinhDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM Tinh WHERE Id = '{id}';";
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

        public List<Tinh> GetAll()
        {
            using (dbConnection.Connection)
            {
                var list = new List<Tinh>();
                string query = "SELECT * FROM Tinh;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var tinh = new Tinh();
                        tinh.Id = reader.GetInt32(0);
                        tinh.Code = reader.GetString(1);
                        tinh.Ten = reader.GetString(2);
                        tinh.TrangThai = reader.GetString(3);
                        tinh.IsDeleted = reader.GetBoolean(4);
                        tinh.CreatedTime = reader.GetDateTime(5);
                        tinh.UpdatedTime = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);

                        list.Add(tinh);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(Tinh Tinh)
        {
            string query = "INSERT INTO Tinh (Code, Ten, TrangThai, IsDeleted, CreatedTime, UpdatedTime ) " +
                $"VALUES ('{Tinh.Code}', N'{Tinh.Ten}', '{Tinh.TrangThai}', {Tinh.IsDeleted}, '{Tinh.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL); ";

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
        public int Update(Tinh Tinh)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE Tinh SET " +
                    $"Code = '{Tinh.Code}', " +
                    $"Ten = N'{Tinh.Ten}', " +
                    $"TrangThai = '{Tinh.TrangThai}', " +
                    $"IsDeleted = {Tinh.IsDeleted}, " +
                    $"UpdatedTime = '{Tinh.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {Tinh.Id};";

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
        public int Delete(Tinh Tinh)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM Tinh WHERE Id = {Tinh.Id};";

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

        public int SoftDelete(Tinh Tinh)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE Tinh SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{Tinh.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {Tinh.Id};";

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
