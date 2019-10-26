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
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.UC
{
    public partial class WareHouseCtr : UserControl
    {
        WareHouseBUS wareHouseBUS = new WareHouseBUS();
        ProductBUS productBUS = new ProductBUS();
        ProductDTO productDTO = new ProductDTO();
        int toDo = 0; //1: Them moi 2: chinh sua 3: Xoa
        public WareHouseCtr()
        {
            InitializeComponent();
            dGVWareHouse.AutoGenerateColumns = false;
            productBUS.loadDataToDGV(dGVWareHouse, txbID, cboCategory, txbName, cboType, txbSize, nUDCount, txbPriceOut, txbPriceIn);
        }

        private void WareHouseCtr_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Add("Samsung");
            cboCategory.Items.Add("Panasonic");
            cboCategory.Items.Add("Sony");
            cboCategory.Items.Add("LG");

            cboType.Items.Add("Smart");
            cboType.Items.Add("Internet");
            cboType.Items.Add("Cong");
            cboType.Items.Add("Thường");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toDo = 1;
            DataMode(1, true);
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void DataMode(int mode, bool value)
        {
            if (mode == 1)
            {
                txbName.Clear();
                txbID.Text = "ID tự sinh dữ liệu";
                txbPriceIn.Clear();
                txbPriceOut.Clear();
                txbSize.Clear();
            }
            if(mode == 2)
            {
                txbSize.Clear();
            }
            
            txbName.Enabled = value;
            txbPriceIn.Enabled = value;
            txbPriceOut.Enabled = value;
            txbSize.Enabled = value;
            btnSave.Enabled = value;
            btnCancel.Enabled = value;
            btnAdd.Enabled = !value;
            btnUpdate.Enabled = !value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())
            {
                
                productDTO.Category = cboCategory.Text;
                productDTO.ProductName = txbName.Text;
                if (cboType.Text == "Smart")
                    productDTO.Type = 1;
                else if (cboType.Text == "Internet")
                    productDTO.Type = 2;
                else if (cboType.Text == "Cong")
                    productDTO.Type = 3;
                else
                    productDTO.Type = 4;

                productDTO.Size = Convert.ToInt32(txbSize.Text);
                productDTO.PriceIn = Convert.ToDouble(txbPriceIn.Text);
                productDTO.PriceOut = Convert.ToDouble(txbPriceOut.Text);
                if (productDTO.PriceIn <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá nhập sản phẩm lớn hơn 0");
                    return;
                }
                if (productDTO.PriceIn > productDTO.PriceOut)
                {
                    MessageBox.Show("Vui lòng nhập giá bán lớn hơn giá nhập");
                    return;
                }

                productDTO.Count = Convert.ToInt32(nUDCount.Value);

                if (toDo == 1)
                {
                    if (productBUS.AddProduct(productDTO))
                    {
                        MessageBox.Show("Nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhập không thành công vui lòng kiểm tra lại dữ liệu");
                    }
                }
                else if (toDo == 2)
                {
                    productDTO.Count = Convert.ToInt32(nUDUpdate.Value);
                    productDTO.ProductId = Convert.ToInt32(txbID.Text);
                    productBUS.UpdateProduct(productDTO);
                    MessageBox.Show("Cập nhật thành công");
                }
                toDo = 0;
            }
            else
            {
                DataMode(0, false);
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            productBUS.loadDataToDGV(dGVWareHouse, txbID, cboCategory, txbName, cboType, txbSize, nUDCount, txbPriceOut, txbPriceIn);
        }

        public bool CheckBeforeSave()
        {
            if (txbName.Text.Trim() == "" || txbPriceIn.Text.Trim() == "" || txbPriceOut.Text.Trim() == "")
            {
                MessageBox.Show("Nhập dữ liệu trước khi lưu");
                return false;
            }
            if (txbSize.Text == "" || nUDCount.Value == 0)
            {
                MessageBox.Show("Nhập dữ liệu đầy đủ trước khi lưu");
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            nUDCount.Visible = false;
            nUDUpdate.Visible = true;
            nUDCount.Value = 1;
            nUDUpdate.Value = nUDCount.Maximum;
            toDo = 2;
            DataMode(2, true);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataMode(0, false);
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dGVWareHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataMode(0, false);
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            toDo = 3;
            if(MessageBox.Show("Nếu bạn xóa sản phẩm này, những hóa đơn liên qua sẽ bị xóa, bạn có chắc muốn xóa? " + txbName.Text + " không?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                productDTO.ProductId = Convert.ToInt32(txbID.Text);
                productBUS.DeleteProduct(productDTO);
                productBUS.loadDataToDGV(dGVWareHouse, txbID, cboCategory, txbName, cboType, txbSize, nUDCount, txbPriceOut, txbPriceIn);
                MessageBox.Show("Xóa thành công");
            }
        }
    }
}
