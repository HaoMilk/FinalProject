using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Database.DTO;
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
        private UngVienBUS _uvBus = new UngVienBUS();
        private UngTuyenBUS _utBUS = new UngTuyenBUS();
        private int id;
        private UngVien _uv;
        private CV _cv;
        private UngTuyenDTO _ut ;
        private int result;
        public int Id
        {
            get => id; set
            {
                id = value;
                _cv = _cvBus.GetById(id);
                this.LoadData();
            }
        }
        public int IdUV
        {
            get => id; set
            {
                id = value;
                _uv = _uvBus.GetById(id);
                this.LoadData();
            }
        }
        public int IdUT
        {
            get => id; set
            {
                id = value;
                _ut = _utBUS.GetById(id);
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
            if (_uv != null)
            {
                textBox_HovaTen.Text = _uv.HoTen;
                textBox_Email.Text = _uv.Email;
                textBox_SoDienThoai.Text = _uv.SDT;
                textBox_DiaChi.Text = _uv.DiaChi;
                textBox_NgaySinh.Text = _uv.NgaySinh.ToString();
                textBox_GioiTinh.Text = _uv.GioiTinh;
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

        private void comboBox_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Duyet_Click(object sender, EventArgs e)
        {
            var ID = _ut.Id;
            var trangThai = _ut.TrangThai;
            if(_ut.TrangThai == TrangThaiUngTuyen.Approved)
            {
                MessageBox.Show("Hồ sơ đã được duyệt");
                return;
            }
            else
            {
                trangThai = TrangThaiUngTuyen.Approved;
            }
            result = _utBUS.UpdateTrangThai(ID, trangThai);
            if(result!=0)
            {
                MessageBox.Show("Duyệt thành công");
            }
            else
            {
                MessageBox.Show("Duyệt không thành công");

            }
        }

        private void button_Loai_Click(object sender, EventArgs e)
        {
            var ID = _ut.Id;
            var trangThai = _ut.TrangThai;
            if (_ut.TrangThai == TrangThaiUngTuyen.Rejected)
            {
                MessageBox.Show("Hồ sơ đã được loại bỏ");
                return;
            }
            else
            {
                trangThai = TrangThaiUngTuyen.Rejected;
            }

            result = _utBUS.UpdateTrangThai(ID, trangThai);
            if (result != 0)
            {
                MessageBox.Show("Loại bỏ thành công");
            }
            else
            {
                MessageBox.Show("Loại bỏ không thành công");

            }
        }
    }
}
