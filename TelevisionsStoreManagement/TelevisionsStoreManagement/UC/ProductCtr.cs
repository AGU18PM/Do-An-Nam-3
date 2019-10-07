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
        //Products listproduct;
        int SSMode, LGMode, SonyMode, PMode;
        public ProductCtr()
        {
            InitializeComponent();
           // listproduct = new Products();
          //  listproduct.load_Data();
            firstShowData();
        }


        //Load đầy đủ data
        void firstShowData()
        {

            //ColumnHeader IDProductHeader = new ColumnHeader();
            //IDProductHeader.Text = "ID";
            //IDProductHeader.Width = 100;


            //ColumnHeader CategoryHeader = new ColumnHeader();
            //CategoryHeader.Text = "Hãng";
            //CategoryHeader.Width = 100;

            //ColumnHeader NameProductHeader = new ColumnHeader();
            //NameProductHeader.Text = "Tên";
            //NameProductHeader.Width = 381;



            //ColumnHeader PriceProductHeader = new ColumnHeader();
            //PriceProductHeader.Text = "Giá";
            //PriceProductHeader.Width = 100;
            //ProductListview.Columns.Add(IDProductHeader);
            //ProductListview.Columns.Add(CategoryHeader);
            //ProductListview.Columns.Add(NameProductHeader);
            //ProductListview.Columns.Add(PriceProductHeader);
            //ListViewItem[] ListItem = new ListViewItem[listproduct.Count];
            //for (int i = 0; i < listproduct.Count; i++)
            //{
            //    ListItem[i] = new ListViewItem();
            //    ListItem[i].Text = listproduct.List[i].ProductId1.ToString();
            //    ListItem[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Category.Name1 });
            //    ListItem[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
            //    ListItem[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
            //    ProductListview.Items.Add(ListItem[i]);
            //}
            //ProductListview.View = View.Details;
        }
        void showData()
        {
            //if (btnSamsung.Checked)
            //    SSMode = 1;
            //else
            //    SSMode = 0;
            //if (btnSony.Checked)
            //    SonyMode = 1;
            //else
            //    SonyMode = 0;
            //if (btnLG.Checked)
            //    LGMode = 1;
            //else
            //    LGMode = 0;
            //if (btnPanasonic.Checked)
            //    PMode = 1;
            //else
            //    PMode = 0;

            //ColumnHeader IDProductHeader = new ColumnHeader();
            //IDProductHeader.Text = "ID";
            //IDProductHeader.Width = 100;

            ////Products.Instance.load_Data();
            //ColumnHeader CategoryHeader = new ColumnHeader();
            //CategoryHeader.Text = "Hãng";
            //CategoryHeader.Width = 100;

            //ColumnHeader NameProductHeader = new ColumnHeader();
            //NameProductHeader.Text = "Tên";
            //NameProductHeader.Width = 281;



            //ColumnHeader PriceProductHeader = new ColumnHeader();
            //PriceProductHeader.Text = "Giá";
            //PriceProductHeader.Width = 200;
            //ProductListview.Columns.Add(IDProductHeader);
            //ProductListview.Columns.Add(CategoryHeader);
            //ProductListview.Columns.Add(NameProductHeader);
            //ProductListview.Columns.Add(PriceProductHeader);
            //ListViewItem[] ListItem = new ListViewItem[listproduct.Count];
            //int j = 0;
            //for (int i = 0; i < listproduct.Count; i++)
            //{
            //    ListItem[i] = new ListViewItem();
            //    if (SSMode == 1)
            //    {
            //        if (listproduct.List[i].Category.Name1 == "samsung")
            //        {
            //            ListItem[j].Text = listproduct.List[i].ProductId1.ToString();
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Category.Name1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
            //            ProductListview.Items.Add(ListItem[j]);
            //            j++;
            //        }
            //    }

            //    if (SonyMode == 1)
            //    {
            //        if (listproduct.List[i].Category.Name1 == "Sony")
            //        {
            //            ListItem[j].Text = listproduct.List[i].ProductId1.ToString();
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Category.Name1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
            //            ProductListview.Items.Add(ListItem[j]);
            //            j++;
            //        }
            //    }

            //    if (LGMode == 1)
            //    {
            //        if (listproduct.List[i].Category.Name1 == "LG")
            //        {
            //            ListItem[j].Text = listproduct.List[i].ProductId1.ToString();
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Category.Name1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
            //            ProductListview.Items.Add(ListItem[j]);
            //            j++;
            //        }
            //    }
            //    if (PMode == 1)
            //        if (listproduct.List[i].Category.Name1 == "Panasonic")
            //        {
            //            ListItem[j].Text = listproduct.List[i].ProductId1.ToString();
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Category.Name1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].ProductName1 });
            //            ListItem[j].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listproduct.List[i].Price1.ToString() });
            //            ProductListview.Items.Add(ListItem[j]);
            //            j++;
            //        }
            //}

            //if (SSMode == 0 && SonyMode == 0 && LGMode == 0 && PMode == 0)
            //{
            //    firstShowData();
            //}
            //ProductListview.View = View.Details;
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

        private void btnLG_CheckedChanged(object sender, EventArgs e)
        {
            ProductListview.Clear();
            showData();
        }

        private void btnPanasonic_CheckedChanged(object sender, EventArgs e)
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
