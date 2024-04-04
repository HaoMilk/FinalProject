using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Admin.GUI
{
    public partial class FThongKe : Form
    {
        public FThongKe()
        {
            InitializeComponent();
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            BDCot.Series["BDCot"].Points.AddXY("CNTT ", 1230);
            BDCot.Series["BDCot"].Points.AddXY("KE TOAN ", 930);
            BDCot.Series["BDCot"].Points.AddXY("QLNS ", 1000);
            BDCot.Series["BDCot"].Points.AddXY("ATTT ", 700);
            BDCot.Series["BDCot"].Points.AddXY("ANQP ", 1100);
            BDTron.Series["BDTron"].Points.AddXY("CNTT ", 1230);
            BDTron.Series["BDTron"].Points.AddXY("KE TOAN ", 930);
            BDTron.Series["BDTron"].Points.AddXY("QLNS ", 1000);
            BDTron.Series["BDTron"].Points.AddXY("ATTT ", 700);
            BDTron.Series["BDTron"].Points.AddXY("ANQP ", 1100);
        }
    }
}
