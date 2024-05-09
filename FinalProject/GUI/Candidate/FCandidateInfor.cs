using CloudinaryDotNet;
using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Const;
using FinalProject.Common.GUI;
using FinalProject.Common.Helper;
using FinalProject.Database;
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

namespace FinalProject.GUI.Candidate
{
    public partial class FCandidateInfor : UCForm
    {
        private UngVienBUS ungVienBUS = new UngVienBUS();
        private UserBUS userBUS = new UserBUS();

        public FCandidateInfor()
        {
            InitializeComponent();

            // Ẩn button xác nhận email nếu email đã được xác nhận
            this.button_XacNhanEmail.Enabled = !LoggedUser.User.IsEmailVerified.HasValue || !LoggedUser.User.IsEmailVerified.Value;
            this.ucComboBox_TrangThai.Items = UCComboBox.UserSatusItems;
            this.ucComboBox_TrangThaiEmail.Items = UCComboBox.EmailStatusItems;
            this.ucComboBox_Gender.Items = UCComboBox.GenderItems;
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

            var result = ungVienBUS.Update(id, hoten, ngaysinh, gioiTinh: gioitinh, 
                diachi, sdt, email, chuyenmon, trangthai, avatar);
             
            if (result <= 0)
            {
                UCMessageBox.Show("Có lỗi phát sinh !");
                return;
            }
            else
            {
                // Cần xác nhận email lại nếu email đã thay đổi
                if (email != LoggedUser.User.Email)
                {
                    var user = LoggedUser.User;
                    user.Email = email;
                    user.IsEmailVerified = false;
                    var result2 = userBUS.Update(user);
                    if (result2 <= 0)
                    {
                        UCMessageBox.Show("Có lỗi phát sinh !");
                        return;
                    }
                }

                LoggedUser.UngVien = ungVienBUS.GetByUserId(LoggedUser.UserId);
                this.FCandidateInfor_Load(sender, e);
                UCMessageBox.Show("Bạn đã cập nhật thành công !");
            }
        }

        private void FCandidateInfor_Load(object sender, EventArgs e)
        {
            var ungVien = LoggedUser.UngVien;
            if(ungVien != null)
            {
                textBox_Name.Text = ungVien.HoTen;
                dateTime_Birthday.Value = ungVien.NgaySinh ?? DateTime.Now;
                ucComboBox_Gender.Text = ungVien.GioiTinh;
                textBox_Address.Text = ungVien.DiaChi;
                textBox_Phone.Text = ungVien.SDT;
                textBox_Email.Text = ungVien.Email;
                richTextBox_ChuyenMon.Text = ungVien.ChuyenMon;
                this.ucComboBox_Gender.SelectedIndex = this.ucComboBox_Gender.FindItemIndex(ungVien.GioiTinh);
            }

            if (LoggedUser.User != null)
            {
                var url = LoggedUser.User.AvatarUrl;
                if (!string.IsNullOrWhiteSpace(url))
                {
                    pictureBox_Avatar.LoadAsync(url);
                }

                this.ucComboBox_TrangThai.SelectedIndex = this.ucComboBox_TrangThai.FindItemIndex(LoggedUser.User.Status);
                this.ucComboBox_TrangThaiEmail.SelectedIndex = this.ucComboBox_TrangThaiEmail.FindItemIndex(LoggedUser.User.IsEmailVerified);
            }
        }

        private void button_ChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                var uploadResult = ImageHelper.UploadImage(openFileDialog.FileName, $"User_{LoggedUser.UserId}");
                if (uploadResult != null)
                {
                    //// Do không đổi url ảnh, nên không cần update url ảnh trong database
                    //UCMessageBox.Show("Cập nhật ảnh đại diện thành công !");
                    //pictureBox_Avatar.Load(openFileDialog.FileName);

                    string url = uploadResult.Url.ToString();
                    LoggedUser.User.AvatarUrl = url;
                    var result = userBUS.Update(LoggedUser.User);
                    if (result > 0)
                    {
                        pictureBox_Avatar.Load(openFileDialog.FileName);
                        UCMessageBox.Show("Cập nhật ảnh đại diện thành công !");
                    }
                    else
                    {
                        UCMessageBox.Show("Có lỗi phát sinh !");
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            FDoiMatKhau fDoiMatKhau = new FDoiMatKhau();
            fDoiMatKhau.ShowDialog();
        }

        private void button_XacNhanEmail_Click(object sender, EventArgs e)
        {
            if (LoggedUser.User.IsEmailVerified == false)
            {
                var result = userBUS.SendOtpVerifyEmail(LoggedUser.User, "Xác thực tài khoản");

                if (result.IsSuccess)
                {
                    FXacNhanEmail fXacNhanEmail = new FXacNhanEmail();
                    fXacNhanEmail.ShowDialog();

                    // Cập nhật lại thông tin user
                    LoggedUser.User = userBUS.GetById(LoggedUser.User.Id);
                    this.FCandidateInfor_Load(sender, e);
                }
                else
                {
                    UCMessageBox.Show("Có lỗi phát sinh !");
                }
            }
        }
    }
}
