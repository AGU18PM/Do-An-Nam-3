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
            

           
            //Hide();
            //fMain main = new fMain();
            //main.ShowDialog();

        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
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
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!");
                txbPassword.Clear();
                txbUsername.Clear();
                txbUsername.Focus();
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = false;
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txbUsername.TabIndex = 1;
            txbPassword.TabIndex = 2;
            btnLogin.Enabled = false;
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if (txbUsername.Text == "" || txbUsername.Text == "Username" || txbPassword.Text == "" || txbPassword.Text == "Password")
            {
                btnLogin.Enabled = false;
            }
            else
                btnLogin.Enabled = true;
        }

        private void txbUsername_Enter(object sender, EventArgs e)
        {
            if (txbUsername.Text.Equals(@"Username"))
            {
                txbUsername.Clear();

            }
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text.Equals(@""))
            {
                txbUsername.Text = "Username";
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text.Equals(@"Password"))
            {
                txbPassword.Clear();
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text.Equals(""))
            {
                txbPassword.Text = "Password";
            }
        }
    }
}
