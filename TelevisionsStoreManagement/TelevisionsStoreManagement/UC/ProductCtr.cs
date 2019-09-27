using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.DAL;

namespace TelevisionsStoreManagement.UC
{
    public partial class ProductCtr : UserControl
    {
        Products listProduct;
        public ProductCtr()
        {
            InitializeComponent();
            listProduct = new Products();
            listProduct.load_Data();
            showData();
        }

        void showData()
        {
            Product oldproduct = new Product();
            oldproduct.setLocation(0, 0);
            oldproduct.setWidthHeight(0, 0); 
            for (int i = 0; i< Products.Instance.Count; i++)
            {
                Point tg = oldproduct.getLocation();

                Products.Instance.List[i].setLocation(tg.X, tg.Y);
                panelProduct.Controls.Add(Products.Instance.List[i].add());
                oldproduct = Products.Instance.List[i];
            }
        }

        private void CbPriceDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceDown.Checked)
                cbPriceUp.Checked = false;
        }

        private void CbPriceUp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceUp.Checked)
                cbPriceDown.Checked = false;
        }
    }
}
