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
        private void LoadComboBoxData()
        {
            try
            {
                string[] comboBoxQueries = {
                    "SELECT DISTINCT Nganh FROM CongViec",
                    "SELECT DISTINCT DiaDiem FROM CongViec",
                    "SELECT DISTINCT KinhNghiem FROM CongViec",
                    "SELECT DISTINCT MucLuong FROM CongViec"
                };

                ComboBox[] comboBoxes = { cbNganh, cbDiaDiem, cbKinhNghiem, cbMucLuong };

                for (int i = 0; i < comboBoxes.Length; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(comboBoxQueries[i], conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxes[i].Items.Add(dr[0].ToString());
                    }

                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion ComboBox




        private void FDanhSachCongViec_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxData();
               // FilterDataGridView();
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

        private void FilterDataGridView()
        {
            try
            {
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM CongViec WHERE 1=1");

                string[] comboBoxesText = {
                    cbNganh.SelectedItem?.ToString(),
                    cbDiaDiem.SelectedItem?.ToString(),
                    cbKinhNghiem.SelectedItem?.ToString(),
                    cbMucLuong.SelectedItem?.ToString()
                };

                string[] comboBoxColumns = { "Nganh", "DiaDiem", "KinhNghiem", "MucLuong" };

                for (int i = 0; i < comboBoxesText.Length; i++)
                {
                    if (!string.IsNullOrEmpty(comboBoxesText[i]))
                    {
                        queryBuilder.Append($" AND {comboBoxColumns[i]} = '{comboBoxesText[i]}'");
                    }
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
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

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  FilterDataGridView();
        }

        private void cbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
           // FilterDataGridView();
        }

        private void cbKinhNghiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FilterDataGridView();
        }

        private void cbMucLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
           // FilterDataGridView();
        }

        private void dgvDSCV_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
