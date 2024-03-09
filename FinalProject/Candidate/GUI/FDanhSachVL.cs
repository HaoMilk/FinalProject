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
    public partial class FDanhSachVL_Name : Form
    {
        public FDanhSachVL_Name()
        {
            InitializeComponent();

            var ucJobCards = CreateJobList(50);
            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_CongViec.Controls.Add(ucJobCard);
            }
            this.label_SoLuongViecLam.Text = "Số lượng việc làm: " + ucJobCards.Count;
        }

        private UCJobCard CreateJobCard(int id, string cvName, DateTime cvUpdatedTime)
        {
            UCJobCard ucJobCard = new UCJobCard();
            ucJobCard.Id = id;
            ucJobCard.CvName = cvName;
            ucJobCard.CvUpdatedTime = cvUpdatedTime;
            //ucJobCard.ScaleSize(0.5f);
            return ucJobCard;
        }

        private List<UCJobCard> CreateJobList(int quantity)
        {
            List<UCJobCard> ucJobCards = new List<UCJobCard>();
            for (int i = 0; i < quantity; i++)
            {
                ucJobCards.Add(CreateJobCard(i, "CV " + i, DateTime.Now));
            }
            return ucJobCards;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {

        }
    }
}
