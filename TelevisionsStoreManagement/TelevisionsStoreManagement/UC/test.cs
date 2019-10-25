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

namespace TelevisionsStoreManagement.UC
{
    public partial class test : UserControl
    {
        ProductBUS productBUS = new ProductBUS();
        public test()
        {
            InitializeComponent();
            //productBUS.loadDataToDGV(dGVWareHouse, txbID, cboCategory, txbName, cboType, nUDSize, nUDCount, txbPriceOut, txbPriceIn);
        }
    }
}
