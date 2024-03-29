﻿
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
using FinalProject.Admin.GUI.CongTy;

namespace FinalProject.Admin
{
    public partial class FDanhSachCongTy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        public FDanhSachCongTy()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FChinhSuaCongTy fChinhSuaCongTy = new FChinhSuaCongTy();
            fChinhSuaCongTy.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void FDanhSachCongTy_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM CongTy");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvDSCT.DataSource = dt;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
