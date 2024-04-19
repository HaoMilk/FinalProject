using FinalProject.Common.BUS;
using FinalProject.Common.DTO;
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
            flowLayoutPanel_DanhSach.SuspendLayout();
            flowLayoutPanel_DanhSach.Controls.AddRange(UCCtyCards.ToArray());
            flowLayoutPanel_DanhSach.ResumeLayout();
 
            this.flowLayoutPanel_DanhSach.Text = "Số lượng công ty: " + UCCtyCards.Count;
        } 

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
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
