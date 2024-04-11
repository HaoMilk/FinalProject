using FinalProject.Common;
using FinalProject.Common.BUS;
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

namespace FinalProject.Candidate.GUI
{
    public partial class FCandidateInfor : UCForm
    {
        private UngVienBUS ungVienBUS = new UngVienBUS();
        public FCandidateInfor()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var id = LoggedUser.UserId;
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

            LoggedUser.UngVien = ungVienBUS.GetById(LoggedUser.UserId);


            MessageBox.Show("Bạn đã cập nhật thành công !");
        }

        private void FCandidateInfor_Load(object sender, EventArgs e)
        {
            var ungVien = LoggedUser.UngVien;
            if(ungVien != null)
            {
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
}
