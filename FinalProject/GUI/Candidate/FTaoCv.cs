using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Helper;
using FinalProject.Database;
using FinalProject.UC;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FinalProject.GUI.Candidate
{
    public partial class FTaoCv : UCForm
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
                this.button_Export.Enabled = true;
                this.LoadData();
            }
        }

        public FTaoCv()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var Id = id;
            var TenCv = textBox_TenCv.Text;
            var UngVienId = LoggedUser.UserId;
            var Link = "http://";
            var MoTa = "Yeu cau";
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

            var result = 0;
            if (_cvBus.CheckExist(Id) == 0)
            {
                result = _cvBus.Add(Id, TenCv, UngVienId, Link, MoTa, TrangThai, ViTriUngTuyen,
                KyNang, NgoaiNgu, TinHoc, HocVan, HoatDong, ChungChi, MucTieu, KinhNghiem);
            }
            else
            {
                result = _cvBus.Update(Id, TenCv, UngVienId, Link, MoTa, TrangThai, ViTriUngTuyen,
                KyNang, NgoaiNgu, TinHoc, HocVan, HoatDong, ChungChi, MucTieu, KinhNghiem);
            }
            if (result > 0)
            {
                this.Id = Id;
                UCMessageBox.Show("Lưu thành công");
                //this.Close();
            }
            else
            {
                UCMessageBox.Show("Lưu thất bại");
            }
        }

        private void FTaoCv_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (LoggedUser.UngVien != null)
            {
                textBox_HovaTen.Text = LoggedUser.UngVien.HoTen;
                textBox_Email.Text = LoggedUser.UngVien.Email;
                textBox_SoDienThoai.Text = LoggedUser.UngVien.SDT;
                textBox_DiaChi.Text = LoggedUser.UngVien.DiaChi;
                textBox_NgaySinh.Text = LoggedUser.UngVien.NgaySinh.ToString();
                comboBox_GioiTinh.Text = LoggedUser.UngVien.GioiTinh;
            }

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

        private void button_Export_Click(object sender, EventArgs e)
        {
            var filePath = WordHelper.ExportCV(this._cv, LoggedUser.UngVien);

            if (!string.IsNullOrEmpty(filePath))
            {
                Process.Start("explorer.exe", "/select," + Path.GetFullPath(filePath));
                UCMessageBox.Show("Xuất file thành công");
            }
            else
            {
                UCMessageBox.Show("Xuất file thất bại");
            }
        }
    }
}
