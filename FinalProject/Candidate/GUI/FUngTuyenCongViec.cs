using FinalProject.Common.BUS;
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

namespace FinalProject.Candidate.GUI
{
    public partial class FUngTuyenCongViec : Form
    {
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();
        private UngTuyen ungTuyen = new UngTuyen();
        public UngVien UngVien { get; set; }
        public CongViec CongViec { get; set; }
        public int UngTuyenId { get; set; }
        public int CongViecId { get; set; }
        private List<CV> listCV = new List<CV>();

        public FUngTuyenCongViec()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.listCV = new List<CV>
            {
                new CV { Id = 1, Ten = "CV 1" },
                new CV { Id = 2, Ten = "CV 2" },
                new CV { Id = 3, Ten = "CV 3" },
            };
            var listComboBoxItem = new List<ComboBoxItem>();
            foreach (var cv in listCV)
            {
                listComboBoxItem.Add(new ComboBoxItem(cv.Ten, cv.Id));
            }
            ucComboBox_Cv.DataSource = listComboBoxItem.ToArray();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FUngTuyenCongViec_Load(object sender, EventArgs e)
        {
            if (UngVien != null)
            {
                textBox_TenUngVien.Text = UngVien.HoTen;
            }
            if (CongViec != null)
            {
                textBox_TenCongViec.Text = CongViec.Ten;
                textBox_TenCongTy.Text = CongViec.TenCongTy;
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            var selectedCv = ucComboBox_Cv.SelectedItem as ComboBoxItem;

            ungTuyen = new UngTuyen()
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
                MessageBox.Show("Ứng tuyển thành công");
            }
            else
            {
                MessageBox.Show("Ứng tuyển thất bại");
            }
            this.Close();
        }

    }
}
