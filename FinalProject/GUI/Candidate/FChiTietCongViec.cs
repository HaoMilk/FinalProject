using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.DAO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.GUI.Candidate
{
    public partial class FChiTietCongViec : UCForm
    {
        private CongViecBUS congViecBUS = new CongViecBUS();
        private CongViec congViec = new CongViec();
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private UngTuyen ungTuyen = new UngTuyen();
        private UngTuyenDAO ungTuyenDto = new UngTuyenDAO();

        private int id;
        private int? ungTuyenId;
        private string cvName;
        private DateTime cvUpdatedTime;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                // this.Invalidate();
            }
        }

        public int? UngTuyenId
        {
            get { return ungTuyenId; }
            set
            {
                ungTuyenId = value;
                if (value != null && value > 0)
                {
                    DisableEdit();
                }
            }
        }

        public string CvName
        {
            get { return cvName; }
            set
            {
                cvName = value;
                this.label_JobName.Text = cvName;
                // this.Invalidate();
            }
        }

        public DateTime CvUpdatedTime
        {
            get { return cvUpdatedTime; }
            set
            {
                cvUpdatedTime = value;
                // this.Invalidate();
            }
        }

        public FChiTietCongViec()
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
                textBox_TenCongTy.Text = congViec.TenCongTy.ToString();
                richTextBox_MoTa.Text = congViec.MoTa;
                textBox_KinhNghiem.Text = congViec.KinhNghiem;
                textBox_LienHe.Text = congViec.LienHe;
                textBox_ThoiGianLamViec.Text = congViec.CreatedTime.ToShortDateString();
                richTextBox_QuyenLoi.Text = congViec.QuyenLoi;
                textBox_Nganh.Text = congViec.Nganh;
                textBox_SoLuong.Text = congViec.SoLuong.ToString() ;
                richTextBox_YeuCau.Text = congViec.YeuCauUngVien;
                dateTimePicker_NgayBatDau.Value = congViec.FromDate;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            FUngTuyenCongViec fUngTuyenCongViec = new FUngTuyenCongViec();
            fUngTuyenCongViec.CongViec = congViec;
            fUngTuyenCongViec.UngVien = LoggedUser.UngVien;
            fUngTuyenCongViec.ShowDialog();
        }

        private void DisableEdit()
        {
            this.button_Submit.Enabled = false;
            this.button_Submit.Visible = false;
        }
    }
}
