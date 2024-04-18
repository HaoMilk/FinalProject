using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Const;
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

namespace FinalProject.Company.GUI
{
    public partial class FDanhSachViecLam : Form
    {
        private TinhBUS tinhBUS = new TinhBUS();
        private List<Tinh> listTinh = new List<Tinh>();
        private CongViecBUS congViecBUS = new CongViecBUS();
        private List<CongViec> listCongViec = new List<CongViec>();

        public FDanhSachViecLam()
        {
            InitializeComponent();
            this.listTinh = tinhBUS.GetAll();
            this.comboBox_DiaDiem.Items.Clear();
            this.comboBox_DiaDiem.Items.AddRange(this.listTinh.ToArray());

            var listKinhNghiem = KinhNghiemConsts.GetKinhNghiemList();
            this.comboBox_KinhNghiem.Items.AddRange(listKinhNghiem.ToArray());
            this.comboBox_KinhNghiem.SelectedIndex = 0;

            var listMucLuong = MucLuongConstants.GetMucLuongList();
            this.comboBox_MucLuong.Items.AddRange(listMucLuong.ToArray());
            this.comboBox_MucLuong.SelectedIndex = 0;

            var listNgheNghiep = NgheNghiepConts.GetNgheNghiepList();
            this.comboBox_NgheNghiep.Items.AddRange(listNgheNghiep.ToArray());
            this.comboBox_NgheNghiep.SelectedIndex = 0;
        }
        #region JobList

        private void LoadJobList()
        {
            ucPagination.TotalRecord = listCongViec.Count;

            List<UCViewJob> uCViewJobs = new List<UCViewJob>();
            if (listCongViec != null && listCongViec.Count > 0)
            {
                for (int i = 0; i < listCongViec.Count; i++)
                {

                    UCViewJob uCViewJob = new UCViewJob();
                    uCViewJob.Id = listCongViec[i].Id;
                    uCViewJob.JobName = listCongViec[i].Ten;
                    //ucJobCard.LastUpdatedTime = listCongViec[i].UpdatedTime;
                    //ucJobCard.ScaleSize(0.5f);

                    uCViewJobs.Add(uCViewJob);
                }
            }

            flowLayoutPanel_CongViec.Controls.Clear();
            flowLayoutPanel_CongViec.SuspendLayout();
            flowLayoutPanel_CongViec.Controls.AddRange(uCViewJobs.ToArray());
            flowLayoutPanel_CongViec.ResumeLayout();
        }
        #endregion JobList

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDanhSachViecLam_Load(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList();
        }
        private void SearchCongViec()
        {
            var input = new CongViecGetAllInput();
            input.Search = textBox_TimKiem.Text;
            input.Nganh = comboBox_NgheNghiep.Text;

            var selectedTinh = this.comboBox_DiaDiem.SelectedItem as Tinh;
            if (selectedTinh != null)
            {
                input.DiaDiem = comboBox_DiaDiem.Text;
            }
            else
            {
                input.DiaDiem = null;
            }

            input = input.SetKinhNghiem(comboBox_KinhNghiem.Text);
            input = input.SetMucLuong(comboBox_MucLuong.Text);

            input.FromId = ucPagination.StartRecord;
            input.ToId = ucPagination.EndRecord;

            listCongViec = congViecBUS.GetByIDCty(input, LoggedUser.CongTy.ID);
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            SearchCongViec();
            LoadJobList() ;
        }
    }
}
