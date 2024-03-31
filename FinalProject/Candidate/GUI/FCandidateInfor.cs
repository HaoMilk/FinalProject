using FinalProject.Common;
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
    public partial class FCandidateInfor : Form
    {
        private UngVienBUS ungVienBUS = new UngVienBUS();
        public FCandidateInfor()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var id = LoggedUser.UngVienId;
            var hoten = textBox_Name.Text;
            var ngaysinh = dateTime_Birthday.Value;
            var gioitinh = textBox_Gender.Text;
            var diachi = textBox_Address.Text;
            var sdt = textBox_Phone.Text;
            var email = textBox_Email.Text;
            var chuyenmon = textBox_Major.Text;
            var trangthai = LoggedUser.UngVien.TrangThai;
            var avatar = LoggedUser.UngVien.Avatar;

            ungVienBUS.Update(id, hoten, ngaysinh, gioitinh, 
                diachi, sdt, email, chuyenmon, trangthai, avatar);

            LoggedUser.UngVien = ungVienBUS.GetById(LoggedUser.UngVienId);


            MessageBox.Show("Bạn đã cập nhật thành công !");
        }

        private void FCandidateInfor_Load(object sender, EventArgs e)
        {
            var ungVien = LoggedUser.UngVien;
            textBox_Name.Text = ungVien.HoTen;
            dateTime_Birthday.Value = ungVien.NgaySinh;
            textBox_Gender.Text = ungVien.GioiTinh;
            textBox_Address.Text = ungVien.DiaChi;
            textBox_Phone.Text = ungVien.SDT;
            textBox_Email.Text = ungVien.Email;
            textBox_Major.Text = ungVien.ChuyenMon;
            
        }
    }
}
