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
        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
    }
}
