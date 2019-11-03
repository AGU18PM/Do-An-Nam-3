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
        CustomerBUS customerBus = new CustomerBUS();
        BILLInfoBUS billInfoBus = new BILLInfoBUS();
        DoanhThu doanhThu = new DoanhThu();
        BillBUS billBUS = new BillBUS();
        public HomePageCtr()
        {
            InitializeComponent();

        }

        private void HomePageCtr_Load(object sender, EventArgs e)
        {            
            doanhThuBUS.GetDoanhThuForHomePage(labelRevenue);
            billInfoBus.TotalSold(labelSold);
            billInfoBus.SoldInDay(labelSoldin1Month);
            customerBus.CountCustomer(labelCustomers);

            if (labelSold.Text == "")
                labelSold.Text = "0";

            if (labelSoldin1Month.Text == "")
                labelSoldin1Month.Text = "0";

            if (labelRevenue.Text == "")
                labelRevenue.Text = "0";
            labelRevenue.Text += " VND";
        }
    }
}
