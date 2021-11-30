using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Cabbage : Vegetable
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
        string[] Sorts = { "Белокочанная", "Июньская", "Золотой гектар", "Точка", "Ринда", "Тобия" };
        public Cabbage(int Amount, string sort)
        : base(Amount)
        {
            Name = "Cabbage";
            Color = "Green";

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
        public Cabbage() : base()
        {
            Sort = "Белокочанная";
        }

        Dictionary<string, int> prices = new Dictionary<string, int>
        {
            ["Белокочанная"] = 15,
            ["Июньская"] = 20,
            ["Золотой гектар"] = 25,
            ["Точка"] = 35,
            ["Ринда"] = 50,
            ["Тобия"] = 45
        };
        Dictionary<string, int> calories = new Dictionary<string, int>
        {
            ["Белокочанная"] = 10,
            ["Июньская"] = 25,
            ["Золотой гектар"] = 20,
            ["Точка"] = 30,
            ["Ринда"] = 60,
            ["Тобия"] = 40
        };
        public void showAllInfo()
        {
            Console.Write("Sorts of Cabbage\n");
            foreach (var pair in prices)
            {
                Console.WriteLine("{0} - {1} - {2}", pair.Key, pair.Value, calories[pair.Key]);
            }
        }
        public override void show()
        {

            Console.WriteLine(" Cabbage {0} - {1}", Sort, Amount);
        }
    }
}