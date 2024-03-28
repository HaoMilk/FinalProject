using FinalProject.Common.BUS;
using FinalProject.Common.DAO;
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
    public partial class FQlyCv : Form
    {
        private CvBUS cvBUS = new CvBUS();
        private List<CV> listCV = new List<CV>();

        public FQlyCv()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void button_ChonFile_Click(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FQlyCv_Load(object sender, EventArgs e)
        {
            ucPagination.TotalRecord = cvBUS.Count();
            LoadCvList();
        }

        private void LoadCvList()
        {
            var quantity = ucPagination.PageSize;
            var start = ucPagination.StartRecord;
            var end = ucPagination.EndRecord;

            var ucJobCards = CreateCvList(quantity);
            flowLayoutPanel_Data.Controls.Clear();

            foreach (var ucJobCard in ucJobCards)
            {
                flowLayoutPanel_Data.Controls.Add(ucJobCard);
            }
            //this.flowLayoutPanel_Data.Text = "Số lượng việc làm đã ứng tuyển: " + ucJobCards.Count;
        }

        private List<UCCvCard> CreateCvList(int quantity)
        {
            listCV = cvBUS.GetAll();

            List<UCCvCard> ucCvCards = new List<UCCvCard>();

            if (listCV.Count == 0)
            {
                return ucCvCards;
            }

            for (int i = 0; i < listCV.Count; i++)
            {
                UCCvCard ucCvCard = new UCCvCard();
                ucCvCard.Id = listCV[i].Id;
                ucCvCard.CvName = listCV[i].Ten;
                ucCvCard.LastUpdatedTime = listCV[i].UpdatedTime ?? DateTime.Now;
                //ucCvCard.ScaleSize(0.5f);

                ucCvCards.Add(ucCvCard);
            }
            return ucCvCards;
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            LoadCvList();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            FTaoCv fTaoCv = new FTaoCv();
            fTaoCv.ShowDialog();

        }
    }
}
