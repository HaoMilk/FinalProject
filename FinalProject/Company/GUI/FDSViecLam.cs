using FinalProject.Common.Const;
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

/*            var listKinhNghiem = KinhNghiemConstants.GetKinhNghiemList();
            this.comboBox_KinhNghiem.Items.AddRange(listKinhNghiem.ToArray());
            this.comboBox_KinhNghiem.SelectedIndex = 0;*/

            var listMucLuong = MucLuongConstants.GetMucLuongList();
            this.comboBox_MucLuong.Items.AddRange(listMucLuong.ToArray());
            this.comboBox_MucLuong.SelectedIndex = 0;

            var listNgheNghiep = NgheNghiepConstants.GetNgheNghiepList();
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

        private void FDanhSachVL_Load(object sender, EventArgs e)
        {
            LoadCongViec();
            LoadJobList();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPagination_CurrentPageChanged(object sender, EventArgs e)
        {
        }

        private void LoadCongViec()
        {
            listCongViec = congViecBUS.GetByIDCty(LoggedUser.CongTy.ID);
        }
    }
}
