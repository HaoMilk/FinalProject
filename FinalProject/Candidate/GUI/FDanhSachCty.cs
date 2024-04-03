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
    public partial class FDanhSachCty : UCForm
    {
        public FDanhSachCty()
        {
            InitializeComponent();
        }

        private void FDanhSachCty_Load(object sender, EventArgs e)
        {
            InitListCongTy();
        }

        #region JobList
        private void InitListCongTy()
        {
            var quantity = ucPagination.PageSize;
            var start = ucPagination.StartRecord;
            var end = ucPagination.EndRecord;

            var UCCtyCards = CreateCongTyList(quantity);
            flowLayoutPanel_DanhSach.Controls.Clear();

            foreach (var UCCtyCard in UCCtyCards)
            {
                flowLayoutPanel_DanhSach.Controls.Add(UCCtyCard);
            }
            this.flowLayoutPanel_DanhSach.Text = "Số lượng công ty: " + UCCtyCards.Count;
        }

        private List<UCCtyCard> CreateCongTyList(int quantity)
        {
            List<UCCtyCard> UCCtyCards = new List<UCCtyCard>();
            for (int i = 0; i < quantity; i++)
            {
                UCCtyCard ctyCard = new UCCtyCard();
                ctyCard.Id = (i + 1);
                ctyCard.Name = $"Công ty {i + 1}";
                ctyCard.Description = $"Giới thiệu về công ty {i + 1}";

                UCCtyCards.Add(ctyCard);
            }
            return UCCtyCards;
        }
        #endregion JobList

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {

        }
    }
}
