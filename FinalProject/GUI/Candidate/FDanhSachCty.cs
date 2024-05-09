using FinalProject.Common.BUS;
using FinalProject.Common.DTO;
using FinalProject.Database;
using FinalProject.GUI.Company;
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

namespace FinalProject.GUI.Candidate
{
    public partial class FDanhSachCty : UCForm
    {
        private List<CongTy> _listCongTy = new List<CongTy>();
        private CongTyBUS _congTyBUS = new CongTyBUS();
        private List<UCCtyCard> ucCtyCards = new List<UCCtyCard>();

        public FDanhSachCty()
        {
            InitializeComponent();
        }

        private void FDanhSachCty_Load(object sender, EventArgs e)
        {
            _listCongTy = _congTyBUS.GetAll();
            //ucPagination.TotalRecord = _listCongTy.Count;
            LoadListCongTy();
        }

        private void LoadListCongTy()
        {
            this.ucCtyCards = new List<UCCtyCard>();

            for (int i = 0; i < _listCongTy.Count; i++)
            {
                UCCtyCard ctyCard = new UCCtyCard();
                ctyCard.Id = _listCongTy[i].ID;
                ctyCard.CongTy = _listCongTy[i];
                ctyCard.ViewClick += CtyCard_ViewClick;

                this.ucCtyCards.Add(ctyCard);
            }
            flowLayoutPanel_DanhSach.Controls.Clear();
            flowLayoutPanel_DanhSach.SuspendLayout();
            flowLayoutPanel_DanhSach.Controls.AddRange(this.ucCtyCards.ToArray());
            flowLayoutPanel_DanhSach.ResumeLayout();
 
            this.flowLayoutPanel_DanhSach.Text = "Số lượng công ty: " + _listCongTy.Count;
        }

        private void CtyCard_ViewClick(object sender, EventArgs e)
        {
            var ucCtyCard = sender as UCCtyCard;
            FThongTinCongTy fThongTinCongTy = new FThongTinCongTy();
            fThongTinCongTy.Id = ucCtyCard.Id;
            fThongTinCongTy.ShowDialog();

            // Reload lai danh sach cong ty
            this.TimKiem();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            this.TimKiem();
        }

        private void TimKiem()
        {
            // Lấy du lieu tim kiem
            // Goi ham search tu BUS,luu lại vào biến tạm.
            // cập nhật giao diện.
            var input = new CongTyGetAllInput();
            input.TenCongTy = textBox_TimKiem.Text;

            _listCongTy = _congTyBUS.Search(input);
            this.LoadListCongTy();
        }
    }
}
