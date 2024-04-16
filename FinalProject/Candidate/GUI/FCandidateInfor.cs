using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Helper;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            var items = new ComboBoxItem[]
            {
                new ComboBoxItem { Text = "Nam", Value = "M" },
                new ComboBoxItem { Text = "Nữ", Value = "F" },
                new ComboBoxItem { Text = "Khác", Value = "O" },
            };
            this.ucComboBox_Gender.Items = items;
            this.ucComboBox_Gender.SelectedIndex = 0;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var id = LoggedUser.UngVien.Id;
            var hoten = textBox_Name.Text;
            var ngaysinh = dateTime_Birthday.Value;
            var gioitinh = ucComboBox_Gender.Text;
            var diachi = textBox_Address.Text;
            var sdt = textBox_Phone.Text;
            var email = textBox_Email.Text;
            var chuyenmon = richTextBox_ChuyenMon.Text;
            var trangthai = LoggedUser.UngVien.TrangThai;
            var avatar = LoggedUser.UngVien.Avatar;

            var result = ungVienBUS.Update(id, hoten, ngaysinh, gioitinh, 
                diachi, sdt, email, chuyenmon, trangthai, avatar);

            if (result <= 0)
            {
                MessageBox.Show("Có lỗi phát sinh !");
                return;
            }

            LoggedUser.UngVien = ungVienBUS.GetByUserId(LoggedUser.UserId);
            MessageBox.Show("Bạn đã cập nhật thành công !");
        }

        private void FCandidateInfor_Load(object sender, EventArgs e)
        {
            var ungVien = LoggedUser.UngVien;
            if(ungVien != null)
            {
                textBox_Name.Text = ungVien.HoTen;
                dateTime_Birthday.Value = ungVien.NgaySinh;
                ucComboBox_Gender.Text = ungVien.GioiTinh;
                textBox_Address.Text = ungVien.DiaChi;
                textBox_Phone.Text = ungVien.SDT;
                textBox_Email.Text = ungVien.Email;
                richTextBox_ChuyenMon.Text = ungVien.ChuyenMon;
            }
        }
    }
}
