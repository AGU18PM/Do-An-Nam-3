﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.BUS
{
    class AccountBUS
    {
        AccountDAL data = new AccountDAL();

        public bool Login(AccountDTO account)
        {
            DataTable result = data.getAccountByUserNameNPassword(account);
            if (result.Rows.Count > 0)
            {
                account.Img = Application.StartupPath;
                account.Displayname = result.Rows[0][2].ToString();
                account.Role = Convert.ToInt32(result.Rows[0][3]);
                account.Img += result.Rows[0][4].ToString();
            }
            return result.Rows.Count > 0;
        }

        public void AddAccount(AccountDTO account)
        {
            data.AddAccount(account);
        }

        public void EditAccount(AccountDTO account)
        {
            data.EditAccount(account);
        }

        public void DeleteAccount(AccountDTO account)
        {
            data.DeleteAccount(account);
        }

        public bool CheckAccount(AccountDTO account)
        {
            return data.CheckAccount(account);
        }

        public void ShowData(ComboBox userName)
        {
            userName.Items.Clear();
            for(int i = 0; i< data.ShowAccount().Rows.Count; i++)
            {
                userName.Items.Add(data.ShowAccount().Rows[i][0].ToString());
            }
        }
    }
}
