using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement
{
    class DataProvider
    {
        string connectionStr = @"Data Source=DESKTOP-NQP8BVD;Initial Catalog=QUANLYTIVI;Integrated Security=True";
        
        
        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }                            
            return data;
        }
    }
}
