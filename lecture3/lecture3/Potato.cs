using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Potato : Vegetable
    {
        private string sort;
        public string Sort
        {
            get
            {
                return sort;
            }

            set
            {
                bool check = false;
                foreach (string sortName in Sorts)
                {
                    if (value == sortName)
                    {
                        sort = value;
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    throw new Exception();
                }
            }
        }
        string[] Sorts = { "Гала", "Ред Скарлет", "Королева Анна", "Удача", "Импала", "Адретта" };
        public Potato(int Amount, string sort)
        : base(Amount)
        {
            Name = "Potato";
            Color = "Yellow";

            try
            {
                Sort = sort;
            }
            catch
            {
                Console.WriteLine("Wrong sort");
            }
            foreach (var pair in prices)
            {
                if (pair.Key == sort)
                {
                    this.Price = pair.Value;
                }
            }
            foreach (var pair in calories)
            {
                if (pair.Key == sort)
                {
                    this.Calories = pair.Value;
                }
            }
        }
        public Potato() : base()
        {
            Sort = "Гала";
        }
        Dictionary<string, int> prices = new Dictionary<string, int>
        {
            ["Гала"] = 20,
            ["Ред Скарлет"] = 25,
            ["Королева Анна"] = 15,
            ["Удача"] = 30,
            ["Импала"] = 45,
            ["Адретта"] = 40
        };
        Dictionary<string, int> calories = new Dictionary<string, int>
        {
            ["Гала"] = 15,
            ["Ред Скарлет"] = 20,
            ["Королева Анна"] = 10,
            ["Удача"] = 35,
            ["Импала"] = 40,
            ["Адретта"] = 50
        };
        public void showAllInfo()
        {
            Console.Write("Sorts of Potato\n");
            foreach (var pair in prices)
            {
                Console.WriteLine("{0} - {1} - {2}", pair.Key, pair.Value, calories[pair.Key]);
            }
        }
        public override void show()
        {

            Console.WriteLine(" Potato {0} - {1}", Sort, Amount);
        }
    }
}
