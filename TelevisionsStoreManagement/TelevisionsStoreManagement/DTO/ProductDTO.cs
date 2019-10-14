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
       

        string category;
        int productId;
        string productName;
        int type; //1:Smart 2:Internet 3:Cong 4:Thuong
        int size; //inch
        double priceIn;
        double priceOut;

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        
        public int Type { get => type; set => type = value; }
        public int Size { get => size; set => size = value; }
        public double PriceIn { get => priceIn; set => priceIn = value; }
        public double PriceOut { get => priceOut; set => priceOut = value; }
        public string Category { get => category; set => category = value; }
    }
}
