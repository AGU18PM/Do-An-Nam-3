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
        Category category;
        int ProductId;
        string ProductName;
        double Price;
        string picture;
        Panel ProductPanel;

        public Product()
        {
            Category = new Category();
            ProductId1 = 0;
            ProductName1 = "";
            Price1 = 0;
            Picture = "";
            ProductPanel1 = new Panel();
        }

        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public double Price1 { get => Price; set => Price = value; }
        public string Picture { get => picture; set => picture = value; }
        internal Category Category { get => category; set => category = value; }
        public Panel ProductPanel1 { get => ProductPanel; set => ProductPanel = value; }

        public void setWidthHeight(int a, int b)
        {
            ProductPanel1.Width = a;
            ProductPanel1.Height = b;
        }

        public void setLocation(int x, int y)
        {
            ProductPanel1.Location = new Point(x, y);
        }

        public int getWidth()
        {
            return (ProductPanel1.Width);
        }

        public int getHeight()
        {
            return (ProductPanel1.Height);
        }

        public Point getLocation()
        {
            return ProductPanel1.Location;
        }

        public Panel add()
        {
            ProductPanel1.Width = 150;
            ProductPanel1.Height = 200;
            //  PProduct.BackColor = Color.FromName("HotTrack");
            PictureBox picture = new PictureBox();
            picture.Width = 100;
            picture.Height = 100;
            picture.Location = new Point(25, 25);
            picture.Image = Image.FromFile(@"C:\Users\Num\Desktop\1.jpg");
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Label name = new Label();
            name.Text = ProductName;
            name.Location = new Point(40, 130);
            ProductPanel1.Controls.Add(picture);
            ProductPanel1.Controls.Add(name);
            return ProductPanel1;
        }
    }
}
