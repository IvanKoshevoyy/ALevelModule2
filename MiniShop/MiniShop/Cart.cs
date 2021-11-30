using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Cart
    {
        public List<Product> Goods { get; set; }
        public Cart()
        {
            Goods = new List<Product>();
        }
        public void AddProductToCart(Product name, int Amount)
        {
            name.Amount = Amount;
            Goods.Add(name);
        }
        public void RemouveproductFromCart(Product name)
        {
             Goods.Remove(name);
        }
        public void ChangeAmountProductInCart(Product name, int Amount)
        {
            name.Amount = Amount;
            foreach (Product prod in Goods)
            {
                if (prod.Name == name.Name && prod.Price == name.Price && prod.Volume == name.Volume)
                {
                    Goods.Remove(name);
                    Goods.Add(name);
                    break;
                }
            }
        }
      
        public int GetAmountProd()
        {
            return Goods.Count();
        }
    }
}
