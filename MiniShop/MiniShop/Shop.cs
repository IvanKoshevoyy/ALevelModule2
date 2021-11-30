using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class ExampleProd
    {
        static public Product product1 = new Product("Milk", 30, 30, 1);
        static public Product product2 = new Product("Bread", 20, 50, 0.8);
        static public Product product3 = new Product("Eggs", 39.5, 28, 0.7);
        static public Product product4 = new Product("Cookies", 60, 21, 0.5);
        static public Product product5 = new Product("Water", 18.8, 190, 1.5);
        static public Product product6 = new Product("Pasta", 30, 96, 0.3);
        static public Product product7 = new Product("Tea", 100, 12, 0.1);
        public List<Product> Products = new List<Product>() { product1, product2, product3, product4, product5, product6, product7 };
    }
    class Shop
    {
        public Warehouse warehouse { get; set; }
        public Cart cart { get; }
        public bill bill { get; }
        public Shop()
        {
            warehouse = new Warehouse();
            cart = new Cart();
            bill = new bill();
        }        
    }
}
