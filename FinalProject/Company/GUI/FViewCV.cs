using FinalProject.Common;
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

namespace FinalProject.Company.GUI
{
    public partial class FViewCV : Form
    {
        private CvBUS _cvBus = new CvBUS();

        private int id;
        private CV _cv;

        public int Id
        {
            get => id; set
            {
                id = value;
                _cv = _cvBus.GetById(id);
                this.LoadData();
            }
        }

        public FViewCV()
        {
            InitializeComponent();
        }

        private void FViewCV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (_cv != null)
            {
                textBox_TenCv.Text = _cv.Ten;
                textBox_ViTriUT.Text = _cv.ViTriUngTuyen;
                textBox_KyNang.Text = _cv.KyNang;
                textBox_NgoaiNgu.Text = _cv.NgoaiNgu;
                textBox_TinHoc.Text = _cv.TinHoc;
                textBox_HocVan.Text = _cv.HocVan;
                textBox_HoatDong.Text = _cv.HoatDong;
                textBox_ChungChi.Text = _cv.ChungChi;
                richTextBox_MucTieu.Text = _cv.MucTieu;
                richTextBox_KinhNghiem.Text = _cv.KinhNghiem;
            }
        }

        private void comboBox_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
