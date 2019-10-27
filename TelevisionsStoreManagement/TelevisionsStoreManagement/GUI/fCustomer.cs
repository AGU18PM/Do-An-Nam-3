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
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.GUI
{
    public partial class fCustomer : Form
    {
        CustomerBUS customer = new CustomerBUS();
        CustomerDTO customerDTO = new CustomerDTO();
        public fCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customerDTO.Name = txbName.Text;
            customerDTO.PhoneNumber = txbSDT.Text;
            if (txbName.Text.Trim() == "" || txbSDT.Text.Trim() == "")
            {
                MessageBox.Show("Nhập dữ liệu đầy đủ");
            }
            else
            {
                if (customer.Addcustomer(customerDTO))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Người dùng đã tồn tại");
                }
            }
            
        }

        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
