using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class AccountDAL
    {
        public DataTable getAccountByUserNameNPassword(AccountDTO account)
        {
            string sql = "USP_Login @Username , @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new object[] { account.Username, account.Password });
            return result;
        }

        public void AddAccount(AccountDTO account)
        {
            string sql = "INSERT INTO ACCOUNT(USERNAME, PASSWORD, DISPLAYNAME, ROLE, IMG) VALUES('" + account.Username + "' , '" + account.Password + "' , N'" + account.Displayname + "' , 1 , '" + account.Img + "' )";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void DeleteAccount(AccountDTO account)
        {
            string sql = "DELETE FROM ACCOUNT WHERE USERNAME = '" + account.Username + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void EditAccount(AccountDTO account)
        {
            string sql = "UPDATE ACCOUNT SET PASSWORD = '" + account.Password + "' WHERE USERNAME = '" + account.Username + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public AccountDTO getAccountInfo(AccountDTO account)
        {
            string sql = "SELECT * FROM ACCOUNT WHERE USERNAME = " + account.Username;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            account.Displayname = result.Rows[0][2].ToString();
            account.Role = Convert.ToInt32(result.Rows[0][3]);
            return account;
        }

        public DataTable ShowAccount()
        {
            string sql = "SELECT USERNAME FROM ACCOUNT";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public bool CheckAccount(AccountDTO account)
        {
            string sql = "SELECT * FROM ACCOUNT WHERE USERNAME = '" + account.Username + "'";
            if (DataProvider.Instance.ExecuteQuery(sql).Rows.Count == 0)
                return true;
            return false;
        }
    }
}
