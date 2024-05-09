using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject.Admin.GUI.ThongKe.Class
{
    public partial class FThongKeUngVien : Form
    {
        string conn = Properties.Settings.Default.connectionString;
        ChartHelper chartHelper = new ChartHelper();
        public FThongKeUngVien()
        {
            InitializeComponent();

            DataTable dtChuyenMon = DemChuyenMon(conn);
            ChartHelper.ThemDuLieu(ChuyenMon, dtChuyenMon, "ChuyenMon", "SoLuongUngVien", "Chuyên môn", "Số lượng", SeriesChartType.Column, "XU HƯỚNG CHUYÊN MÔN HÓA");
            DataTable dtKinhNghiem = DemKinhNghiem(conn);
            ChartHelper.ThemDuLieu(KinhNghiem, dtKinhNghiem, "KinhNghiem", "SoLuong", "Kinh nghiệm", "Số lượng", SeriesChartType.Pie, "KINH NGHIỆM");
            DataTable dtViTri = ViTriCongViec(conn);
            ChartHelper.ThemDuLieu(ViTriTuyenDung, dtViTri, "ViTriUngTuyen", "SoLuong", "Vị trí ứng tuyển", "Số lượng", SeriesChartType.Column, "VỊ TRÍ ỨNG TUYÊN PHỔ BIẾN");
            DataTable dtNgoaiNgu = NgoaiNgu(conn);
            ChartHelper.ThemDuLieu(TrinhDoNgoaiNgu, dtNgoaiNgu, "NgoaiNgu", "SoLuong", "Ngoại ngữ", "Số lượng", SeriesChartType.Column, "TRÌNH ĐỘ NGOẠI NGỮ ỨNG VIÊN");
        }
        DataTable DemChuyenMon(string conn)
        {
            string query = "SELECT ChuyenMon, COUNT(*) AS SoLuongUngVien FROM UngVien GROUP BY ChuyenMon";
            return chartHelper.LayDuLieu(query, conn);

        }
        DataTable DemKinhNghiem(string conn)
        {
            string query = "SELECT KinhNghiem, COUNT(*) AS SoLuong FROM CV GROUP BY KinhNghiem";
            return chartHelper.LayDuLieu(query, conn);

        }
        DataTable ViTriCongViec(string conn)
        {
            string query = "SELECT ViTriUngTuyen, COUNT(*) AS SoLuong FROM CV GROUP BY ViTriUngTuyen";
            return chartHelper.LayDuLieu(query, conn);

        }
        DataTable NgoaiNgu(string conn)
        {
            string query = "SELECT NgoaiNgu, COUNT(*) AS SoLuong FROM CV GROUP BY NgoaiNgu";
            return chartHelper.LayDuLieu(query, conn);

        }
    }
}
