﻿using FinalProject.Common.BUS;
using FinalProject.Common.Const;
using FinalProject.Common.DAO;
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
    public partial class FDanhSachDaUT : UCForm
    {
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();

        public FDanhSachDaUT()
        {
            InitializeComponent();
           
            this.ucComboBox_TrangThai.Items = UCComboBox.TrangThaiUngTuyenItems;
            this.ucComboBox_TrangThai.SelectedIndex = 0;
        }

        #region JobList
        private void LoadJobList()
        {
            //var quantity = ucPagination.PageSize;
            //var start = ucPagination.StartRecord;
            //var end = ucPagination.EndRecord;

            var ucJobCards = CreateJobList();
            flowLayoutPanel_Data.Controls.Clear();
            flowLayoutPanel_Data.SuspendLayout();
            flowLayoutPanel_Data.Controls.AddRange(ucJobCards.ToArray());
            flowLayoutPanel_Data.ResumeLayout();

            //this.flowLayoutPanel_Data.Text = "Số lượng việc làm đã ứng tuyển: " + ucJobCards.Count;
        }

        private List<UCJobCard> CreateJobList()
        {
            List<UCJobCard> ucJobCards = new List<UCJobCard>();

            if (listUngTuyen.Count == 0)
            {
                return ucJobCards;
            }

            for (int i = 0; i < listUngTuyen.Count; i++)
            {
                UCJobCard ucJobCard = new UCJobCard();
                ucJobCard.Id = listUngTuyen[i].CongViecId;
                ucJobCard.UngTuyenId = listUngTuyen[i].Id;
                ucJobCard.CongViec = congViecBUS.GetById(listUngTuyen[i].CongViecId);
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
            UCMessageBox.Show($"Xem chi tiết công việc: {ucJobCard.Id}");
        }

        /// <summary>
        /// Event khi click vào menu của UCJobCard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcJobCard_MenuClick(object sender, EventArgs e)
        {
            var ucJobCard = sender as UCJobCard;
            UCMessageBox.Show($"Menu công việc: {ucJobCard.Id}");
        }
        #endregion JobList

        private void FDanhSachDaUT_Load(object sender, EventArgs e)
        {
            this.listUngTuyen = ungTuyenBUS.GetAll();
            LoadJobList();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            LoadJobList();
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            var input = new UngTuyenGetAllInput();
            input.TrangThai = ucComboBox_TrangThai.SelectedItem?.Value as string;

            this.listUngTuyen = ungTuyenBUS.Search(input);
            this.LoadJobList();
        }
    }
}
