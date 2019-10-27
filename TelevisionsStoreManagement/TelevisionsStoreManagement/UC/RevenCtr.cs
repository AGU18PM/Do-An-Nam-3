using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.BUS;
using TelevisionsStoreManagement.GUI;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.UC
{
    public partial class RevenCtr : UserControl
    {
        DoanhThuBUS doanhThuBUS = new DoanhThuBUS();
        DoanhThu doanhThu = new DoanhThu();
        BillBUS billBUS = new BillBUS();
        public RevenCtr()
        {
            InitializeComponent();
            dGVHistory.AutoGenerateColumns = false;
            billBUS.ShowHistory(dGVHistory, Label);
        }

        private void dGVHistory_DoubleClick(object sender, EventArgs e)
        {
            fBillInfo f = new fBillInfo(Label.Text);
            f.ShowDialog();
        }

        void loadingChart()
        {
            
        }

        private void RevenCtr_Load(object sender, EventArgs e)
        {
            doanhThuBUS.ShowDoanhThu(chart1, doanhThu);
        }
    }
}
