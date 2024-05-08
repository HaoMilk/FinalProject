using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject.Admin.GUI.ThongKe
{
    internal class ChartHelper
    {
        public ChartHelper() { }
        public int DemSo(string query, string connectionString)
        {
            int Dem = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    Dem = (int)command.ExecuteScalar();
                }
            }
            return Dem;
        }
        public DataTable LayDuLieu(string query, string connectionString)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public static void ThemDuLieu(Chart chart, DataTable dataTable, string xField, string yField, string xAxisTitle, string yAxisTitle, SeriesChartType chartType, string chartTitle)
        {
            chart.Series.Clear();

            Series series = new Series(yField);
            series.ChartType = chartType;

            foreach (DataRow row in dataTable.Rows)
            {
                string xValue = row[xField].ToString();
                double yValue = Convert.ToDouble(row[yField]);
                series.Points.AddXY(xValue, yValue);
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Title = xAxisTitle;
            chart.ChartAreas[0].AxisY.Title = yAxisTitle;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.Titles.Clear();
            chart.Titles.Add(chartTitle);
        }

    }
}
