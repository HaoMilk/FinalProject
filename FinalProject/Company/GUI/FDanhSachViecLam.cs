using FinalProject.Common;
using FinalProject.Common.BUS;
using FinalProject.Common.Const;
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
        UCDanhSachViecLam UC = new UCDanhSachViecLam();

        public FDanhSachViecLam()
        {
            InitializeComponent();
            UC = this.UC_DSVL;
            UC.button_Close.Click += button_Close_Click;
            UC.button_TimKiem.Click += button_TimKiem_Click;
            var listKinhNghiem = KinhNghiemConstants.GetKinhNghiemList();
            this.UC.comboBox_KinhNghiem.Items.AddRange(listKinhNghiem.ToArray());
            this.UC.comboBox_KinhNghiem.SelectedIndex = 0;

            var listMucLuong = MucLuongConstants.GetMucLuongList();
            this.UC.comboBox_MucLuong.Items.AddRange(listMucLuong.ToArray());
            this.UC.comboBox_MucLuong.SelectedIndex = 0;

            var listNgheNghiep = NgheNghiepConstants.GetNgheNghiepList();
            this.UC.comboBox_NgheNghiep.Items.AddRange(listNgheNghiep.ToArray());
            this.UC.comboBox_NgheNghiep.SelectedIndex = 0;
        }
        #region JobList

        private void LoadJobList()
        {
            UC.ucPagination.TotalRecord = listCongViec.Count;

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

            UC.flowLayoutPanel_CongViec.Controls.Clear();
            UC.flowLayoutPanel_CongViec.SuspendLayout();
            UC.flowLayoutPanel_CongViec.Controls.AddRange(uCViewJobs.ToArray());
            UC.flowLayoutPanel_CongViec.ResumeLayout();
        }
        #endregion JobList
        private void UC_DSVL_Load(object sender, EventArgs e)
        {
            LoadJobList();
        }
        private void LoadCongViec()
        {
            listCongViec = congViecBUS.GetByIDCty(LoggedUser.CongTy.ID);
        }
        private void button_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
