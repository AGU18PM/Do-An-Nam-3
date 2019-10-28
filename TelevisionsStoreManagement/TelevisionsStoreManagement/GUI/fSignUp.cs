using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.BUS;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.GUI
{
    public partial class fSignUp : Form
    {
        string imgURL = "";
        AccountDTO accountDTO = new AccountDTO();
        AccountBUS accountBUS = new AccountBUS();
        public fSignUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            accountDTO.Displayname = txbDisplayName.Text;
            accountDTO.Username = txbUsername.Text;
            accountDTO.Password = txbPW.Text;
            if (txbDisplayName.Text.Trim() == "" || txbUsername.Text.Trim() == "" || txbPW.Text.Trim() == "" || txbPW2.Text.Trim() == ""|| txbDisplayName.Text== "Nhập tên hiển thị"|| txbUsername.Text == "Tên đăng nhập"||txbPW.Text == "Mật khẩu"|| txbPW.Text== "Nhập lại mật khẩu")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                if (accountBUS.CheckAccount(accountDTO))
                {
                    if (cbAdmin.Checked)
                        accountDTO.Role = 1;
                    else
                        accountDTO.Role = 2;
                    if (imgURL == "")
                        accountDTO.Img = "\\IMG\\ACCOUNT\\user-icon-grey.png";
                    else
                    {
                        string bede = accountDTO.Username + ".jpg";
                        File.Copy(imgURL, Application.StartupPath + "\\IMG\\ACCOUNT\\" + bede);
                        accountDTO.Img = "\\IMG\\ACCOUNT\\" + bede;
                    }

                    accountBUS.AddAccount(accountDTO);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Tài khoản đã tồn tại");
            }
        }
        private void btnPickPicture_Click(object sender, EventArgs e)
        {
            accountDTO.Username = txbUsername.Text;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgURL = open.FileName;
                //if (open.CheckFileExists)
                //    File.Copy(open.FileName, Application.StartupPath + "\\IMG\\ACCOUNT\\tam.jpg");
            }
            btnPickPicture.Image = Image.FromFile(open.FileName);

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txbDisplayName_Enter(object sender, EventArgs e)
        {
            
            
                txbDisplayName.Clear();

            
        }

        private void txbUsername_Enter(object sender, EventArgs e)
        {
            txbUsername.Clear();
        }

        private void txbPW_Enter(object sender, EventArgs e)
        {
            txbPW.Clear();
        }

        private void txbPW2_Enter(object sender, EventArgs e)
        {
            txbPW2.Clear()
;        }
    }
}
