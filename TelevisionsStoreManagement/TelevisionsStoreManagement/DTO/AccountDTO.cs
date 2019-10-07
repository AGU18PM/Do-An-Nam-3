using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DAL;

namespace TelevisionsStoreManagement.DTO
{
    class AccountDTO
    {
        string username;
        string displayname;
        string password;
        int role;
        public AccountDTO()
        {
            username = "";
            Displayname = "";
            Password = ""; 
            Role = 0;
        }
        //public bool login(string Username, string Password)
        //{
        //    string query = "USP_Login @Username , @Password";
        //    DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Username, Password });
        //    if (result.Rows.Count > 0)
        //    {
        //        Displayname = result.Rows[0][0].ToString();
        //        Role = Convert.ToInt32(result.Rows[0][3]);
        //    }

        //    return result.Rows.Count > 0;
        //}

        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
    }
}
