using FinalProject.Candidate.Constants;
using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
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

namespace FinalProject.Company.GUI
{
    public partial class FDSViecLam : Form
    {
        private TinhBUS tinhBUS = new TinhBUS();
        private List<Tinh> listTinh = new List<Tinh>();
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<CongViec> listCongViec = new List<CongViec>();

        public FDSViecLam()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

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
            var quantity = ucPagination.PageSize;
            var start = ucPagination.StartRecord;
            var end = ucPagination.EndRecord;

            var ucViewJobCard = CreateJobList(quantity);

            flowLayoutPanel_CongViec.Controls.Clear();
            foreach (var ucJobCard in ucViewJobCard)
            {
                flowLayoutPanel_CongViec.Controls.Add(ucJobCard);
            }
            this.label_SoLuongViecLam.Text = "Số lượng việc làm: " + ucViewJobCard.Count;
        }

        private List<UCViewJob> CreateJobList(int quantity)
        {
            listCongViec = congViecBUS.GetByIDCty(LoggedUser.CongTy.ID);
            List<UCViewJob> ucJobCards = new List<UCViewJob>();
            if(listCongViec != null && listCongViec.Count > 0)
            {
                for (int i = 0; i < listCongViec.Count; i++)
                {

                    UCViewJob ucViewJob = new UCViewJob();
                    ucViewJob.Id = listCongViec[i].Id;
                    ucViewJob.JobName = listCongViec[i].Ten;
                    ucJobCards.Add(ucViewJob);
                }
            }
           
            return ucJobCards;
        }

        /// <summary>
        /// Event khi click vào nút xem chi tiết của UCJobCard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcJobCard_ViewClick(object sender, EventArgs e)
        {
            var ucJobCard = sender as UCJobCard;
            MessageBox.Show($"Xem chi tiết công việc: {ucJobCard.Id}");
        }

        /// <summary>
        /// Event khi click vào menu của UCJobCard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcJobCard_MenuClick(object sender, EventArgs e)
        {
            var ucJobCard = sender as UCJobCard;
            MessageBox.Show($"Menu công việc: {ucJobCard.Id}");
        }
        #endregion JobList

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {
            LoadJobList();
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

            var selectedTinh = this.comboBox_DiaDiem.SelectedItem as Tinh;
            searchCriteria.DiaDiem = selectedTinh != null ? selectedTinh.Code : null;

            searchCriteria.NgheNghiep = this.comboBox_NgheNghiep.Text;

            searchCriteria = KinhNghiemBuilder(searchCriteria);
            searchCriteria = MucLuongBuilder(searchCriteria);

            return searchCriteria;
        }

        private TimKiemViecLamDto KinhNghiemBuilder(TimKiemViecLamDto timKiemViecLamDto)
        {
            switch (this.comboBox_KinhNghiem.Text)
            {
                case KinhNghiemConstants.All:
                    timKiemViecLamDto.MinKinhNghiem = null;
                    timKiemViecLamDto.MaxKinhNghiem = null;
                    break;
                case KinhNghiemConstants.Duoi1Nam:
                    timKiemViecLamDto.MinKinhNghiem = 0;
                    timKiemViecLamDto.MaxKinhNghiem = 1;
                    break;
                case KinhNghiemConstants.Tu1Den2Nam:
                    timKiemViecLamDto.MinKinhNghiem = 1;
                    timKiemViecLamDto.MaxKinhNghiem = 2;
                    break;
                case KinhNghiemConstants.Tu2Den5Nam:
                    timKiemViecLamDto.MinKinhNghiem = 2;
                    timKiemViecLamDto.MaxKinhNghiem = 5;
                    break;
                case KinhNghiemConstants.Tren5Nam:
                    timKiemViecLamDto.MinKinhNghiem = 5;
                    timKiemViecLamDto.MaxKinhNghiem = null;
                    break;
                case KinhNghiemConstants.KhongYeuCau:
                    timKiemViecLamDto.MinKinhNghiem = -1;
                    timKiemViecLamDto.MaxKinhNghiem = -1;
                    break;
            }
            return timKiemViecLamDto;
        }

        private TimKiemViecLamDto MucLuongBuilder(TimKiemViecLamDto timKiemViecLamDto)
        {
            switch (this.comboBox_MucLuong.Text)
            {
                case MucLuongConstants.All:
                    timKiemViecLamDto.MinLuong = null;
                    timKiemViecLamDto.MaxLuong = null;
                    timKiemViecLamDto.LuongThoaThuan = false;
                    break;
                case MucLuongConstants.Duoi10Trieu:
                    timKiemViecLamDto.MinLuong = 0;
                    timKiemViecLamDto.MaxLuong = 10;
                    break;
                case MucLuongConstants.Tu10Den15Trieu:
                    timKiemViecLamDto.MinLuong = 10;
                    timKiemViecLamDto.MaxLuong = 15;
                    break;
                case MucLuongConstants.Tu15Den20Trieu:
                    timKiemViecLamDto.MinLuong = 15;
                    timKiemViecLamDto.MaxLuong = 20;
                    break;
                case MucLuongConstants.Tu20Den25Trieu:
                    timKiemViecLamDto.MinLuong = 20;
                    timKiemViecLamDto.MaxLuong = 25;
                    break;
                case MucLuongConstants.Tu25Den30Trieu:
                    timKiemViecLamDto.MinLuong = 25;
                    timKiemViecLamDto.MaxLuong = 30;
                    break;
                case MucLuongConstants.Tu30Den50Trieu:
                    timKiemViecLamDto.MinLuong = 30;
                    timKiemViecLamDto.MaxLuong = 50;
                    break;
                case MucLuongConstants.Tren50Trieu:
                    timKiemViecLamDto.MinLuong = 50;
                    timKiemViecLamDto.MaxLuong = null;
                    break;
                case MucLuongConstants.ThoaThuan:
                    timKiemViecLamDto.MinLuong = null;
                    timKiemViecLamDto.MaxLuong = null;
                    timKiemViecLamDto.LuongThoaThuan = true;
                    break;
            }
            return timKiemViecLamDto;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            LoadJobList();
        }
    }
}
