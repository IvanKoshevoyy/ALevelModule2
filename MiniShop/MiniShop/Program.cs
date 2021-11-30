using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleProd exampleProd = new ExampleProd();

            int mode = 0;
           
            Shop newShop = new Shop();
            newShop.warehouse.Products = exampleProd.Products;
            newShop.warehouse.ShowAllProducts();

            AddProd(ref newShop);

            do
            {      
                do
                {
                    Console.WriteLine("1 - add more products\n2 - delete the product\n3 - pay the bill");
                    try
                    {
                        mode = Int32.Parse(Console.ReadLine());
                        if (mode != 1 && mode != 2 && mode != 3)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("wrong input");
                    }
                } while (mode != 1 && mode != 2 && mode != 3);
                if (mode == 1)
                {
                    AddProd(ref newShop);
                   
                }
                else if (mode == 2)
                {
                    newShop.bill.PrintOrder();
                    DeleteProd(ref newShop);
                }
                else
                {
                    newShop.bill.Buy(newShop.cart);
                }
            } while (mode != 3);
           



            Console.ReadLine();
        }

        static void AddProd(ref Shop newShop)
        {
            ExampleProd exampleProd = new ExampleProd();
            int Number = 0;
            int Amount = 0;

            do
            {
                Console.Write("Enter the number of product you want to buy: ");
                try
                {
                    Number = Int32.Parse(Console.ReadLine());
                    if (Number <= 0 || Number >= 8)
                    {
                        Number = 0;
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }
            } while (Number <= 0 || Number >= 8);

            do
            {
                Console.Write("Enter the quantity of product you want to buy: ");
                try
                {
                    Amount = Int32.Parse(Console.ReadLine());
                    if (Amount <= 0 || Amount > exampleProd.Products[Number - 1].Amount)
                    {
                        Amount = 0;
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }
            } while (Amount <= 0);

            for(int i=0; i<7; i++)
            {
                if(i+1 == Number)
                {
                    newShop.cart.AddProductToCart(exampleProd.Products[i], Amount);
                }
            }
            
        }
        static void DeleteProd(ref Shop newShop)
        {
            ExampleProd exampleProd = new ExampleProd();
            int Number = 0;
            int Amount = 0;
            do
            {
                Console.Write("Enter the number of product you want to delete: ");
                try
                {
                    Number = Int32.Parse(Console.ReadLine());
                    if (Number <= 0 || Number > newShop.cart.GetAmountProd())
                    {
                        Number = 0;
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }

            } while (Number <= 0 || Number >= newShop.cart.GetAmountProd());
            do
            {
                Console.Write("Enter the quantity of products you want to delete: ");
                try
                {
                    Amount = Int32.Parse(Console.ReadLine());
                    if (Amount <= 0 || Amount > newShop.cart.Goods[Number - 1].Amount)
                    {
                        Amount = 0;
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }
            } while (Amount <= 0);

            if (Amount == newShop.cart.Goods[Number - 1].Amount)
            {
                newShop.cart.RemouveproductFromCart(newShop.cart.Goods[Number - 1]);
            }
            else
            {
                newShop.cart.ChangeAmountProductInCart(newShop.cart.Goods[Number - 1], newShop.cart.Goods[Number - 1].Amount - Number);
            }
        }
    }
}
