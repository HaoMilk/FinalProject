using FinalProject.Common.BUS;
using FinalProject.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Candidate.GUI
{
    public partial class FChiTietCv : Form
    {
        private CongViecBUS congViecBUS = new CongViecBUS();
        private CongViec congViec = new CongViec();
        private int id;
        private string cvName;
        private DateTime cvUpdatedTime;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                this.Invalidate();
            }
        }

        public string CvName
        {
            get { return cvName; }
            set
            {
                cvName = value;
                this.label_JobName.Text = cvName;
                this.Invalidate();
            }
        }

        public DateTime CvUpdatedTime
        {
            get { return cvUpdatedTime; }
            set
            {
                cvUpdatedTime = value;
                this.Invalidate();
            }
        }

        public FChiTietCv()
        {
            InitializeComponent();
        }


        private void FChiTietCv_Load(object sender, EventArgs e)
        {
            // load du lieu tu database
            congViec = congViecBUS.GetById(id);
          
            // fill data 
            if(congViec != null )
            {
                textBox_DiaDiemLamViec.Text = congViec.DiaDiem;
                textBox_MucLuong.Text = congViec.MucLuong.ToString();
                textBox_ViTriCongViec.Text = congViec.ViTriTuyenDung;
                textBox_TenCongTy.Text = congViec.Id.ToString();
                richTextBox_MoTa.Text = congViec.MoTa;
                textBox_KinhNghiem.Text = congViec.KinhNghiem;
                textBox_LienHe.Text = congViec.LienHe;
                textBox_ThoiGianLamViec.Text = congViec.CreatedTime.ToShortDateString();
                richTextBox_QuyenLoi.Text = congViec.QuyenLoi;
                textBox_Nganh.Text = congViec.Nganh;

            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox_MoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
