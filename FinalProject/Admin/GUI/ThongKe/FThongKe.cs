using FinalProject.Admin.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject.Admin.GUI
{
    public partial class FThongKe : Form
    {
        string connectionString = Properties.Settings.Default.connectionString;
        public FThongKe()
        {
            InitializeComponent();
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT DISTINCT Nganh, COUNT(*) AS SoLuong FROM congviec GROUP BY Nganh";  
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                BDCot.Series["BDCot"].Points.Clear();
                                BDTron.Series["BDTron"].Points.Clear();
                                while (reader.Read())
                                {
                                    string nganh = reader.GetString(0); 
                                    int soLuong = reader.GetInt32(1);

                                    BDCot.Series["BDCot"].Points.AddXY(nganh, soLuong);
                                    BDTron.Series["BDTron"].Points.AddXY(nganh, soLuong);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found in the 'congviec' table!");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
    }
}
