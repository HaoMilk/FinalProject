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
using System.Windows.Forms;

namespace FinalProject.Candidate.GUI
{
    public partial class FDanhSachCty : UCForm
    {
        private List<CongTy> _listCongTy = new List<CongTy>();
        private CongTyBUS _congTyBUS = new CongTyBUS();

        public FDanhSachCty()
        {
            InitializeComponent();
        }

        private void FDanhSachCty_Load(object sender, EventArgs e)
        {
            _listCongTy = _congTyBUS.GetAll();
            ucPagination.TotalRecord = _listCongTy.Count;
            LoadListCongTy();
        }

        private void LoadListCongTy()
        {
            List<UCCtyCard> UCCtyCards = new List<UCCtyCard>();
            for (int i = 0; i < _listCongTy.Count; i++)
            {
                UCCtyCard ctyCard = new UCCtyCard();
                ctyCard.Id = _listCongTy[i].ID;
                ctyCard.Name = _listCongTy[i].TenCongTy;
                ctyCard.Address = _listCongTy[i].DiaChi;

                UCCtyCards.Add(ctyCard);
            }
            flowLayoutPanel_DanhSach.Controls.Clear();

            foreach (var UCCtyCard in UCCtyCards)
            {
                flowLayoutPanel_DanhSach.Controls.Add(UCCtyCard);
            }
            this.flowLayoutPanel_DanhSach.Text = "Số lượng công ty: " + UCCtyCards.Count;
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {

        }
    }
}
