using FinalProject.Common;
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
    public partial class FQlyCv : UCForm
    {
        private CvBUS cvBUS = new CvBUS();
        private List<CV> listCV = new List<CV>();

        public FQlyCv()
        {
            InitializeComponent();
        }

        private void FQlyCv_Load(object sender, EventArgs e)
        {
            listCV = cvBUS.GetByUngVienId(LoggedUser.UserId);
            LoadCvList();
        }

        private void LoadCvList()
        {
            ucPagination.TotalRecord = cvBUS.Count();
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
                ucCvCard.CvClick += button_View_Click;
                ucCvCard.CvDelete += button_Xoa_Click;
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
            //this.Hide();

            FTaoCv fTaoCv = new FTaoCv();
            fTaoCv.ShowDialog();

            this.FQlyCv_Load(this, EventArgs.Empty);
            //this.Show();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            var tenCv = textBox_TenCv.Text;
            listCV = cvBUS.TimKiem(tenCv);
            LoadCvList();
        }

        private void textBox_TenCv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_TimKiem_Click(this, EventArgs.Empty);
            }
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            FTaoCv fTaoCv = new FTaoCv();
            fTaoCv.Id = (sender as UCCvCard).Id;
            fTaoCv.ShowDialog();

            // Reload data after update
            this.FQlyCv_Load(this, EventArgs.Empty);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            var id = (sender as UCCvCard).Id;

            if (cvBUS.CheckExist(id) == 0)
            {
                MessageBox.Show("Không tìm thấy CV");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa CV này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cvBUS.SoftDelete(id);
                this.FQlyCv_Load(this, EventArgs.Empty);
                MessageBox.Show("Xóa CV thành công");
            }
        }
    }
}
