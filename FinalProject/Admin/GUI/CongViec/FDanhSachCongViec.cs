using FinalProject.Admin.GUI.CongViec;
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

namespace FinalProject.Admin
{
    public partial class FDanhSachCongViec : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString);

        public FDanhSachCongViec()
        {
            InitializeComponent();
        }
        #region ComboBox
        private void ComboBoxResource(string colName, string query, ComboBox comboBox)
        {
            conn.Open();
            string sqlStr = query;
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox.Items.Add(dr[colName].ToString());
            }
            dr.Close();
            conn.Close();
        }
        private string ChuyenDoiMucLuong(int mucLuong)
        {
            if (mucLuong < 0)
            {
                return "Dưới 0 Triệu";
            }
            else if (mucLuong < 10000000)
            {
                return "0 - 10 Triệu";
            }
            else if (mucLuong < 20000000)
            {
                return "10 - 20 Triệu";
            }
            else if (mucLuong < 30000000)
            {
                return "20 - 30 Triệu";
            }
            else if (mucLuong < 40000000)
            {
                return "30 - 40 Triệu";
            }
            else if (mucLuong < 50000000)
            {
                return "40 - 50 Triệu";
            }
            else
            {
                return "50 Triệu trở lên";
            }
        }
        #endregion ComboBox



        private void FDanhSachCongViec_Load(object sender, EventArgs e)
        {
            try
            {
                string queryComboBoxNganh = "SELECT DISTINCT Nganh FROM CongViec";
                string colNameNganh = "Nganh";
                ComboBoxResource(colNameNganh, queryComboBoxNganh, cbNganh);
                string queryComboBoxDiaDiem = "SELECT DISTINCT DiaDiem FROM CongViec";
                string colNameDiaDiem = "DiaDiem";
                ComboBoxResource(colNameDiaDiem, queryComboBoxDiaDiem, cbDiaDiem);
                string queryComboBoxKinhNghiem = "SELECT DISTINCT KinhNghiem FROM CongViec";
                string colNameKinhNghiem = "KinhNghiem";
                ComboBoxResource(colNameKinhNghiem, queryComboBoxKinhNghiem, cbKinhNghiem);
                string queryComboBoxMucLuong = "SELECT DISTINCT MucLuong FROM CongViec";
                string colNameMucLuong = "MucLuong";
                conn.Open();
                SqlCommand cmdMucLuong = new SqlCommand(queryComboBoxMucLuong, conn);
                SqlDataReader drMucLuong = cmdMucLuong.ExecuteReader();

                while (drMucLuong.Read())
                {
                    int mucLuong = Convert.ToInt32(drMucLuong[colNameMucLuong]);
                    string khoangMucLuong = ChuyenDoiMucLuong(mucLuong);
                    cbMucLuong.Items.Add(khoangMucLuong);
                }
                drMucLuong.Close();
                string sqlStr = "SELECT * FROM CongViec";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvDSCV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            FChinhSuaCongViec fChinhSuaCongViec = new FChinhSuaCongViec();
            fChinhSuaCongViec.ShowDialog();
        }
    }
}
