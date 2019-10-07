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
using TelevisionsStoreManagement.GUI;

namespace TelevisionsStoreManagement
{
    public partial class fLogin : Form
    {
        AccountBUS accountBus = new AccountBUS();
        AccountDTO accountDTO = new AccountDTO();

        public fLogin()
        {
            InitializeComponent();
            lbError.Hide();

           
            //Hide();
            //fMain main = new fMain();
            //main.ShowDialog();

        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            accountDTO.Username = txbUsername.Text;
            accountDTO.Password = txbPassword.Text;
            if (accountBus.Login(accountDTO))
            {
                Hide();
                fMain f = new fMain();
                f.ShowDialog();
            }
            else
                lbError.Show();
        }
    }
}
