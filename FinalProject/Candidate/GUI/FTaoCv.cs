using FinalProject.Common.BUS;
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
    public partial class FTaoCv : Form
    {
        private CvBUS _cvBus = new CvBUS();

        public FTaoCv()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var Id = 1;
            var TenCv = textBox_TenCv.Text;
            var UngVienId= 1  ;
            var Link = "http://"  ;
            var MoTa = "Yeu cau"  ;
            var TrangThai = "Active";
            var ViTriUngTuyen = textBox_ViTriUT.Text;
            var KyNang = textBox_KyNang.Text;
            var NgoaiNgu = textBox_NgoaiNgu.Text;
            var TinHoc = textBox_TinHoc.Text;
            var HocVan = textBox_HocVan.Text;
            var HoatDong = textBox_HoatDong.Text;
            var ChungChi = textBox_ChungChi.Text;
            var MucTieu = richTextBox_MucTieu.Text;
            var KinhNghiem = richTextBox_KinhNghiem.Text;
            _cvBus.Add(Id, TenCv, UngVienId, Link, MoTa, TrangThai, ViTriUngTuyen,
                KyNang, NgoaiNgu, TinHoc, HocVan, HoatDong, ChungChi, MucTieu, KinhNghiem);

        }
    }
}
