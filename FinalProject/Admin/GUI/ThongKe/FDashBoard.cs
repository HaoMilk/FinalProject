using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace FinalProject.Admin.GUI.ThongKe
{
    public partial class FDashBoard : Form
    {
        string conn = Properties.Settings.Default.connectionString;
        ChartHelper chartHelper = new ChartHelper();
        public FDashBoard()
        {
            InitializeComponent();
        }
        int DemSoCongViec(string connectionString)
        {
            string query = "SELECT COUNT(*) FROM CongViec";
            return chartHelper.DemSo(query, connectionString);
        }

        int DemSoUngVien(string connectionString)
        {
            string query = "SELECT COUNT(*) FROM UngVien";
            return chartHelper.DemSo(query, connectionString);
        }

        int DemSoCty(string connectionString)
        {
            string query = "SELECT COUNT(*) FROM CongTy";
            return chartHelper.DemSo(query, connectionString);
        }

        private void FDashBoard_Load(object sender, EventArgs e)
        {
            int soCV = DemSoCongViec(conn);
            txtSoLuongCongViec.Text = soCV.ToString();

            int soUV = DemSoUngVien(conn);
            txtSoLuongUngVien.Text = soUV.ToString();

            int soCty = DemSoCty(conn);
            txtSoLuongCongTy.Text = soCty.ToString();

            DataTable dataTableMucLuong = LayDuLieuTongLuongTheoNganh(conn);
            ChartHelper.ThemDuLieu(TopNganhLuongCaoNhat, dataTableMucLuong, "Nganh", "TongLuong", "Ngành", "Tổng Lương", SeriesChartType.Column, "TOP NHỮNG NGÀNH LƯƠNG CAO NHẤT");

            DataTable dataTableSoLuong = LayDuLieuSoLuongTheoNganh(conn);
            ChartHelper.ThemDuLieu(TiTrongCacNganh, dataTableSoLuong, "Nganh", "SoLuong", "Ngành", "Số Lượng", SeriesChartType.Pie,"TỈ TRỌNG GIỮA CÁC NGÀNH");
        }

        private DataTable LayDuLieuSoLuongTheoNganh(string connectionString)
        {
            string query = "SELECT Nganh, COUNT(*) AS SoLuong FROM CongViec GROUP BY Nganh";
            return chartHelper.LayDuLieu(query, connectionString);
        }
        private DataTable LayDuLieuTongLuongTheoNganh(string connectionString)
        {
            string query = "SELECT Nganh, SUM(MucLuong) AS TongLuong FROM CongViec GROUP BY Nganh ORDER BY TongLuong ASC";
            return chartHelper.LayDuLieu(query, connectionString);
        }
    }
}
