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
    public partial class WareHouseCtr : UserControl
    {
        WareHouseBUS wareHouseBUS = new WareHouseBUS();
        ProductBUS productBUS = new ProductBUS();
        public WareHouseCtr()
        {
            InitializeComponent();
            dGVWareHouse.AutoGenerateColumns = false;
            productBUS.loadDataToDGV(dGVWareHouse, txbID, cboCategory, txbName, cboType, nUDSize, nUDCount, txbPriceOut, txbPriceIn);
        }

        private void WareHouseCtr_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
