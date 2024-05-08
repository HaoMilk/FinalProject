using FinalProject.Common.BUS;
using FinalProject.Common.Const;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using NPOI.SS.UserModel;
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
    public partial class FUngTuyenCongViec : UCForm
    {
        #region Fields and Properties
        private CongViecBUS congViecBUS = new CongViecBUS();
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private CvBUS cvBUS = new CvBUS();
        private int? ungTuyenId;
        private int? congViecId;
        private UngVien ungVien;
        private CongViec congViec;

        public int? UngTuyenId
        {
            get { return ungTuyenId; }
            set
            {
                ungTuyenId = value;
                if (value != null && value > 0)
                {
                    var ungTuyenDto = ungTuyenBUS.GetById(ungTuyenId.Value);
                    textBox_TenUngVien.Text = ungTuyenDto.TenUngVien;
                    textBox_TenCongViec.Text = ungTuyenDto.TenCongViec;
                    textBox_TenCongTy.Text = ungTuyenDto.TenCongTy;
                    richTextBox_MoTa.Text = ungTuyenDto.MoTa;
                    DisableEdit();
                }
            }
        }

        public int? CongViecId
        {
            get { return congViecId; }
            set
            {
                congViecId = value;
                if (value != null && value > 0)
                {
                    this.CongViec = congViecBUS.GetById(value.Value);
                }
            }
        }

        public UngVien UngVien
        {
            get { return ungVien; }
            set
            {
                ungVien = value;
                if (value != null)
                {
                    textBox_TenUngVien.Text = value.HoTen;
                    LoadCv();
                }
            }
        }

        public CongViec CongViec
        {
            get { return congViec; }
            set
            {
                congViec = value;
                if (value != null)
                {
                    textBox_TenCongViec.Text = value.Ten;
                    textBox_TenCongTy.Text = value.TenCongTy;
                }
            }
        }

        private List<CV> listCV = new List<CV>();
        #endregion Fields and Properties

        public FUngTuyenCongViec()
        {
            InitializeComponent();
            button_Submit.Visible = true;
            button_Huy.Visible = false;
            
        }
        public FUngTuyenCongViec(int? ungTuyenId)
        {
            InitializeComponent();
            this.UngTuyenId = ungTuyenId;
            if (UngTuyenId == null || UngTuyenId == 0)
            {
                button_Submit.Visible = true;
                button_Huy.Visible = false;
            }
            else
            {
                button_Submit.Visible = false;
                button_Huy.Visible = true;
            }
        }
        private void FUngTuyenCongViec_Load(object sender, EventArgs e)
        {
            LoadCv();
        }
   
        private void LoadCv()
        {
            if (UngVien != null)
            {
                this.listCV = cvBUS.GetByUngVienId(UngVien.Id);
                var listComboBoxItem = new List<ComboBoxItem>();
                foreach (var cv in listCV)
                {
                    listComboBoxItem.Add(new ComboBoxItem(cv.Ten, cv.Id));
                }
                ucComboBox_Cv.DataSource = listComboBoxItem.ToArray();
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            var selectedCv = ucComboBox_Cv.SelectedItem as ComboBoxItem;

            var ungTuyen = new UngTuyen()
            {
                Id = -1,
                CongViecId = CongViec.Id,
                UngVienId = UngVien.Id,
                CvId = (int)selectedCv.Value,
                TrangThai = TrangThaiUngTuyen.Submitted,
                MoTa = richTextBox_MoTa.Text,
                IsDeleted = false,
                CreatedTime = DateTime.Now,
                UpdatedTime = null
            };

            var result = ungTuyenBUS.Add(ungTuyen);
            if (result > 0)
            {
                UCMessageBox.Show("Ứng tuyển thành công");
            }
            else
            {
                UCMessageBox.Show("Ứng tuyển thất bại");
            }
            this.Close();
        }

        private void DisableEdit()
        {
            textBox_TenUngVien.Enabled = false;
            textBox_TenCongViec.Enabled = false;
            textBox_TenCongTy.Enabled = false;
            richTextBox_MoTa.Enabled = false;
            ucComboBox_Cv.Enabled = false;
            button_Submit.Visible = false;
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            // Xác nhận hủy ứng tuyển
            var dialogResult = UCMessageBox.Show("Bạn có muốn hủy ứng tuyển không?", "Xác nhận", UCMessageBox.MessageBoxButtons.YesNoCancel);
            if(dialogResult != DialogResult.Yes)
            {
                return;
            }
            if (ungTuyenId.HasValue && ungTuyenId > 0)
            {
                // Cập nhật trạng thái ứng tuyển thành cancel
                var result = ungTuyenBUS.Update(ungTuyenId.Value, TrangThaiUngTuyen.Cancelled, "Hủy ứng tuyển");
                if (result > 0) 
                {
                    UCMessageBox.Show("Hủy thành công!");
                    this.Close();
                }
                else
                {
                    UCMessageBox.Show("Hủy thất bại!");
                }
            }
        }
    }
}
