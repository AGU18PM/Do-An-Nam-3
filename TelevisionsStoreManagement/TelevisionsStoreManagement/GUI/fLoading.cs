using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.UC;

namespace TelevisionsStoreManagement.GUI
{
    public partial class fLoading : Form
    {
        public fLoading()
        {
            InitializeComponent();
        }

        WareHouseCtr wareHouseCtr;
        ProductCtr productCtr;
        RevenCtr revenCtr;

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            try
            {
                panelLoading.Width += 48;
                if (panelLoading.Width == 48)
                {
                    timerLoading.Stop();
                    System.Threading.Thread.Sleep(2000);
                    label4.Text = "Loading Reven...";
                    revenCtr = new RevenCtr();
                    timerLoading.Start();
                }
                if (panelLoading.Width == 144)
                {
                    timerLoading.Stop();
                    System.Threading.Thread.Sleep(3500);
                    label4.Text = "Loading Product...";
                    productCtr = new ProductCtr();
                    timerLoading.Start();
                }
                if (panelLoading.Width == 336)
                {
                    timerLoading.Stop();
                    System.Threading.Thread.Sleep(1000);
                    label4.Text = "Loading Customer...";
                    wareHouseCtr = new WareHouseCtr();
                    timerLoading.Start();
                }

                if (panelLoading.Width >= 368)
                {
                    timerLoading.Stop();
                    
                    
                    fLogin f = new fLogin();
                    this.Hide();
                    f.Show();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
