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
                string query = $"SELECT COUNT(1) FROM [User] WHERE Id = '{id}';";
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
                string query = "SELECT COUNT(1) FROM [User] WHERE IsDeleted = 0 ;";
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

        public List<User> GetAll(UserGetAllInput input = null)
        {
            if (input == null)
            {
                input = new UserGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<User>();
                string query = "SELECT * FROM [User] WHERE IsDeleted = 0 ";
                if (input.Id > 0)
                {
                    query += $" AND Id = {input.Id} ";
                }
                if (!string.IsNullOrEmpty(input.Username))
                {
                    query += $" AND UserName = N'{input.Username}' ";
                }
                if (!string.IsNullOrEmpty(input.Password))
                {
                    query += $" AND [Password] = N'{input.Password}' ";
                }
                if (!string.IsNullOrEmpty(input.Email))
                {
                    query += $" AND Email = N'{input.Email}' ";
                }
                if (!string.IsNullOrEmpty(input.Status))
                {
                    query += $" AND [Status] = N'{input.Status}' ";
                }
                if (!string.IsNullOrEmpty(input.Phone))
                {
                    query += $" AND Phone = N'{input.Phone}' ";
                }
                if (!string.IsNullOrEmpty(input.Role))
                {
                    query += $" AND [Role] = N'{input.Role}' ";
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

        public int Add(User user)
        {
            string query = $@"
                INSERT INTO [User](UserName, [Password], Email, [Status], IsDeleted, Phone, [Role], CreatedTime, UpdatedTime)
                VALUES (
                    N'{user.Username}', 
                    N'{user.Password}', 
                    N'{user.Email}', 
                    N'{user.Status}', 
                    0, 
                    N'{user.Phone}', 
                    N'{user.Role}', 
                    '{user.CreatedTime:yyyy-MM-dd hh:mm:ss}', 
                    NULL);
                SELECT MAX(Id) AS LastInsertedID FROM [User];";

            using (dbConnection.Connection)
            {
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
        public int Update(User user)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                UPDATE [User] SET 
                    UserName = N'{user.Username}', 
                    [Password] = N'{user.Password}', 
                    Email = N'{user.Email}', 
                    [Status] = N'{user.Status}', 
                    Phone = N'{user.Phone}', 
                    [Role] = N'{user.Role}', 
                    UpdatedTime = '{user.UpdatedTime:yyyy-MM-dd hh:mm:ss}'
                    WHERE Id = {user.Id};
                ";

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

        public int Delete(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM [User] WHERE Id = {id};";

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

        public int SoftDelete(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE [User] SET 
                        IsDeleted = 1, 
                        UpdatedTime = '{DateTime.Now:yyyy-MM-dd hh:mm:ss}'
                        WHERE Id = {id};";

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

        public User GetById(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT * FROM [User] WHERE Id = {id} ;";
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
