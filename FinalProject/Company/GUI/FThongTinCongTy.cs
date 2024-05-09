using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Helper;
using FinalProject.Database.Entities;
using FinalProject.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.Company.GUI.Thong_tin
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
                //_congTy = cty_BUS.GetById(_id);
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
            LoadData();
        }

        private void LoadData()
        {
            // Lấy thông tin công ty dựa vào id
            _congTy = cty_BUS.GetById(Id);
            if (_congTy != null)
            {
                textBox_ID.Text = _congTy.ID.ToString();
                textBox_Email.Text = _congTy.Email;
                textBox_MST.Text = _congTy.MST;
                textBox_TenCTy.Text = _congTy.TenCongTy;
                textBox_DiaChi.Text = _congTy.DiaChi;
                textBox_CEO.Text = _congTy.CEO;
                textBox_GiayPhep.Text = _congTy.WordFileUrl;
            }
        }

        private void button_Xem_Click(object sender, EventArgs e)
        {
            string url = textBox_GiayPhep.Text;
            if (url == null)
            {
                UCMessageBox.Show("Chưa có giấy phép đăng ký");
            }    
            else
            {
                Process.Start(url);
            }    
        }

        private void button_ThemGiayPhep_Click(object sender, EventArgs e)
        {
            // Mở cửa sổ chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word files (*.doc, *.docx) | *.doc; *.docx"; // Thay đổi Filter để chỉ cho phép tải lên tệp Word
            // Nếu người dùng bấm ok
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Chuyển con trỏ chuột sang waitcursor
                Cursor.Current = Cursors.WaitCursor;

                // Dùng wordhelper để upload file được chọn lên cloud
                var uploadResult = WordHelper.UpLoadFile(openFileDialog.FileName, $"User_{LoggedUser.UserId}"); 
                // Nếu như upload thành công
                if (uploadResult != null)
                {
                    // Lấy thông tin url của file vừa upload
                    string url = uploadResult.Url.ToString();
                    int id = LoggedUser.CongTy.ID;
                    // Lưu url vào thông tin công ty
                    int result = cty_BUS.AddFileWord(url, id);
                    if (result > 0)
                    {
                        // Reload lại data
                       
                        //LoadData();
                        textBox_GiayPhep.Text = url;
                        UCMessageBox.Show("Cập nhật tệp Word thành công !");
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
