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
    public partial class fPasswordChange : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        AccountDTO accountDTO = new AccountDTO();
        public fPasswordChange()
        {
            InitializeComponent();
        }

        private void fPasswordChange_Load(object sender, EventArgs e)
        {
            accountBUS.ShowData(cboUserName);
        }

        private void txbPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txbPW.Text == "" || txbPW.Text == "Mật khẩu" || txbPW2.Text != txbPW.Text || cboUserName.Text == "")
            {
                MessageBox.Show("Thông tin chưa hợp lệ");
            }
            else
            {
                accountDTO.Username = cboUserName.Text;
                accountDTO.Password = txbPW.Text;
                accountBUS.EditAccount(accountDTO);
                MessageBox.Show("Đã đổi mật khẩu");
                this.Close();
            }
        }

        private void txbPW_Enter(object sender, EventArgs e)
        {
            txbPW.Clear();
        }

        private void txbPW2_Enter(object sender, EventArgs e)
        {
            txbPW2.Clear();
        }
    }
}
