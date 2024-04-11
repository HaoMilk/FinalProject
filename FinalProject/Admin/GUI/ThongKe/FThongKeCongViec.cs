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
        public FThongKeCongViec()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            string connectionString = Properties.Settings.Default.connectionString; // Lấy chuỗi kết nối từ Properties.Settings

            string query = "SELECT Nganh, MucLuong FROM CongViec"; // Câu truy vấn để lấy dữ liệu từ bảng công việc

            // Dictionary để lưu trữ tổng mức lương của mỗi ngành
            Dictionary<string, int> tongLuongTheoNganh = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenNganh = reader["Nganh"].ToString();
                            int luong = Convert.ToInt32(reader["MucLuong"]);

                            // Nếu ngành chưa có trong Dictionary, thêm vào và gán mức lương ban đầu là 0
                            if (!tongLuongTheoNganh.ContainsKey(tenNganh))
                            {
                                tongLuongTheoNganh[tenNganh] = 0;
                            }

                            // Cộng thêm mức lương cho ngành
                            tongLuongTheoNganh[tenNganh] += luong;
                        }
                    }
                }
            }

            // Thêm dữ liệu từ Dictionary vào biểu đồ cột
            foreach (var pair in tongLuongTheoNganh)
            {
                BieuDoCotLuong.Series["BieuDoCotLuong"].Points.AddXY(pair.Key, pair.Value);
            }

            // Thiết lập các thuộc tính của biểu đồ
            BieuDoCotLuong.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo mỗi tên ngành chỉ hiển thị một lần trên trục x
            BieuDoCotLuong.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt lưới chính trên trục x
            BieuDoCotLuong.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Tắt lưới chính trên trục y
            BieuDoCotLuong.ChartAreas[0].AxisX.LabelStyle.Angle = -30; // Góc quay của nhãn trên trục x
        }
    }
}
