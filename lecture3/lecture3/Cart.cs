using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Cart
    {
        public List<Vegetable> vegetables { get; set; }
        public Cart()
        {
            vegetables = new List<Vegetable>();
        }
        public void addToCart(Vegetable vegetable)
        {
            vegetables.Add(vegetable);
        }
        public void showVegetablesInCart()
        {
            Console.Write("Vegetables in cart\n");
            foreach (var a in vegetables)
            {
                a.show();
            }
        }
        public void sortVegetable()
        {
            vegetables.Sort();
        }
    }
}
