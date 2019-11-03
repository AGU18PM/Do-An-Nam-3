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
using System.Threading;
using TelevisionsStoreManagement.UC;
using TelevisionsStoreManagement.DTO;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.BUS;

namespace TelevisionsStoreManagement.GUI
{
    public partial class fMain : Form
    {
        ProductBUS productBUS = new ProductBUS();
        int mov;
        int movX;
        int movY;
        ProductCtr productCtr;
        WareHouseCtr wareHouseCtr;
        int flag = 0;
        public fMain()
        {
            InitializeComponent();


        }
        public fMain(string displayName, int role, string img)
        {
            InitializeComponent();
            Color_Button();
            mode = 0;
            txbDisplayName.Text = displayName;
            if (role == 1)
            {
                txbRole.Text = "Administrator";
                btnWareHouse.Enabled = true;
                btnReven.Enabled = true;
                btnRegister.Enabled = true;
                btnChangePassword.Enabled = true;
            }
            else
                txbRole.Text = "Staff";

            picBUser.Image = Image.FromFile(img);
            
        }

        int mode;
        string startupURL = Application.StartupPath;
        private void Color_Button()
        {
            //
            TriangleCorner1.Show();
            TriangleCorner2.Hide();

            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorMain.Show();
            PanelColorProduct.Hide();

            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\button_home_blue.png");
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
            panelMain.Controls.Clear();
            HomePageCtr home = new HomePageCtr();
            panelMain.Controls.Add(home);
            TriangleCorner1.Show();
            TriangleCorner2.Hide();

            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorMain.Show();
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

            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\button_home_blue.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;

            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnHome.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

            closeSubMenu();
            refreshNotificationOnButton();
        }



        private void btnProduct_Click(object sender, EventArgs e)
        {
            TriangleCorner1.Hide();
            TriangleCorner2.Show();

            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorProduct.Show();
            PanelColorMain.Hide();

            PanelColorDepot.Hide();
            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-blue.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");

            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;

            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

            //
            ChangeMenuMode();
            /*panelMain.Controls.Clear();            
            Thread thrGenerating = new Thread(new ThreadStart(doWork));
            thrGenerating.Start();*/
            productCtr = new ProductCtr();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(productCtr);
            refreshNotificationOnButton();
        }


        private void btnDepot_Click(object sender, EventArgs e)
        {
            refreshNotificationOnButton();
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();

            TriangleCorner4.Show();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorDepot.Show();
            PanelColorMain.Hide();
            PanelColorProduct.Hide();

            PanelColorRevenue.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-gray.png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-blue.png");

            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.DimGray;

            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);
            //
            wareHouseCtr = new WareHouseCtr();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(wareHouseCtr);
            //if (flag == 0)
            //{
            //    panelMain.Controls.Clear();
            //    panelMain.Controls.Add(productCtr);
            //}
            //else
            //{

            //}
            //flag = 1;


        }

        private void btnReven_Click(object sender, EventArgs e)
        {
            refreshNotificationOnButton();
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();

            TriangleCorner4.Hide();
            TriangleCorner5.Show();
            TriangleCorner6.Hide();
            TriangleCorner7.Hide();
            //
            PanelColorRevenue.Show();
            PanelColorMain.Hide();
            PanelColorProduct.Hide();

            PanelColorDepot.Hide();
            PanelColorSetting.Hide();
            PanelColorHelp.Hide();
            //
            btnProduct.Image = Image.FromFile(startupURL + "\\Icon\\menu-icon-gray.png");
            btnHelp.Image = Image.FromFile(startupURL + "\\Icon\\help-icon-grey.png");
            btnSetting.Image = Image.FromFile(startupURL + "\\Icon\\setting-icon-gray.png");
            btnReven.Image = Image.FromFile(startupURL + "\\Icon\\revenue-icon-blue .png");
            btnWareHouse.Image = Image.FromFile(startupURL + "\\Icon\\box-icon-gray.png");

            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;
            btnProduct.ForeColor = System.Drawing.Color.DimGray;

            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);
            RevenCtr revenCtr = new RevenCtr();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(revenCtr);
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

            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Show();
            TriangleCorner7.Hide();
            //
            PanelColorProduct.Hide();
            PanelColorMain.Hide();

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

            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;

            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnSetting.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            closeSubMenu();
            TriangleCorner1.Hide();
            TriangleCorner2.Hide();

            TriangleCorner4.Hide();
            TriangleCorner5.Hide();
            TriangleCorner6.Hide();
            TriangleCorner7.Show();
            //
            PanelColorProduct.Hide();
            PanelColorMain.Hide();

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

            btnHome.Image = Image.FromFile(startupURL + "\\Icon\\home-icon1.png");
            //
            btnProduct.ForeColor = System.Drawing.Color.DimGray;
            btnSetting.ForeColor = System.Drawing.Color.DimGray;
            btnReven.ForeColor = System.Drawing.Color.DimGray;
            btnWareHouse.ForeColor = System.Drawing.Color.DimGray;

            btnHome.ForeColor = System.Drawing.Color.DimGray;
            btnHelp.ForeColor = System.Drawing.Color.FromArgb(86, 197, 250);



        }


        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (PanelForm.Location.X == 1019 && PanelForm.Location.Y == 0)
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

        private void fMain_Load(object sender, EventArgs e)
        {            
            HomePageCtr home = new HomePageCtr();
            
            panelMain.Controls.Add(home);
            RefreshNotification();
            refreshNotificationOnButton();
            if (productBUS.CheckAmount(lbNotification))
            {
                notifyIcon1.ShowBalloonTip(2000);
            }
            
        }

        private void btnSmartTV_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ProductCtr productControl = new ProductCtr("1");
            panelMain.Controls.Add(productControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ProductCtr productControl = new ProductCtr("2");
            panelMain.Controls.Add(productControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ProductCtr productControl = new ProductCtr("3");
            panelMain.Controls.Add(productControl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ProductCtr productControl = new ProductCtr("4");
            panelMain.Controls.Add(productControl);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                PanelForm.Location = new Point(840, 0);
                Size = new Size(1191, 578);
            }


        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (PanelUser.Visible == false)
            {
                PanelUser.Visible = true;
            }
            else
                PanelUser.Visible = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin login = new fLogin();
            login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fSignUp signUp = new fSignUp();
            signUp.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            fPasswordChange passwordChange = new fPasswordChange();
            passwordChange.ShowDialog();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            RefreshNotification();
        }

        public void RefreshNotification()
        {
            if (lbNotification.Visible == false)
            {
                lbNotification.Visible = true;
                if (productBUS.CheckAmount(lbNotification))
                {
                    labelNotification.Visible = true;
                    
                }
                else
                    labelNotification.Visible = false;

            }
            else
                lbNotification.Visible = false;
        }

        public void refreshNotificationOnButton()
        {
            if (productBUS.CheckAmount(lbNotification))
            {
                labelNotification.Visible = true;
                
            }
            else
                labelNotification.Visible = false;
        }

        
    }
}
