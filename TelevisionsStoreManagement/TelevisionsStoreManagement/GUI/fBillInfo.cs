using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.BUS;

namespace TelevisionsStoreManagement.GUI
{
    public partial class fBillInfo : Form
    {
        BillBUS billBus = new BillBUS();
        public fBillInfo()
        {
            InitializeComponent();

        }

        public fBillInfo(string id)
        {
            InitializeComponent();
            billBus.GetMoreForHistory(dGV, id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
