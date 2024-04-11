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
using FinalProject.Admin.GUI.ThongKe;

namespace FinalProject.Admin.GUI
{
    public partial class FThongKe : Form
    {
        string connectionString = Properties.Settings.Default.connectionString;

        public FThongKe()
        {
            InitializeComponent();
        }

        private int DemSoLuongCongViec(string connectionString)
        {
            int Dem = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM CongViec";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    Dem = (int)command.ExecuteScalar();
                }
            }
            return Dem;
        }

        private int DemSoLuongUngVien(string connectionString)
        {
            int Dem = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM UngVien";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    Dem = (int)command.ExecuteScalar();
                }
            }
            return Dem;
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            int soLuongCongViec = DemSoLuongCongViec(connectionString);
            txtSoLuongCongViec.Text = soLuongCongViec.ToString();
            int soLuongUngVien = DemSoLuongUngVien(connectionString);
            txtSoLuongUngVien.Text = soLuongUngVien.ToString();

            // Vẽ biểu đồ tròn
            BDTron.Series.Clear();
            BDTron.Series.Add("Số Lượng");

            BDTron.Series["Số Lượng"].Points.AddXY("Công Việc", soLuongCongViec);
            BDTron.Series["Số Lượng"].Points.AddXY("Ứng Viên", soLuongUngVien);

            BDTron.Series["Số Lượng"].ChartType = SeriesChartType.Pie;
            BDTron.Series["Số Lượng"]["PieLabelStyle"] = "Outside";
            BDTron.Series["Số Lượng"].IsValueShownAsLabel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FThongKeCongViec fThongKeCongViec = new FThongKeCongViec();
            fThongKeCongViec.Show();
        }
    }
}
