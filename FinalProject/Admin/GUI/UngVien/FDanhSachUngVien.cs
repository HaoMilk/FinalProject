using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FinalProject.Admin.GUI.UngVien;


namespace FinalProject.Admin
{
    public partial class FDanhSachUngVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString);
        public FDanhSachUngVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void FDanhSachUngVien_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM UngVien");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvDSUV.DataSource = dt;
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
            FChinhSuaUngVien fChinhSuaUngVien = new FChinhSuaUngVien();
            fChinhSuaUngVien.ShowDialog();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }
    }
}
