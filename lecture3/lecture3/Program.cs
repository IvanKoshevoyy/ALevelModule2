using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string vegetableChoose;
            string sortChoose;
            int amountChoose;

            Cart cart = new Cart();

            do
            {
                Console.Write("\nInput the name of Vegetable you want to add\nTo delete the product type 'delete'\nTo sort the products by amount type 'sort'\nTo show the products in your cart type 'show'\nTo end the program type 'exit' ");
                vegetableChoose = Console.ReadLine();
                switch (vegetableChoose)
                {
                    case "Cucumber":
                        Cucumber cucumber = new Cucumber();
                        cucumber.showAllInfo();
                        Console.WriteLine("Choose the sort of cucumber");
                        sortChoose = Console.ReadLine();
                        try
                        {
                            cucumber.Sort = sortChoose;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong sort");
                        }
                        Console.WriteLine("Choose the amount");
                        amountChoose = Int32.Parse(Console.ReadLine()); 
                        try
                        {
                            cucumber.Amount = amountChoose;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        cart.addToCart(cucumber);
                        break;
                    case "Tomato":
                        Tomato tomato = new Tomato();
                        tomato.showAllInfo();
                        Console.WriteLine("Choose the sort of tomato");
                        sortChoose = Console.ReadLine();
                        try
                        {
                            tomato.Sort = sortChoose;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong sort");
                        }
                        Console.WriteLine("Choose the amount");
                        amountChoose = Int32.Parse(Console.ReadLine());
                        try
                        {
                            tomato.Amount = amountChoose;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        cart.addToCart(tomato);
                        break;

                    case "Potato":
                        Potato potato = new Potato();
                        potato.showAllInfo();
                        Console.WriteLine("Choose the sort of potato");
                        sortChoose = Console.ReadLine();
                        try
                        {
                            potato.Sort = sortChoose;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong sort");
                        }
                        Console.WriteLine("Choose the amount");
                        amountChoose = Int32.Parse(Console.ReadLine());

                        try
                        {
                            potato.Amount = amountChoose;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        cart.addToCart(potato);
                        break;
                    case "Cabbage":
                        Cabbage cabbage = new Cabbage();
                        cabbage.showAllInfo();
                        Console.WriteLine("Choose the sort of cabbage");
                        sortChoose = Console.ReadLine();
                        try
                        {
                            cabbage.Sort = sortChoose;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong sort");
                        }
                        Console.WriteLine("Choose the amount");
                        amountChoose = Int32.Parse(Console.ReadLine());

                        try
                        {
                            cabbage.Amount = amountChoose;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        cart.addToCart(cabbage);
                        break;
                    case "exit":
                        Console.WriteLine("End of the program");
                        break;
                    case "show":
                        cart.showVegetablesInCart();
                        break;
                    case "sort":
                        cart.showVegetablesInCart();
                        cart.sortVegetable();
                        cart.showVegetablesInCart();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
            while (vegetableChoose != "exit");

            Console.ReadKey();
        }
    }
}
