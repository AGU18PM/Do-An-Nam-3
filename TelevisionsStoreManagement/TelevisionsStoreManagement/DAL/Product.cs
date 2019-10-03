using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisionsStoreManagement.DAL
{
    class Product
    {
        private static Product instance;
        public static Product Instance
        {
            get { if (instance == null) instance = new Product(); return Product.instance; }
            private set { Product.instance = value; }
        }

        Category category;
        int ProductId;
        string ProductName;
        double Price;
        string picture;

        public Product()
        {
            Category = new Category();
            ProductId1 = 0;
            ProductName1 = "";
            Price1 = 0;
              Picture = "";
        }

        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public double Price1 { get => Price; set => Price = value; }
         public string Picture { get => picture; set => picture = value; }
        public Category Category { get => category; set => category = value; }
    }
}
