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

namespace FinalProject.Company.GUI.Ung_tuyen
{
    public partial class FAddViecLam : Form
    {
        CongViecBUS congViecBUS = new CongViecBUS();
        public FAddViecLam()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(textBox_ID.Text);
            var Nganh = textBox_Nganh.Text;
            var ViTriTuyenDung = textBox_ViTriCongViec.Text;
            var MucLuong = decimal.Parse(textBox_MucLuong.Text);
            var GioiTinh = comboBox_GioiTinh.Text;
            var KinhNghiem = textBox_KinhNghiem.Text;
            var TrinhDoHocVan = textBox_TrinhDoHocVan.Text;
            var SoLuong = int.Parse(textBox_SoLuong.Text);
            var DiaDiem = textBox_DiaDiem.Text;
            var LienHe = textBox_LienHe.Text;
            var TenCongViec = textBox_TenCViec.Text;
            var MoTa = richTextBox_MoTa.Text;
            var QuyenLoi = richTextBox_QuyenLoi.Text;
            var YeuCauUngVien = richTextBox_YeuCauUV.Text;
            var IdCongTy = LoggedUser.CongTy.ID;
            var TenCongTy = LoggedUser.CongTy.TenCongTy;
            congViecBUS.Add(Id, TenCongTy, TenCongViec, Nganh, ViTriTuyenDung,MucLuong, DiaDiem, TrinhDoHocVan, GioiTinh, LienHe, MoTa, QuyenLoi, KinhNghiem, YeuCauUngVien,SoLuong);
            MessageBox.Show("Thêm Thành Công");
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {

        }

        private void FAddViecLam_Load(object sender, EventArgs e)
        {

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox_ID.Text);
            congViecBUS.SoftDelete(id);
            congViecBUS.Delete(id);
        }
    }
}
