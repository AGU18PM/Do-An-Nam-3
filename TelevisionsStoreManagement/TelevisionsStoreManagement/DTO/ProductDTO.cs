using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisionsStoreManagement.DTO
{
    class ProductDTO
    {
       

        CategoryDTO category;
        int productId;
        string productName;
        double price;

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        internal CategoryDTO Category { get => category; set => category = value; }
    }
}
