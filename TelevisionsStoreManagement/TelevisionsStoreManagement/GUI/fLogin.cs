using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.GUI;

namespace TelevisionsStoreManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            lbError.Hide();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Account.Instance.login(txbUsername.Text, txbPassword.Text))
            {
                Hide();
                fLoading f = new fLoading();
                f.ShowDialog();
            }
            else
                lbError.Show();
        }
    }
}
