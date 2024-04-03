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
        private UngTuyenDAO ungTuyenDAO = new UngTuyenDAO();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();

        public FDanhSachDaUT()
        {
            InitializeComponent();
        }

        #region JobList
        private void LoadJobList()
        {
            var quantity = ucPagination.PageSize;
            var start = ucPagination.StartRecord;
            var end = ucPagination.EndRecord;

            var ucJobCards = CreateJobList(quantity);
            flowLayoutPanel_Data.Controls.Clear();

            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_Data.Controls.Add(ucJobCard);
            }
            //this.flowLayoutPanel_Data.Text = "Số lượng việc làm đã ứng tuyển: " + ucJobCards.Count;
        }

        private List<UCJobCard> CreateJobList(int quantity)
        {
            listUngTuyen = ungTuyenDAO.GetAll();

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
                ucJobCard.JobName = listUngTuyen[i].TenCongViec;
                ucJobCard.LastUpdatedTime = listUngTuyen[i].UpdatedTime ?? DateTime.Now;
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

        private void FDanhSachDaUT_Load(object sender, EventArgs e)
        {
            LoadJobList();
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
