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
        Products listproduct;
        int SSMode, LGMode, SonyMode, PMode;
        public ProductCtr()
        {
            InitializeComponent();
            listproduct = new Products();
            listproduct.load_Data();
            firstShowData();
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

        void firstShowData()
        {

            ColumnHeader CategoryHeader = new ColumnHeader();
            CategoryHeader.Text = "Hãng";
            CategoryHeader.Width = 75;

            ColumnHeader IDProductHeader = new ColumnHeader();
            IDProductHeader.Text = "ID";
            IDProductHeader.Width = 75;

            ColumnHeader NameProductHeader = new ColumnHeader();
            NameProductHeader.Text = "Tên";
            NameProductHeader.Width = 150;



            ColumnHeader PriceProductHeader = new ColumnHeader();
            PriceProductHeader.Text = "Giá";
            PriceProductHeader.Width = 100;
            ProductListview.Columns.Add(CategoryHeader);
            ProductListview.Columns.Add(IDProductHeader);
            ProductListview.Columns.Add(NameProductHeader);
            ProductListview.Columns.Add(PriceProductHeader);
            ListViewItem[] ListItem = new ListViewItem[listproduct.Count];
            for(int i = 0; i < listproduct.Count; i++)
            {
                ListItem[i] = new ListViewItem();
                ListItem[i].Text = listproduct.List[i].Category.Name1;
                ListItem[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductId1.ToString() });
                ListItem[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
                ListItem[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
                ProductListview.Items.Add(ListItem[i]);
            }
            ProductListview.View = View.Details;
        }
        void showData()
        {
            if (btnSamsung.Checked)
                SSMode = 1;
            else
                SSMode = 0;
            if (btnSony.Checked)
                SonyMode = 1;
            else
                SonyMode = 0;
            if (btnLG.Checked)
                LGMode = 1;
            else
                LGMode = 0;
            //Products.Instance.load_Data();
            ColumnHeader CategoryHeader = new ColumnHeader();
            CategoryHeader.Text = "Hãng";
            CategoryHeader.Width = 75;
            
            ColumnHeader IDProductHeader = new ColumnHeader();
            IDProductHeader.Text = "ID";
            IDProductHeader.Width = 75;

            ColumnHeader NameProductHeader = new ColumnHeader();
            NameProductHeader.Text = "Tên";
            NameProductHeader.Width = 150;
            


            ColumnHeader PriceProductHeader = new ColumnHeader();
            PriceProductHeader.Text = "Giá";
            PriceProductHeader.Width = 100;
            ProductListview.Columns.Add(CategoryHeader);
            ProductListview.Columns.Add(IDProductHeader);
            ProductListview.Columns.Add(NameProductHeader);
            ProductListview.Columns.Add(PriceProductHeader);
            ListViewItem[] ListItem = new ListViewItem[listproduct.Count];
            int j = 0;
            for(int i = 0; i < listproduct.Count; i++)
            {
                ListItem[i] = new ListViewItem();
                if (SSMode == 1)
                {
                    if (listproduct.List[i].Category.Name1 == "samsung")
                    {
                        ListItem[j].Text = listproduct.List[i].Category.Name1;
                        ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductId1.ToString() });
                        ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
                        ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
                        ProductListview.Items.Add(ListItem[j]);
                        j++;
                    }
                }

                if (SonyMode == 1)
                {
                    if(listproduct.List[i].Category.Name1 == "Sony")
                    {
                        ListItem[j].Text = listproduct.List[i].Category.Name1;
                        ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductId1.ToString() });
                        ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
                        ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
                        ProductListview.Items.Add(ListItem[j]);
                        j++;
                    }
                }

                if (LGMode == 1)
                {
                    if (listproduct.List[i].Category.Name1 == "LG") ;
                    ListItem[j].Text = listproduct.List[i].Category.Name1;
                    ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductId1.ToString() });
                    ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
                    ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
                    ProductListview.Items.Add(ListItem[j]);
                    j++;
                }
            }
            ProductListview.View = View.Details;
        }

        private void control()
        {
            
        }

        private void CbPriceDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceDown.Checked)
                cbPriceUp.Checked = false;
        }

        private void btnSony_CheckedChanged(object sender, EventArgs e)
        {
            ProductListview.Clear();
            showData();
        }

        private void CbPriceUp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceUp.Checked)
                cbPriceDown.Checked = false;
        }

        private void btnSamsung_CheckedChanged(object sender, EventArgs e)
        {
            ProductListview.Clear();
            showData();
        }
        private void ProductListview_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
