using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Const;
using FinalProject.Common.DTO;
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

namespace FinalProject.GUI.Candidate
{
    public partial class FDanhSachVL_Name : UCForm
    {
        private static TinhBUS tinhBUS = new TinhBUS();
        private static List<Tinh> listTinh = tinhBUS.GetAll();
        private static List<string> listKinhNghiem = KinhNghiemConsts.GetKinhNghiemList();
        private static List<string> listMucLuong = MucLuongConstants.GetMucLuongList();
        private static List<string> listNgheNghiep = NgheNghiepConts.GetNgheNghiepList();
        private static List<string> listGioiTinh = GioiTinhConsts.GetGioiTinhList();
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<CongViec> listCongViec = new List<CongViec>();

        public FDanhSachVL_Name()
        {
            InitializeComponent();

            this.ucComboBox_DiaDiem.SetItems(listTinh);
            this.ucComboBox_KinhNghiem.SetItems(listKinhNghiem);
            this.ucComboBox_Luong.SetItems(listMucLuong);
            this.ucComboBox_Nganh.SetItems(listNgheNghiep);

            var items = new ComboBoxItem[]
            {
                new ComboBoxItem { Text = "Tất cả", Value = string.Empty },
                new ComboBoxItem { Text = "Nam", Value = GioiTinhConsts.Male },
                new ComboBoxItem { Text = "Nữ", Value = GioiTinhConsts.Female },
                new ComboBoxItem { Text = "Khác", Value = GioiTinhConsts.Others },
            };
            this.ucComboBox_GioiTinh.Items = items;
            this.ucComboBox_GioiTinh.SelectedIndex = 0;

            //this.dateTimePicker_FromDate.Value = DateTime.Now.AddDays(-7);
        }

        #region JobList

        private void LoadJobList()
        {
            //ucPagination.TotalRecord = listCongViec.Count;

            List<UCJobCard> ucJobCards = new List<UCJobCard>();
            if (listCongViec != null && listCongViec.Count > 0)
            {
                for (int i = 0; i < listCongViec.Count; i++)
                {
                    UCJobCard ucJobCard = new UCJobCard();
                    ucJobCard.Id = listCongViec[i].Id;
                    ucJobCard.CongViec = congViecBUS.GetById(listCongViec[i].Id);
                    ucJobCard.ViewClick += UcJobCard_ViewClick;

                    ucJobCards.Add(ucJobCard);
                }
            }

            flowLayoutPanel_CongViec.Controls.Clear();
            flowLayoutPanel_CongViec.SuspendLayout();
            flowLayoutPanel_CongViec.Controls.AddRange(ucJobCards.ToArray());
            flowLayoutPanel_CongViec.ResumeLayout();
        }

        private void UcJobCard_ViewClick(object sender, EventArgs e)
        {
            var ucJobCard = sender as UCJobCard;
            FChiTietCongViec fChiTietCv = new FChiTietCongViec();
            fChiTietCv.Id = ucJobCard.Id;
            fChiTietCv.UngTuyenId = ucJobCard.UngTuyenId;
            fChiTietCv.CvName = ucJobCard.CongViec?.Ten;
            fChiTietCv.ShowDialog();
        }


        #endregion JobList

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }

        private void SearchCongViec()
        {
            var input = new CongViecGetAllInput();
            input.Search = textBox_TimKiem.Text;
            input.Nganh = ucComboBox_Nganh.Text;

            //var selectedTinh = this.comboBox_DiaDiem.SelectedItem as Tinh;
            //input.DiaDiem = selectedTinh != null ? selectedTinh.Ten : null;
            input.DiaDiem = ucComboBox_DiaDiem.Text;

            input = input.SetKinhNghiem(ucComboBox_KinhNghiem.Text);
            input = input.SetMucLuong(ucComboBox_Luong.Text);
            input.GioiTinh = ucComboBox_GioiTinh.SelectedValue as string;
            //input.FromDate = dateTimePicker_FromDate.Value;
            input.IdCongTy = LoggedUser.CongTy?.ID;
            //input.FromId = ucPagination.StartRecord;
            //input.ToId = ucPagination.EndRecord;

            listCongViec = congViecBUS.Search(input);
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
