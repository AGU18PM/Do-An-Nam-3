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
            //Button a = new Button()
            //{
            //    Location = new Point(20, 40)
            //};

            //Button b = new Button()
            //{
            //    Location = new Point(80, 100)
            //};

            //panelProduct.Controls.Add(a);
            //panelProduct.Controls.Add(b);
        }

        void showData()
        {
            Product oldproduct = new Product();
            oldproduct.setLocation(0, 0);
            oldproduct.setWidthHeight(0, 0);
            for (int i = 0; i < Products.Instance.Count; i++)
            {
                Point tg = oldproduct.getLocation();

                //listProduct.List[i].setLocation(tg.X, tg.Y);
                //panelProduct.Controls.Add(listProduct.List[i].add());
                //oldproduct = listProduct.List[i];
                //oldproduct.setLocation(tg.X + 10, tg.Y + 10);
                listProduct.List[i].ProductPanel1 = new Panel()
                {
                    Location = new Point(tg.X + oldproduct.getWidth(), tg.Y)
                };
                oldproduct = listProduct.List[i];
                panelProduct.Controls.Add(listProduct.List[i].add());
            }
        }

        private void control()
        {
            
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
