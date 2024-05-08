using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Helper;
using FinalProject.Database.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.GUI.Company
{
    public partial class FThongTinCongTy : Form
    {
        private CongTyBUS cty_BUS = new CongTyBUS();
        private CongTy _congTy;
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                _congTy = cty_BUS.GetById(_id);
            }
        }
        
        public FThongTinCongTy()
        {
            InitializeComponent();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            var Email = textBox_Email.Text;
            var MST = textBox_MST.Text;
            var Ten = textBox_TenCTy.Text;
            var DiaChi = textBox_DiaChi.Text;
            var TenCEO = textBox_CEO.Text;
            if (this.Id > 0)
            {
                cty_BUS.Update(ID, Email, Ten, DiaChi, TenCEO, MST);
                UCMessageBox.Show("Cập nhật thành công");
            }
            else
            {
                cty_BUS.Add(ID, Email, Ten, DiaChi, TenCEO, MST);
                UCMessageBox.Show("Thêm thành công");
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            var Email = textBox_Email.Text;
            var MST = textBox_MST.Text;
            var Ten = textBox_TenCTy.Text;
            var DiaChi = textBox_DiaChi.Text;
            var TenCEO = textBox_CEO.Text;

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(textBox_ID.Text);
            cty_BUS.Delete(ID);
            UCMessageBox.Show("Xoá thành công");

        }

        private void FThongTinCongTy_Load(object sender, EventArgs e)
        {
            _congTy = cty_BUS.GetById(Id);
            if (_congTy != null)
            {
                textBox_ID.Text = _congTy.ID.ToString();
                textBox_Email.Text = _congTy.Email;
                textBox_MST.Text = _congTy.MST;
                textBox_TenCTy.Text = _congTy.TenCongTy;
                textBox_DiaChi.Text = _congTy.DiaChi;
                textBox_CEO.Text = _congTy.CEO;
            }
        }

        private void button_Xoa_Click_1(object sender, EventArgs e)
        {

        }

        private void button_ThemGiayPhep_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word files (*.doc, *.docx) | *.doc; *.docx"; // Thay đổi Filter để chỉ cho phép tải lên tệp Word
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                var uploadResult = WordHelper.UpLoadFile(openFileDialog.FileName, $"User_{LoggedUser.UserId}"); // Thay ImageHelper.UploadImage bằng WordFileHelper.UploadWordFile
                if (uploadResult != null)
                {
                    string url = uploadResult.Url.ToString();
                    int id = LoggedUser.CongTy.ID;
                    int result = cty_BUS.AddFileWord(url, id);
                    if (result > 0)
                    {
                        // Hiển thị thông báo và tải hình ảnh lên PictureBox nếu cần
                        UCMessageBox.Show("Cập nhật tệp Word thành công !");
                        // pictureBox_WordFile.Load(openFileDialog.FileName); // Tải hình ảnh nếu cần
                    }
                    else
                    {
                        UCMessageBox.Show("Có lỗi phát sinh khi cập nhật tệp Word !");
                    }
                }

                Cursor.Current = Cursors.Default;
            }

        }
    }
}
