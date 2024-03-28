using FinalProject.Database;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject.Common.DAO
{
    internal class CongTyDAO
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();
        public void Add(CongTy Cty)
        {
            string query = "INSERT INTO CongTy(MST, TenCongTy, DiaChi, TenCEO)" +
            $"VALUES(N'{Cty.MST}, {Cty.Ten}), {Cty.Diachi},{Cty.TenCEO};";
            using (dbConnection.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, dbConnection.Connection);
                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("thanh cong!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("khong thanh cong!" + ex.Message);
                }
            }

        }
    }
}
