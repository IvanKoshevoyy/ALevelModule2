using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class bill
    {
        public List<Product> GoodsInBill { get; set; }
        public bill()
        {
            GoodsInBill = new List<Product>();
        }
        public void AddProductToBill(Product name, int Amount)
        {
            name.Amount = Amount;
            GoodsInBill.Add(name);
        }
        public void PrintOrder()
        {
            int i = 1;
            foreach (Product prod in GoodsInBill)
            {
                Console.WriteLine($"Product - {i}");
                Console.WriteLine($"Name: {prod.Name}\nPrice: {prod.Price}\nQuantity: {prod.Amount}\nSize: {prod.Volume}\n");
                i++;
            }
            Console.WriteLine($"Price: {GetPrice()} grn");
        }
        public double GetPrice()
        {
            double Sum = 0;
            foreach (Product prod in GoodsInBill)
            {
                Sum += prod.Price * prod.Amount;

            }
            return Sum;
        }
        public int GetAmountProd()
        {
            return GoodsInBill.Count();
        }
        public void Buy(Cart a)
        {
            GoodsInBill = a.Goods;
            Console.WriteLine("Your order:");
            PrintOrder();
        }
    }
}
