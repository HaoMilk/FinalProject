using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    public class DatabaseConnection
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        private SqlConnection connection;
        public SqlConnection Connection
        {
            get
            {
                if (connection == null || string.IsNullOrWhiteSpace(connection.ConnectionString))
                {
                    connection = new SqlConnection(connectionString);
                }

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }
        }
    }
}
