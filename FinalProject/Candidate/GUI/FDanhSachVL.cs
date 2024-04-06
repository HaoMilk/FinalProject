using FinalProject.Candidate.Constants;
using FinalProject.Common.BUS;
using FinalProject.Common.DTO;
using FinalProject.Database.DTO;
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
    public partial class FDanhSachVL_Name : UCForm
    {
        private TinhBUS tinhBUS = new TinhBUS();
        private List<Tinh> listTinh = new List<Tinh>();
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<CongViec> listCongViec = new List<CongViec>();

        public FDanhSachVL_Name()
        {
            InitializeComponent();

            this.listTinh = tinhBUS.GetAll();
            this.comboBox_DiaDiem.Items.Clear();
            this.comboBox_DiaDiem.Items.AddRange(this.listTinh.ToArray());

            var listKinhNghiem = KinhNghiemConstants.GetKinhNghiemList();
            this.comboBox_KinhNghiem.Items.AddRange(listKinhNghiem.ToArray());
            this.comboBox_KinhNghiem.SelectedIndex = 0;

            var listMucLuong = MucLuongConstants.GetMucLuongList();
            this.comboBox_MucLuong.Items.AddRange(listMucLuong.ToArray());
            this.comboBox_MucLuong.SelectedIndex = 0;

            var listNgheNghiep = NgheNghiepConstants.GetNgheNghiepList();
            this.comboBox_NgheNghiep.Items.AddRange(listNgheNghiep.ToArray());
            this.comboBox_NgheNghiep.SelectedIndex = 0;
        }

        #region JobList

        private void LoadJobList()
        {
            ucPagination.TotalRecord = listCongViec.Count;

            List<UCJobCard> ucJobCards = new List<UCJobCard>();
            if (listCongViec != null && listCongViec.Count > 0)
            {
                for (int i = 0; i < listCongViec.Count; i++)
                {

                    UCJobCard ucJobCard = new UCJobCard();
                    ucJobCard.Id = listCongViec[i].Id;
                    ucJobCard.JobName = listCongViec[i].Ten;
                    //ucJobCard.LastUpdatedTime = listCongViec[i].UpdatedTime;
                    //ucJobCard.ScaleSize(0.5f);

                    ucJobCards.Add(ucJobCard);
                }
            }

            flowLayoutPanel_CongViec.Controls.Clear();
            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_CongViec.Controls.Add(ucJobCard);
            }
            this.label_SoLuongViecLam.Text = "Số lượng việc làm: " + ucJobCards.Count;
        }
        #endregion JobList

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }

        private void SearchCongViec()
        {
            var input = new CongViecGetAllInput();
            input.Search = textBox_TimKiem.Text;
            input.NgheNghiep = comboBox_NgheNghiep.Text;

            var selectedTinh = this.comboBox_DiaDiem.SelectedItem as Tinh;
            input.DiaDiem = selectedTinh != null ? selectedTinh.Code : null;

            input = input.SetKinhNghiem(comboBox_KinhNghiem.Text);
            input = input.SetMucLuong(comboBox_MucLuong.Text);

            input.FromId = ucPagination.StartRecord;
            input.ToId = ucPagination.EndRecord;

            listCongViec = congViecBUS.Search(input);
        }
    }
}
