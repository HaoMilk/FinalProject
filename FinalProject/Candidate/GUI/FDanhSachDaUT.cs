using FinalProject.Common.BUS;
using FinalProject.Common.Const;
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
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<UngTuyenDTO> listUngTuyen = new List<UngTuyenDTO>();
        private UngTuyenBUS ungTuyenBUS = new UngTuyenBUS();

        public FDanhSachDaUT()
        {
            InitializeComponent();
           
            this.ucComboBox_TrangThai.Items = UCComboBox.TrangThaiUngTuyenItems;
            this.ucComboBox_TrangThai.SelectedIndex = 0;
        }

        #region JobList
        private void LoadJobList()
        {
            var ucJobCards = CreateJobCards();
            flowLayoutPanel_Data.Controls.Clear();
            flowLayoutPanel_Data.SuspendLayout();
            flowLayoutPanel_Data.Controls.AddRange(ucJobCards.ToArray());
            flowLayoutPanel_Data.ResumeLayout();
        }

        private List<UCJobCard> CreateJobCards()
        {
            var ucJobCards = new List<UCJobCard>();

            if (listUngTuyen.Count == 0)
            {
                return ucJobCards;
            }

            for (int i = 0; i < listUngTuyen.Count; i++)
            {
                UCJobCard ucJobCard = new UCJobCard();
                ucJobCard.Id = listUngTuyen[i].CongViecId;
                ucJobCard.UngTuyenId = listUngTuyen[i].Id;
                ucJobCard.CongViec = congViecBUS.GetById(listUngTuyen[i].CongViecId);
                ucJobCard.ViewClick += UcJobCard_ViewClick;
                //ucJobCard.ScaleSize(0.5f);
                if (listUngTuyen[i].TenCongTy == "FPT Software")
                {
                    ucJobCard.pictureBox_Logo.Image = Properties.Resources.FPT;
                }
                else if (listUngTuyen[i].TenCongTy == "Utop")
                {
                    ucJobCard.pictureBox_Logo.Image = Properties.Resources.UTOP;
                }
                else if (listUngTuyen[i].TenCongTy == "Viet Travel")
                {
                    ucJobCard.pictureBox_Logo.Image = Properties.Resources.VietTravel;
                }
                else if (listUngTuyen[i].TenCongTy == "FPT Shop")
                {
                    ucJobCard.pictureBox_Logo.Image = Properties.Resources.FPTShop;
                }
                else if (listUngTuyen[i].TenCongTy == "BOSCH")
                {
                    ucJobCard.pictureBox_Logo.Image = Properties.Resources.BOSCH;
                }

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
            FChiTietCongViec fChiTietCv = new FChiTietCongViec();
            fChiTietCv.Id = ucJobCard.Id;
            fChiTietCv.UngTuyenId = ucJobCard.UngTuyenId;
            fChiTietCv.CvName = ucJobCard.CongViec?.Ten;
            fChiTietCv.ShowDialog();

            // Reload lại danh sách công việc
            TimKiem();
        }

        #endregion JobList

        private void FDanhSachDaUT_Load(object sender, EventArgs e)
        {
            this.listUngTuyen = ungTuyenBUS.GetAll();
            LoadJobList();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
           TimKiem();
        }

        private void TimKiem()
        {
            var input = new UngTuyenGetAllInput();
            input.TrangThai = ucComboBox_TrangThai.SelectedItem?.Value as string;

            this.listUngTuyen = ungTuyenBUS.Search(input);
            this.LoadJobList();
        }
    }
}
