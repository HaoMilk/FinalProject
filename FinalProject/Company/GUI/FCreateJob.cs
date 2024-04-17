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
    public partial class FCreateJob : Form
    {
        CongViecBUS congViecBUS = new CongViecBUS();
        private CongViec congViec = new CongViec();
        private int id;
        private DateTime congViecUpdatedTime;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public DateTime CvUpdatedTime
        {
            get { return congViecUpdatedTime; }
            set
            {
                congViecUpdatedTime = value;
                // this.Invalidate();
            }
        }
        public FCreateJob()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var Nganh = textBox_Nganh.Text;
            var ViTriTuyenDung = textBox_ViTriCongViec.Text;
            var MucLuong = decimal.TryParse(textBox_MucLuong.Text, out decimal parsedMucLuong) ? parsedMucLuong : 0;
            var GioiTinh = comboBox_GioiTinh.Text;
            var KinhNghiem = comboBox_KinhNgiem.Text;
            var TrinhDoHocVan = textBox_TrinhDoHocVan.Text;
            var SoLuong = int.TryParse(textBox_SoLuong.Text, out int parsedSoLuong) ? parsedSoLuong : 0;
            var DiaDiem = comboBox_DiaDiem.Text;
            var LienHe = textBox_LienHe.Text;
            var TenCongViec = textBox_TenCViec.Text;
            var MoTa = richTextBox_MoTa.Text;
            var QuyenLoi = richTextBox_QuyenLoi.Text;
            var YeuCauUngVien = richTextBox_YeuCauUV.Text;
            var IdCongTy = LoggedUser.CongTy.ID;
            var TenCongTy = LoggedUser.CongTy.TenCongTy;
            var FromDate = dateTimePicker_FromDate.Value;
            var result = 0;
            if (congViecBUS.CheckExist(Id) == 0)
            {
                result = congViecBUS.Add(TenCongTy, IdCongTy, TenCongViec, Nganh, ViTriTuyenDung, MucLuong, DiaDiem, TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, KinhNghiem, YeuCauUngVien, SoLuong, FromDate);
            }
            else
            {
                result = congViecBUS.Update(Id, IdCongTy, TenCongTy, TenCongViec, Nganh, ViTriTuyenDung, MucLuong, DiaDiem, TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, KinhNghiem, YeuCauUngVien, SoLuong, FromDate);
            }
            if (result > 0)
            {
                MessageBox.Show("Lưu thành công");
                //this.Close();
            }
            else if (result == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            var result = congViecBUS.SoftDelete(Id);
            if (result > 0)
            {
                MessageBox.Show("Xoá thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void FCreateJob_Load(object sender, EventArgs e)
        {
            congViec = congViecBUS.GetById(id);

            // fill data 
            if (congViec != null)
            {
                textBox_TenCViec.Text = congViec.Ten;
                comboBox_DiaDiem.Text = congViec.DiaDiem;
                textBox_MucLuong.Text = congViec.MucLuong.ToString();
                textBox_ViTriCongViec.Text = congViec.ViTriTuyenDung;
                comboBox_GioiTinh.Text = congViec.GioiTinh;
                textBox_TrinhDoHocVan.Text = congViec.TrinhDoHocVan;
                richTextBox_MoTa.Text = congViec.MoTa;
                comboBox_KinhNgiem.Text = congViec.KinhNghiem;
                textBox_LienHe.Text = congViec.LienHe;
                dateTimePicker_FromDate.Text = congViec.CreatedTime.ToShortDateString();
                richTextBox_QuyenLoi.Text = congViec.QuyenLoi;
                textBox_Nganh.Text = congViec.Nganh;
                textBox_SoLuong.Text = congViec.SoLuong.ToString();
                richTextBox_YeuCauUV.Text = congViec.YeuCauUngVien;
            }
        }
    }
}
