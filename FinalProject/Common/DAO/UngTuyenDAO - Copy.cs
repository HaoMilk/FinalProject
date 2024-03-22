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
    public class UngTuyenDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM CongViec WHERE Id = '{id}';";
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

        public List<CongViec> GetAll()
        {
            using (dbConnection.Connection)
            {
                var list = new List<CongViec>();
                string query = "SELECT * FROM CongViec;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var congViec = new CongViec();
                        congViec.Id = reader.GetInt32(0);
                        congViec.Ten = reader.GetString(1);
                        congViec.Nganh = reader.GetString(2);
                        congViec.ViTriTuyenDung = reader.GetString(3);
                        congViec.MucLuong = reader.GetDecimal(4);
                        congViec.DiaDiem = reader.GetString(5);
                        congViec.TrinhDoHocVan = reader.GetString(6);
                        congViec.GioiTinh = reader.GetString(7);
                        congViec.LienHe = reader.GetString(8);
                        congViec.MoTa = reader.GetString(9);
                        congViec.QuyenLoi = reader.GetString(10);
                        congViec.NgoaiNgu = reader.GetString(11);
                        congViec.TinHoc = reader.GetString(12);
                        congViec.KinhNghiem = reader.GetString(13);
                        congViec.KyNang = reader.GetString(14);
                        congViec.FromDate = reader.IsDBNull(15) ? (DateTime?)null : reader.GetDateTime(15);
                        congViec.ToDate = reader.IsDBNull(16) ? (DateTime?)null : reader.GetDateTime(16);
                        congViec.TrangThai = reader.GetString(17);
                        congViec.SoLuong = reader.GetInt32(18);
                        congViec.Link = reader.GetString(19);
                        congViec.IsDeleted = reader.GetBoolean(20);
                        congViec.CreatedTime = reader.GetDateTime(21);
                        congViec.UpdatedTime = reader.IsDBNull(22) ? (DateTime?)null : reader.GetDateTime(22);

                        list.Add(congViec);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(CongViec CongViec)
        {
            string query = "INSERT INTO CongViec (Id, Ten, Nganh, ViTriTuyenDung, MucLuong," +
                " DiaDiem, TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, NgoaiNgu," +
                " TinHoc, KinhNghiem, KyNang, FromDate, ToDate, TrangThai," +
                " SoLuong, Link, IsDeleted, CreatedTime, UpdatedTime ) " +
                $"VALUES ('{CongViec.Id}', N'{CongViec.Ten}', " +
                $"N'{CongViec.Nganh}',N'{CongViec.ViTriTuyenDung}'," +
                $" {CongViec.MucLuong},N'{CongViec.DiaDiem}', " +
                $" N'{CongViec.TrinhDoHocVan}', N'{CongViec.GioiTinh}'," +
                $"N'{CongViec.LienHe}', N'{CongViec.MoTa}'," +
                $"N'{CongViec.QuyenLoi}', N'{CongViec.NgoaiNgu}'," +
                $"N'{CongViec.TinHoc}', N'{CongViec.KinhNghiem}'," +
                $"N'{CongViec.KyNang}', '{CongViec.FromDate}'," +
                $"'{CongViec.ToDate}', N'{CongViec.TrangThai}'," +
                $"'{CongViec.SoLuong}," +
                $"N'{CongViec.Link}', {CongViec.IsDeleted}," +
                $" '{CongViec.CreatedTime:yyyy-MM-dd hh:mm:ss}', NULL); ";

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
        public int Update(CongViec CongViec)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE CongViec SET " +
                    $"Ten = N'{CongViec.Ten}', " +
                    $"Nganh = N'{CongViec.Nganh}', " +
                    $"ViTriTuyenDung = N'{CongViec.ViTriTuyenDung}', " +
                    $"MucLuong = {CongViec.MucLuong}, " +
                    $"DiaDiem = N'{CongViec.DiaDiem}', " +
                    $"TrinhDoHocVan = N'{CongViec.TrinhDoHocVan}', " +
                    $"GioiTinh = N'{CongViec.GioiTinh}', " +
                    $"LienHe = N'{CongViec.LienHe}', " +
                    $"MoTa = N'{CongViec.MoTa}', " +
                    $"QuyenLoi = N'{CongViec.QuyenLoi}', " +
                    $"NgoaiNgu = N'{CongViec.NgoaiNgu}', " +
                    $"TinHoc = N'{CongViec.TinHoc}', " +
                    $"KinhNghiem = N'{CongViec.KinhNghiem}', " +
                    $"KyNang = N'{CongViec.KyNang}', " +
                    $"FromDate = '{CongViec.FromDate}', " +
                    $"ToDate = '{CongViec.ToDate}', " +               
                    $"TrangThai = '{CongViec.TrangThai}', " +
                    $"SoLuong = {CongViec.SoLuong}, " +
                    $"Link = N'{CongViec.Link}', " +                
                    $"IsDeleted = {CongViec.IsDeleted}, " +
                    $"UpdatedTime = '{CongViec.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {CongViec.Id};";

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
        public int Delete(CongViec CongViec)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM CongViec WHERE Id = {CongViec.Id};";

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

        public int SoftDelete(CongViec CongViec)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE CongViec SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{CongViec.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {CongViec.Id};";

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
        public CongViec GetById(int id)
        {
            using (dbConnection.Connection)
            {
                CongViec congViec;
                string query = $"SELECT * FROM CongViec WHERE Id = {id} ;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        congViec = new CongViec();
                        congViec.Id = reader.GetInt32(0);
                        congViec.Ten = reader.GetString(1);
                        congViec.Nganh = reader.GetString(2);
                        congViec.ViTriTuyenDung = reader.GetString(3);
                        congViec.MucLuong = reader.GetDecimal(4);
                        congViec.DiaDiem = reader.GetString(5);
                        congViec.TrinhDoHocVan = reader.GetString(6);
                        congViec.GioiTinh = reader.GetString(7);
                        congViec.LienHe = reader.GetString(8);
                        congViec.MoTa = reader.GetString(9);
                        congViec.QuyenLoi = reader.GetString(10);
                        congViec.NgoaiNgu = reader.GetString(11);
                        congViec.TinHoc = reader.GetString(12);
                        congViec.KinhNghiem = reader.GetString(13);
                        congViec.KyNang = reader.GetString(14);
                        congViec.FromDate = reader.IsDBNull(15) ? (DateTime?)null : reader.GetDateTime(15);
                        congViec.ToDate = reader.IsDBNull(16) ? (DateTime?)null : reader.GetDateTime(16);
                        congViec.TrangThai = reader.GetString(17);
                        congViec.SoLuong = reader.GetInt32(18);
                        congViec.Link = reader.GetString(19);
                        congViec.IsDeleted = reader.GetBoolean(20);
                        congViec.CreatedTime = reader.GetDateTime(21);
                        congViec.UpdatedTime = reader.IsDBNull(22) ? (DateTime?)null : reader.GetDateTime(22);
                        return congViec;
                  
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
