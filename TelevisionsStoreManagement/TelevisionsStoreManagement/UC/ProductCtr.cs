﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.BUS;
using TelevisionsStoreManagement.DTO;
using TelevisionsStoreManagement.GUI;

namespace TelevisionsStoreManagement.UC
{
    public partial class ProductCtr : UserControl
    {
        //Products listproduct;
        int SSMode, LGMode, SonyMode, PMode;
        ProductBUS productBUS = new ProductBUS();
        BILLInfoBUS billInfoBus = new BILLInfoBUS();
        BillBUS billBUS = new BillBUS();
        BillDTO billDTO = new BillDTO();
        ProductDTO pro = new ProductDTO();
        CustomerDTO customerVL = new CustomerDTO();
        DoanhThu doanhThu = new DoanhThu();
        int isCreateBill = 0;
        string typeInput = "";
        double dthu = 0;

        public ProductCtr()
        {
            InitializeComponent();
            //firstShowData();
            showProduct();
        }

        public void showProduct()
        {
            productBUS.ShowProductData(dGVProduct, txbID, txbCategory, txbName, txbType, txbSize, txbPrice, typeInput, nUDCount);
        }

        public ProductCtr(string type)
        {
            InitializeComponent();
            typeInput = type;
            productBUS.ShowProductData(dGVProduct, txbID, txbCategory, txbName, txbType, txbSize, txbPrice, typeInput, nUDCount);
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




        private void btnSony_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void btnLG_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void btnPanasonic_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void nUDCount_ValueChanged(object sender, EventArgs e)
        {
            //int price = Convert.ToInt32(txbPrice.Text);
            //int totalPrice = price * (Convert.ToInt32(nUDCount.Value));
            //txbTotalPrice.Text = totalPrice.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            #region comment
            //double totalPricee = 0;
            //if (listProduct.Count != 0)
            //{
            //    for (int i = 0; i < listProduct.Count; i++)
            //    {
            //        totalPricee += listProduct.Price[i];
            //    }
            //    MessageBox.Show("Tong tien: " + totalPricee.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Chua co san pham duoc chon");
            //}
            #endregion
            if (lbPayment.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm trước khi thanh toán");
            }
            else
            {
                billDTO.Status = 1;
                if (productBUS.Update(billDTO))
                {
                    if (txbCustomerPhonenumber.Text != "")
                    {
                        billBUS.submitOrCancelPayment(billDTO, txbCustomerPhonenumber.Text, doanhThu);
                        MessageBox.Show("Tổng thành tiền là: " + billDTO.TotalPrice.ToString());
                        lbPayment.Items.Clear();
                        isCreateBill = 0;
                        productBUS.ShowProductData(dGVProduct, txbID, txbCategory, txbName, txbType, txbSize, txbPrice, typeInput, nUDCount);
                    }
                    else
                    {
                        txbCustomerPhonenumber.Text = "1";
                        billDTO.Customer.ID = 3;
                        billBUS.submitOrCancelPayment(billDTO, txbCustomerPhonenumber.Text, doanhThu);
                        MessageBox.Show("Tổng thành tiền là: " + billDTO.TotalPrice.ToString());
                        lbPayment.Items.Clear();
                        isCreateBill = 0;
                        productBUS.ShowProductData(dGVProduct, txbID, txbCategory, txbName, txbType, txbSize, txbPrice, typeInput, nUDCount);
                    }
                    // updateCount();
                }
                else
                {
                    lbPayment.Items.Clear();
                }
            }
            btnPayment.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region comment
            //listProduct.ID[listProduct.Count] = txbID.Text;
            //listProduct.CountByList[listProduct.Count] = Convert.ToInt32(nUDCount.Value);
            //listProduct.Price[listProduct.Count] = Convert.ToDouble(txbPrice.Text) * Convert.ToDouble(nUDCount.Value);
            //listProduct.Count++;
            //payment = "Da them " + txbCategory.Text + " " + txbName.Text + " so luong " + nUDCount.Value.ToString();
            //lbPayment.Items.Add(payment);
            #endregion
            if (nUDCount.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!!!");
            }
            else
            {

                if (isCreateBill == 0)
                {
                    customerVL.ID = 1;
                    billDTO = billBUS.createBill(customerVL);
                    isCreateBill = 1;
                }

                //if (wareHouseBus.CheckCount(txbID.Text, Convert.ToInt32(nUDCount.Value), billDTO))
                //{
                int price = Convert.ToInt32(txbPrice.Text);
                int totalPrice = price * (Convert.ToInt32(nUDCount.Value));
                billInfoBus.createBillInfo(billDTO, txbID.Text, nUDCount, totalPrice.ToString());
                pro.ProductId = Convert.ToInt32(txbID.Text);
                dthu = productBUS.DoanhThu(pro);
                billDTO = billInfoBus.getTotalPriceByIDBill(billDTO);
                string payment = "Bạn đã thêm " + txbName.Text + " hãng " + txbCategory.Text + " số lượng " + nUDCount.Value.ToString() + " tổng tiền = " + totalPrice.ToString();
                lbPayment.Items.Add(payment);
                dthu *= Convert.ToDouble(nUDCount.Value);
                btnCancel.Enabled = true;
                btnPayment.Enabled = true;
                doanhThu.Value += dthu;
                //}
                //else
                //{
                //    MessageBox.Show("So luong san pham con lai khong du");
                //}
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            billDTO.Status = 0;
            billBUS.submitOrCancelPayment(billDTO, txbCustomerPhonenumber.Text, doanhThu);
            lbPayment.Items.Clear();
            isCreateBill = 0;
        }

        private void dGVProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // updateCount();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.ShowDialog();
        }

        private void ProductCtr_Load(object sender, EventArgs e)
        {
            //   updateCount();
        }


        private void btnSamsung_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }


        private void Sort()
        {
            string result = "";
            if (btnSamsung.Checked)
            {
                if (result == "")
                {
                    result += "CATEGORY_NAME = 'Samsung'";
                }
                else
                {
                    result += " OR CATEGORY_NAME = 'Samsung'";
                }
            }
            if (btnSony.Checked)
            {
                if (result == "")
                {
                    result += "CATEGORY_NAME = 'Sony'";
                }
                else
                {
                    result += " OR CATEGORY_NAME = 'Sony'";
                }
            }
            if (btnLG.Checked)
            {
                if (result == "")
                {
                    result += "CATEGORY_NAME = 'LG'";
                }
                else
                {
                    result += " OR CATEGORY_NAME = 'LG'";
                }
            }
            if (btnPanasonic.Checked)
            {
                if (result == "")
                {
                    result += "CATEGORY_NAME = 'Panasonic'";
                }
                else
                {
                    result += " OR CATEGORY_NAME = 'Panasonic'";
                }
            }
            if (result != "")
            {
                dGVProduct.DataSource = "";
                //dGVProduct.Rows.Clear();
                productBUS.ShowProductDataByCategory(dGVProduct, result, txbID, txbCategory, txbName, txbType, txbSize, txbPrice, typeInput, nUDCount);
            }
            else
            {
                dGVProduct.DataSource = "";
                productBUS.ShowProductData(dGVProduct, txbID, txbCategory, txbName, txbType, txbSize, txbPrice, typeInput, nUDCount);
            }
        }

        //public void updateCount()
        //{
        //    nUDCount.Value = nUDCount.Minimum;
        //    DataTable result = wareHouseBus.getCountByIDTV(txbID.Text);
        //    if (result.Rows.Count == 0)
        //    {
        //        nUDCount.Maximum = 0;
        //    }
        //    else
        //        nUDCount.Maximum = Convert.ToInt32(result.Rows[0][0]);
        //}
    }
}
