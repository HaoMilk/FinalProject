using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace FinalProject.Admin.GUI.ThongKe
{
    public partial class FThongKeCongViec : Form
    {
        string conn = Properties.Settings.Default.connectionString;
        ChartHelper chartHelper = new ChartHelper();
        public FThongKeCongViec()
        {
            InitializeComponent();

            DataTable dtViTri = LayThongTinViTri(conn);
            ChartHelper.ThemDuLieu(ViTriTuyenDungPhoBien, dtViTri, "ViTriTuyenDung", "SoLuong", "Vị trí tuyển dụng", "Số lượng", SeriesChartType.Column, "NHỮNG VỊ TRÍ TUYỂN DỤNG PHỔ BIẾN");
            DataTable diaDiem = LayDiaDiem(conn);
            ChartHelper.ThemDuLieu(DiaDiem, diaDiem, "DiaDiem", "SoLuong", "Địa điểm", "Số lượng", SeriesChartType.Pie, "PHÂN BỐ VIỆC LÀM THEO ĐỊA ĐIỂM");
            DataTable nganh = LayNganh(conn);
            ChartHelper.ThemDuLieu(Nganh, nganh, "Nganh", "SoLuong", "Ngành", "Số lượng", SeriesChartType.Column, "SỐ LƯƠNG CÔNG VIỆC CỦA MỖI NGÀNH");
            DataTable luongTheoDiaDiem = LuongDiaDiem(conn);
            ChartHelper.ThemDuLieu(LuongTheoDiaDiem, luongTheoDiaDiem, "DiaDiem", "TongLuong", "Địa điểm", "Tổng lương", SeriesChartType.Column, "MỨC LƯƠNG PHÂN BỐ THEO KHU VỰC");
        }
        private DataTable LayThongTinViTri(string conn)
        {
            string query = "SELECT Nganh, ViTriTuyenDung, COUNT(*) AS SoLuong FROM CongViec GROUP BY Nganh, ViTriTuyenDung ORDER BY Nganh, ViTriTuyenDung";
            return chartHelper.LayDuLieu(query,conn);
        }
        private DataTable LayDiaDiem(string conn)
        {
            string query = "SELECT DiaDiem, COUNT(*) AS SoLuong FROM CongViec GROUP BY DiaDiem";
            return chartHelper.LayDuLieu(query, conn);
        }
        private DataTable LayNganh(string conn)
        {
            string query = "SELECT Nganh, COUNT(*) AS SoLuong FROM CongViec GROUP BY Nganh ORDER BY SoLuong ASC";
            return chartHelper.LayDuLieu(query, conn);
        }
        DataTable LuongDiaDiem(string conn)
        {
            string query = "SELECT DiaDiem, SUM(MucLuong) AS TongLuong FROM CongViec GROUP BY DiaDiem ORDER BY TongLuong ASC";
            return chartHelper.LayDuLieu(query, conn);
        }
    }
}