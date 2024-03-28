using FinalProject.Admin.GUI.CongTy;
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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        public FDanhSachCongViec()
        {
            InitializeComponent();
        }

        private void FDanhSachCongViec_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM CongViec");
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
            FCSCongViec fCSCongViec = new FCSCongViec();
            fCSCongViec.Show();
        }
    }
}
