using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.DAL;

namespace TelevisionsStoreManagement
{
    public partial class fLoading : Form
    {
        public fLoading()
        {
            InitializeComponent();
            Hide();
            fLogin login = new fLogin();
            login.ShowDialog();
            //CategoryList.Instance.loadCategoryList();
           // Products.Instance.load_Data();
        }
    }
}