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

namespace FinalProject.Admin.GUI.CongViec
{
    
    public partial class FChinhSuaCongVIec : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        public FChinhSuaCongVIec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
