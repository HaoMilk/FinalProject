using FinalProject.Candidate.DTO;
using FinalProject.UC;
using Newtonsoft.Json;
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
    public partial class FDanhSachVL_Name : Form
    {
        public FDanhSachVL_Name()
        {
            InitializeComponent();

            this.comboBox_ViTri.SelectedIndex = 0;
            this.comboBox_KinhNghiem.SelectedIndex = 0;
            this.comboBox_MucLuong.SelectedIndex = 0;
            this.comboBox_NgheNghiep.SelectedIndex = 0;
        }

        private void InitJobList()
        {
            var ucJobCards = CreateJobList(10);
            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_CongViec.Controls.Add(ucJobCard);
            }
            this.label_SoLuongViecLam.Text = "Số lượng việc làm: " + ucJobCards.Count;
        }

        private List<UCJobCard> CreateJobList(int quantity)
        {
            List<UCJobCard> ucJobCards = new List<UCJobCard>();
            for (int i = 0; i < quantity; i++)
            {
                UCJobCard ucJobCard = new UCJobCard();
                ucJobCard.Id = (i + 1);
                ucJobCard.CvName = $"Việc làm {i + 1}";
                ucJobCard.CvUpdatedTime = DateTime.Now;
                //ucJobCard.ScaleSize(0.5f);

                ucJobCards.Add(ucJobCard);
            }
            return ucJobCards;
        }

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {
            InitJobList();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            var searchCriteria = GetSearchCriteria();
            MessageBox.Show($"Tìm kiếm: {JsonConvert.SerializeObject(searchCriteria)}");
        }

        private TimKiemViecLamDto GetSearchCriteria()
        {
            TimKiemViecLamDto searchCriteria = new TimKiemViecLamDto();
            searchCriteria.Search = this.textBox_TimKiem.Text;
            searchCriteria.ViTri = this.comboBox_ViTri.Text;
            searchCriteria.NgheNghiep = this.comboBox_NgheNghiep.Text;
            //searchCriteria.KinhNghiem = this.comboBox_KinhNghiem.Text;
            //searchCriteria.MucLuong = this.comboBox_MucLuong.Text;
            return searchCriteria;
        }
    }
}
