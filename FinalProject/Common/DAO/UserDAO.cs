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
    public class UserDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM User WHERE Id = '{id}';";
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
                string query = "SELECT COUNT(1) FROM User WHERE IsDeleted = 0 ;";
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

        public List<User> GetAll(UserGetAllInput input = null)
        {
            if (input == null)
            {
                input = new UserGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<User>();
                string query = "SELECT * FROM User WHERE IsDeleted = 0 ";
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
                        var user = new User();
                        user.Id = reader.GetIntValue(0);
                        user.Username = reader.GetStringValue(1);
                        user.Password = reader.GetStringValue(2);
                        user.Email = reader.GetStringValue(3);
                        user.Status = reader.GetStringValue(4);
                        user.IsDeleted = reader.GetBooleanValue(5);
                        user.Phone = reader.GetStringValue(6);
                        user.Role = reader.GetStringValue(7);
                        user.CreatedTime = reader.GetDateTimeValue(8);
                        user.UpdatedTime = reader.GetDateTimeValueNullable(9);

                        list.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(User User)
        {
            string query = $@"
                INSERT INTO User(Username, Password, Email, Status, IsDeleted, Phone, Role, CreatedTime, UpdatedTime)
                VALUES
                (N'{User.Username}', N'{User.Password}', N'{User.Email}', N'{User.Status}', 0, N'{User.Phone}', 
                 N'{User.Role}', '{User.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL);
            ";

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
        public int Update(User User)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                UPDATE User SET 
                    Username = N'{User.Username}', 
                    Password = N'{User.Password}', 
                    Email = N'{User.Email}', 
                    Status = N'{User.Status}', 
                    Phone = N'{User.Phone}', 
                    Role = N'{User.Role}', 
                    UpdatedTime = '{User.UpdatedTime:yyyy-MM-dd hh:mm:ss}'
                    WHERE Id = {User.Id};
                ";

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
        public int Delete(User User)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM User WHERE Id = {User.Id};";

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

        public int SoftDelete(User User)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE User SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{User.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {User.Id};";

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
        public User GetById(int id)
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
                        var user = new User();
                        user.Id = reader.GetIntValue(0);
                        user.Username = reader.GetStringValue(1);
                        user.Password = reader.GetStringValue(2);
                        user.Email = reader.GetStringValue(3);
                        user.Status = reader.GetStringValue(4);
                        user.IsDeleted = reader.GetBooleanValue(5);
                        user.Phone = reader.GetStringValue(6);
                        user.Role = reader.GetStringValue(7);
                        user.CreatedTime = reader.GetDateTimeValue(8);
                        user.UpdatedTime = reader.GetDateTimeValueNullable(9);

                        return user;
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
