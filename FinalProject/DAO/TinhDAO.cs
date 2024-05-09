using FinalProject.Common.Helper;
using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FinalProject.DAO
{
    public class TinhDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        /// <summary>
        /// Kiểm tra tỉnh có tồn tại không dựa vào id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Đếm tổng số tỉnh
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            using (dbConnection.Connection)
            {
                string query = "SELECT COUNT(1) FROM Tinh WHERE IsDeleted = 0;";
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

        /// <summary>
        /// Lấy danh sách tỉnh
        /// </summary>
        /// <returns></returns>
        public List<Tinh> GetAll()
        {
            using (dbConnection.Connection)
            {
                var list = new List<Tinh>();
                string query = "SELECT * FROM Tinh WHERE IsDeleted = 0;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var tinh = new Tinh();
                        tinh.Id = reader.GetIntValue(0);
                        tinh.Code = reader.GetStringValue(1);
                        tinh.Ten = reader.GetStringValue(2);
                        tinh.TrangThai = reader.GetStringValue(3);
                        tinh.IsDeleted = reader.GetBooleanValue(4);
                        tinh.CreatedTime = reader.GetDateTimeValue(5);
                        tinh.UpdatedTime = reader.GetDateTimeValueNullable(6);

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

        /// <summary>
        /// Thêm mới tỉnh vào database
        /// </summary>
        /// <param name="tinh"></param>
        /// <returns></returns>
        public int Add(Tinh tinh)
        {
            string query = $@"
                INSERT INTO Tinh (Code, Ten, TrangThai, IsDeleted, CreatedTime, UpdatedTime ) 
                VALUES ('{tinh.Code}', N'{tinh.Ten}', '{tinh.TrangThai}', {tinh.IsDeleted}, 
                        '{tinh.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL);";

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

        /// <summary>
        /// Cập nhật thông tin tỉnh
        /// </summary>
        /// <param name="tinh"></param>
        /// <returns></returns>
        public int Update(Tinh tinh)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE Tinh 
                    SET Code = '{tinh.Code}', 
                        Ten = N'{tinh.Ten}', 
                        TrangThai = '{tinh.TrangThai}', 
                        IsDeleted = {tinh.IsDeleted}, 
                        UpdatedTime = '{tinh.UpdatedTime:yyyy-MM-dd hh:mm:ss}' 
                    WHERE Id = {tinh.Id};";

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

        /// <summary>
        /// Xóa tỉnh khỏi database
        /// </summary>
        /// <param name="Tinh"></param>
        /// <returns></returns>
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
                }
            }
        }

        /// <summary>
        /// Cập nhật IsDeleted = 1 để xóa mềm tỉnh
        /// </summary>
        /// <param name="tinh"></param>
        /// <returns></returns>
        public int SoftDelete(Tinh tinh)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE Tinh 
                    SET IsDeleted = 1, 
                        UpdatedTime = '{tinh.UpdatedTime:yyyy-MM-dd hh:mm:ss}' 
                    WHERE Id = {tinh.Id};";

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
    }
}
