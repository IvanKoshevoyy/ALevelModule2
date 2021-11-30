using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Cucumber : Vegetable
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
        string[] Sorts = { "Мурашка", "Бенефис", "Алексеич", "Емеля", "Апрельский", "Ерофей" };
        public Cucumber(int Amount, string sort)
        : base(Amount)
        {
            Name = "Cucumber";
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
               if(pair.Key == sort)
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
        public Cucumber() : base()
        {
            Sort = "Мурашка";
        }
        Dictionary<string, int> prices = new Dictionary<string, int>
        {
            ["Мурашка"] = 10,
            ["Бенефис"] = 20,
            ["Алексеич"] = 25,
            ["Емеля"] = 15,
            ["Апрельский"] = 30,
            ["Ерофей"] = 45
        };
        Dictionary<string, int> calories = new Dictionary<string, int>
        {
            ["Мурашка"] = 25,
            ["Бенефис"] = 25,
            ["Алексеич"] = 15,
            ["Емеля"] = 10,
            ["Апрельский"] = 35,
            ["Ерофей"] = 40
        };
        public void showAllInfo()
        {
            Console.Write("Sorts of Cucumber\n");
            foreach (var pair in prices)
            {
                Console.WriteLine("{0} - {1} - {2}", pair.Key, pair.Value, calories[pair.Key]);
            }
        }
        public override void show()
        {

            Console.WriteLine(" Cucumber {0} - {1}", Sort, Amount);
        }
    }
}
