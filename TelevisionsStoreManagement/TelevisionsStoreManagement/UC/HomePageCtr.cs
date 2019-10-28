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
using TelevisionsStoreManagement.BUS;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.UC
{
    public partial class HomePageCtr : UserControl
    {
        DoanhThuBUS doanhThuBUS = new DoanhThuBUS();
        DoanhThu doanhThu = new DoanhThu();
        public HomePageCtr()
        {
            InitializeComponent();

        }

        private void HomePageCtr_Load(object sender, EventArgs e)
        {
            doanhThuBUS.ShowDoanhThu(chart1, doanhThu);

        }
    }
}
