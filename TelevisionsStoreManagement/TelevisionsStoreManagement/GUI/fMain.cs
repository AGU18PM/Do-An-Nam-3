using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TelevisionsStoreManagement.UC;

namespace TelevisionsStoreManagement.GUI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            Color_Button();
            mode = 0;     
        }

        int mode;
        string startupURL = Application.StartupPath;
        private void Color_Button()
        {
            //
            TriangleCorner1.Show();
            TriangleCorner2.Hide();
            TriangleCorner3.Hide();
            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorMain.Show();
            PanelColorProduct.Hide();
            PanelColorPayment.Hide();
            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            btnHome.Image = Image.FromFile(startupURL+"\\Icon\\button_home_blue.png");
            //
            PanelSubMenu.Hide();
        }

        void ChangeMenuMode()
        {
            if (mode == 0)
            {

                PanelMenuSlide.Location = new Point(0, 397);
                PanelSubMenu.Show();
                mode = 1;
            }
            else
            {
                PanelMenuSlide.Location = new Point(0, 278);
                PanelSubMenu.Hide();
                mode = 0;
            }
        }

        void closeSubMenu()
        {
            PanelMenuSlide.Location = new Point(0, 278);
            PanelSubMenu.Hide();
            mode = 0;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            TriangleCorner1.Show();
            TriangleCorner2.Hide();
            TriangleCorner3.Hide();
            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorMain.Show();
            PanelColorProduct.Hide();
            PanelColorPayment.Hide();
            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\button_home_blue.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

            closeSubMenu();

            

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            TriangleCorner1.Hide();
            TriangleCorner2.Show();
            TriangleCorner3.Hide();
            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorProduct.Show();
            PanelColorMain.Hide();            
            PanelColorPayment.Hide();
            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL+"\\Icon\\menu-icon-blue.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

            //
            ChangeMenuMode();
                


            

        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();
            TriangleCorner3.Show();
            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorPayment.Show();
            PanelColorMain.Hide();
            PanelColorProduct.Hide();            
            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon-blue.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.DimGray;            
            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();
            TriangleCorner3.Hide();
            TriangleCorner4.Show();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorDepot.Show();
            PanelColorMain.Hide();
            PanelColorProduct.Hide();
            PanelColorPayment.Hide();            
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-blue.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.DimGray;            
            btnWareHouse.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);
        }

        private void btnReven_Click(object sender, EventArgs e)
        {
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();
            TriangleCorner3.Hide();
            TriangleCorner4.Hide();
            TriangleCorner5.Show();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorRevenue.Show();
            PanelColorMain.Hide();
            PanelColorProduct.Hide();
            PanelColorPayment.Hide();
            PanelColorDepot.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-blue .png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();
            TriangleCorner3.Hide();
            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Show();
            TriangleCorner7.Hide();
            //
            PanelColorProduct.Hide();
            PanelColorMain.Hide();
            PanelColorPayment.Hide();
            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Show();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-blue.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnSetting.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();
            TriangleCorner3.Hide();
            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Show();
            //
            PanelColorProduct.Hide();
            PanelColorMain.Hide();
            PanelColorPayment.Hide();
            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Show();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-blue.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");
            btnPayment.Image = Image.FromFile(startupURL + "\\Icon\\pay-icon.png");
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnPayment.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (PanelForm.Location.X == 1019 && PanelForm.Location.Y == 0 )
            {
                PanelForm.Location = new Point(840, 0);
                Size = new Size(1191, 578);
                Location = new Point(93, 66);

               // MainPanel.Size = new Size(137, 65);
            }
            else if (PanelForm.Location.X == 840 && PanelForm.Location.Y == 0)
            {
                PanelForm.Location = new Point(1019, 0);
                Size = new Size(1370, 730);
                Location = new Point(0, 0);
              //  MainPanel.Size = new Size(1056, 504);
            }



        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
