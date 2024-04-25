using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Admin.GUI.ThongKe
{
    public partial class FDashBoard : Form
    {
        string conn = Properties.Settings.Default.connectionString;
        public FDashBoard()
        {
            InitializeComponent();
        }
        private int DemSo(string query, string connectionString)
        {
            int Dem = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    Dem = (int)command.ExecuteScalar();
                }
            }
            return Dem;
        }
        int DemSoCongViec(string connectionString) 
        {
            string query = "SELECT COUNT(*) FROM CongViec";
            int soCV = DemSo(query, connectionString);
            return soCV;
        }
        int DemSoUngVien(string connectionString)
        {
            string query = "SELECT COUNT(*) FROM UngVien";
            int soUV = DemSo(query, connectionString);
            return soUV;
        }
        int DemSoCty(string connectionString)
        {
            string query = "SELECT COUNT(*) FROM CongTy";
            int soCty = DemSo(query, connectionString);
            return soCty;
        }
        private void FDashBoard_Load(object sender, EventArgs e)
        {
            int soCV = DemSoCongViec(conn);
            txtSoLuongCongViec.Text = soCV.ToString();
            int soUV = DemSoUngVien(conn);
            txtSoLuongUngVien.Text = soUV.ToString();
            int soCty = DemSoCty(conn);
            txtSoLuongCongTy.Text = soCty.ToString();
        }
    }
}
