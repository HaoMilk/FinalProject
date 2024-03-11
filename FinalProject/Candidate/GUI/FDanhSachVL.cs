﻿using FinalProject.Candidate.Constants;
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

            this.comboBox_DiaDiem.SelectedIndex = 0;

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
            searchCriteria.DiaDiem = this.comboBox_DiaDiem.Text;
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
    }
}
