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
    public partial class FDanhSachDaUT : Form
    {
        public FDanhSachDaUT()
        {
            InitializeComponent();
        }

        #region JobList
        private void InitJobList()
        {
            var ucJobCards = CreateJobList(20);
            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_Data.Controls.Add(ucJobCard);
            }
            //this.flowLayoutPanel_Data.Text = "Số lượng việc làm đã ứng tuyển: " + ucJobCards.Count;
        }

        private List<UCJobCard> CreateJobList(int quantity)
        {
            List<UCJobCard> ucJobCards = new List<UCJobCard>();
            for (int i = 0; i < quantity; i++)
            {
                UCJobCard ucJobCard = new UCJobCard();
                ucJobCard.Id = (i + 1);
                ucJobCard.JobName = $"Việc làm {i + 1}";
                ucJobCard.LastUpdatedTime = DateTime.Now;
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
            InitJobList();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
