﻿using FinalProject.Common;
using FinalProject.Common.BUS;
using System;
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
            var UngVienId = LoggedUser.UngVienId;
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

            var result = _cvBus.Add(Id, TenCv, UngVienId, Link, MoTa, TrangThai, ViTriUngTuyen,
                KyNang, NgoaiNgu, TinHoc, HocVan, HoatDong, ChungChi, MucTieu, KinhNghiem);

            if (result > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
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
        }
    }
}