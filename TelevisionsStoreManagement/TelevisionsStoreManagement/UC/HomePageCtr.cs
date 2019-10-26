using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TelevisionsStoreManagement.UC
{
    public partial class HomePageCtr : UserControl
    {
        public HomePageCtr()
        {
            InitializeComponent();

        }

        private void HomePageCtr_Load(object sender, EventArgs e)
        {
            
            chartRevenue.Series.Add("Biểu đồ doanh thu");
            chartRevenue.Series["Biểu đồ doanh thu"].ChartType = SeriesChartType.Line;
            chartRevenue.Series[0].IsVisibleInLegend = false;
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(1, 100);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(2, 200);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(3, 300);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(4, 400);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(5, 500);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(6, 600);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(7, 200);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(8, 300);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(9, 500);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(10, 700);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(11, 800);
            chartRevenue.Series["Biểu đồ doanh thu"].Points.AddXY(12, 900);

        }
    }
}
