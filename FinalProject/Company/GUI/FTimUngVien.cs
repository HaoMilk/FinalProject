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
using System.Windows.Documents;
using System.Windows.Forms;

namespace FinalProject.Company.GUI
{
    public partial class FTimUngVien : UCForm
    {
        private CvBUS cvBUS = new CvBUS();
        private List<CV> listCV = new List<CV>();
        public FTimUngVien()
        {
            InitializeComponent();
        }

        private void FTimUngVien_Load(object sender, EventArgs e)
        {
            LoadCvList();
        }
        private void LoadCvList()
        {

            var quantity = cvBUS.Count();
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
                ucCvCard.ViTriUngTuyen = listCV[i].ViTriUngTuyen;
                ucCvCard.LastUpdatedTime = listCV[i].UpdatedTime ?? DateTime.Now;
/*                ucCvCard.CvClick += button_View_Click;
                ucCvCard.CvDelete += button_Xoa_Click;*/
                //ucCvCard.ScaleSize(0.5f);

                ucCvCards.Add(ucCvCard);
            }
            return ucCvCards;
        }

    }
}
