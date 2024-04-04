using FinalProject.Common.Helper;
using FinalProject.Database;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DAO
{
    public class CvDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int CheckExist(int id)
        {
            using (dbConnection.Connection)
            {
                string query = $"SELECT COUNT(1) FROM CV WHERE Id = '{id}';";
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
                string query = "SELECT COUNT(1) FROM CV WHERE IsDeleted = 0 ;";
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

        public List<CV> GetAll(CvGetAllInput input = null)
        {
            if (input == null)
            {
                input = new CvGetAllInput();
            }

            using (dbConnection.Connection)
            {
                var list = new List<CV>();
                string query = "SELECT * FROM CV WHERE IsDeleted = 0 ";
                if (input.Id > 0)
                {
                    query += $" AND Id = {input.Id} ";
                }
                if (input.UngVienId > 0)
                {
                    query += $" AND UngVienId = {input.UngVienId} ";
                }
                if (!string.IsNullOrEmpty(input.Ten))
                {
                    query += $" AND Ten LIKE N'%{input.Ten}%' ";
                }

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var cv = new CV();
                        cv.Id = reader.GetIntValue(0);
                        cv.Ten = reader.GetStringValue(1);
                        cv.UngVienId = reader.GetIntValue(2);
                        cv.Link = reader.GetStringValue(3);
                        cv.MoTa = reader.GetStringValue(4);
                        cv.TrangThai = reader.GetStringValue(5);
                        cv.IsDeleted = reader.GetBooleanValue(6);
                        cv.CreatedTime = reader.GetDateTimeValue(7);
                        cv.UpdatedTime = reader.GetDateTimeValueNullable(8);
                        cv.ViTriUngTuyen = reader.GetStringValue(9);
                        cv.KyNang = reader.GetStringValue(10);
                        cv.NgoaiNgu = reader.GetStringValue(11);
                        cv.TinHoc = reader.GetStringValue(12);
                        cv.HocVan = reader.GetStringValue(13);
                        cv.HoatDong = reader.GetStringValue(14);
                        cv.ChungChi = reader.GetStringValue(15);
                        cv.MucTieu = reader.GetStringValue(16);
                        cv.KinhNghiem = reader.GetStringValue(17);

                        list.Add(cv);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }

        public int Add(CV CV)
        {
            string query = $@"
                INSERT INTO CV (Ten, UngVienId, Link, MoTa, TrangThai, IsDeleted, CreatedTime, UpdatedTime, 
                    ViTriUngTuyen, KyNang, NgoaiNgu, TinHoc, HocVan, HoatDong, ChungChi, MucTieu, KinhNghiem) 
                VALUES (@Ten, @UngVienId, @Link, @MoTa, @TrangThai, @IsDeleted, @CreatedTime, @UpdatedTime, 
                    @ViTriUngTuyen, @KyNang, @NgoaiNgu, @TinHoc, @HocVan, @HoatDong, @ChungChi, @MucTieu, @KinhNghiem);";

            using (dbConnection.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@Ten", CV.Ten);
                cmd.Parameters.AddWithValue("@UngVienId", CV.UngVienId);
                cmd.Parameters.AddWithValue("@Link", CV.Link);
                cmd.Parameters.AddWithValue("@MoTa", CV.MoTa);
                cmd.Parameters.AddWithValue("@TrangThai", CV.TrangThai);
                cmd.Parameters.AddWithValue("@IsDeleted", CV.IsDeleted);
                cmd.Parameters.AddWithValue("@CreatedTime", CV.CreatedTime);
                cmd.Parameters.AddWithValue("@UpdatedTime", DBNull.Value);
                cmd.Parameters.AddWithValue("@ViTriUngTuyen", CV.ViTriUngTuyen);
                cmd.Parameters.AddWithValue("@KyNang", CV.KyNang);
                cmd.Parameters.AddWithValue("@NgoaiNgu", CV.NgoaiNgu);
                cmd.Parameters.AddWithValue("@TinHoc", CV.TinHoc);
                cmd.Parameters.AddWithValue("@HocVan", CV.HocVan);
                cmd.Parameters.AddWithValue("@HoatDong", CV.HoatDong);
                cmd.Parameters.AddWithValue("@ChungChi", CV.ChungChi);
                cmd.Parameters.AddWithValue("@MucTieu", CV.MucTieu);
                cmd.Parameters.AddWithValue("@KinhNghiem", CV.KinhNghiem);

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
        public int Update(CV cv)
        {
            using (dbConnection.Connection)
            {
                string query = $@"
                    UPDATE CV 
                    SET Ten = @Ten, 
                        Link = @Link, 
                        MoTa = @MoTa,
                        TrangThai = @TrangThai, 
                        ViTriUngTuyen = @ViTriUngTuyen, 
                        KyNang = @KyNang,
                        NgoaiNgu = @NgoaiNgu,
                        TinHoc = @TinHoc,
                        HocVan = @HocVan,
                        HoatDong = @HoatDong,
                        ChungChi = @ChungChi,
                        MucTieu = @MucTieu,
                        KinhNghiem = @KinhNghiem,
                        UpdatedTime = @UpdatedTime 
                    WHERE Id = @Id;";

                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@Ten", cv.Ten);
                cmd.Parameters.AddWithValue("@Link", cv.Link);
                cmd.Parameters.AddWithValue("@MoTa", cv.MoTa);               
                cmd.Parameters.AddWithValue("@TrangThai", cv.TrangThai);
                cmd.Parameters.AddWithValue("@ViTriUngTuyen", cv.ViTriUngTuyen);
                cmd.Parameters.AddWithValue("@KyNang", cv.KyNang);
                cmd.Parameters.AddWithValue("@NgoaiNgu", cv.NgoaiNgu);
                cmd.Parameters.AddWithValue("@TinHoc", cv.TinHoc);
                cmd.Parameters.AddWithValue("@HocVan", cv.HocVan);
                cmd.Parameters.AddWithValue("@HoatDong", cv.HoatDong);
                cmd.Parameters.AddWithValue("@ChungChi", cv.ChungChi);
                cmd.Parameters.AddWithValue("@MucTieu", cv.MucTieu);
                cmd.Parameters.AddWithValue("@KinhNghiem", cv.KinhNghiem);
                cmd.Parameters.AddWithValue("@UpdatedTime", cv.UpdatedTime);
                cmd.Parameters.AddWithValue("@Id", cv.Id);

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

        public int Delete(CV cv)
        {
            using (dbConnection.Connection)
            {
                string query = $"DELETE FROM CV WHERE Id = {cv.Id};";

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

        public int SoftDelete(CV cv)
        {
            using (dbConnection.Connection)
            {
                string query = $"UPDATE CV SET " +
                    $"IsDeleted = 1, " +
                    $"UpdatedTime = '{cv.UpdatedTime:yyyy-MM-dd hh:mm:ss}' " +
                    $"WHERE Id = {cv.Id};";

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
        public List<CV> GetByUngVienId(int ungVienId)
        {
            List<CV> list = new List<CV>();
            using (dbConnection.Connection)
            {
                string query = $"SELECT * FROM CV WHERE UngVienId = {ungVienId} AND IsDeleted = 0 ;";
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var cv = new CV();
                        cv.Id = reader.GetIntValue(0);
                        cv.Ten = reader.GetStringValue(1);
                        cv.UngVienId = reader.GetIntValue(2);
                        cv.Link = reader.GetStringValue(3);
                        cv.MoTa = reader.GetStringValue(4);
                        cv.TrangThai = reader.GetStringValue(5);
                        cv.IsDeleted = reader.GetBooleanValue(6);
                        cv.CreatedTime = reader.GetDateTimeValue(7);
                        cv.UpdatedTime = reader.GetDateTimeValueNullable(8);
                        cv.ViTriUngTuyen = reader.GetStringValue(9);
                        cv.KyNang = reader.GetStringValue(10);
                        cv.NgoaiNgu = reader.GetStringValue(11);
                        cv.TinHoc = reader.GetStringValue(12);
                        cv.HocVan = reader.GetStringValue(13);
                        cv.HoatDong = reader.GetStringValue(14);
                        cv.ChungChi = reader.GetStringValue(15);
                        cv.MucTieu = reader.GetStringValue(16);
                        cv.KinhNghiem = reader.GetStringValue(17);

                        list.Add(cv);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return list;
            }
        }
    }
}
