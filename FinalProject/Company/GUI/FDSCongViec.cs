using FinalProject.Candidate.Constants;
using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.DTO;
using FinalProject.Database.DTO;
using FinalProject.Database.Entities;
using FinalProject.UC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Company.GUI
{
    public partial class FDSViecLam : Form
    {
        private TinhBUS tinhBUS = new TinhBUS();
        private List<Tinh> listTinh = new List<Tinh>();
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<CongViec> listCongViec = new List<CongViec>();

        public FDSViecLam()
        {
            InitializeComponent();

            this.listTinh = tinhBUS.GetAll();
            this.comboBox_DiaDiem.Items.Clear();
            this.comboBox_DiaDiem.Items.AddRange(this.listTinh.ToArray());

            var listKinhNghiem = KinhNghiemConstants.GetKinhNghiemList();
            this.comboBox_KinhNghiem.Items.AddRange(listKinhNghiem.ToArray());
            this.comboBox_KinhNghiem.SelectedIndex = 0;

            var listMucLuong = MucLuongConstants.GetMucLuongList();
            this.comboBox_MucLuong.Items.AddRange(listMucLuong.ToArray());
            this.comboBox_MucLuong.SelectedIndex = 0;

            var listNgheNghiep = NgheNghiepConstants.GetNgheNghiepList();
            this.comboBox_NgheNghiep.Items.AddRange(listNgheNghiep.ToArray());
            this.comboBox_NgheNghiep.SelectedIndex = 0;
        }

        #region JobList

        private void LoadJobList(List<CongViec> danhSachViecLam)
        {
            ucPagination.TotalRecord = danhSachViecLam.Count;

            List<UCViewJob> ucViewJobs = new List<UCViewJob>();
            if (danhSachViecLam != null && danhSachViecLam.Count > 0)
            {
                for (int i = 0; i < danhSachViecLam.Count; i++)
                {
                    UCViewJob ucViewJob = new UCViewJob();
                    ucViewJob.Id = danhSachViecLam[i].Id;
                    ucViewJob.JobName = danhSachViecLam[i].Ten;
                    ucViewJobs.Add(ucViewJob);
                }
            }

            flowLayoutPanel_CongViec.Controls.Clear();
            foreach (var ucViewJob in ucViewJobs)
            {
                flowLayoutPanel_CongViec.Controls.Add(ucViewJob);
            }
        }
        #endregion JobList

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {
            SearchCongViec();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchCongViec();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
            SearchCongViec();
        }

        private void SearchCongViec()
        {
            var input = new CongViecGetAllInput();
            input.Search = textBox_TimKiem.Text;
            input.NgheNghiep = comboBox_NgheNghiep.Text;

            var selectedTinh = this.comboBox_DiaDiem.SelectedItem as Tinh;
            input.DiaDiem = selectedTinh != null ? selectedTinh.Code : null;

            input = input.SetKinhNghiem(comboBox_KinhNghiem.Text);
            input = input.SetMucLuong(comboBox_MucLuong.Text);

            input.FromId = ucPagination.StartRecord;
            input.ToId = ucPagination.EndRecord;

            listCongViec = congViecBUS.Search(input);

            LoadJobList(listCongViec);
        }
    }
}
