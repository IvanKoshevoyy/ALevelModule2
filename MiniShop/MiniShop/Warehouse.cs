using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Warehouse
    {
        public List<Product> Products { get; set; }
        public void ShowAllProducts()
        {
            int i = 1;
            foreach (Product prod in Products)
            {
                Console.WriteLine($"Product - {i}");
                Console.WriteLine($"Name: {prod.Name}\nPrice: {prod.Price}\nQuantity: {prod.Amount}\nSizes: {prod.Volume}\n");
                i++;
            }
        }
    }
}
