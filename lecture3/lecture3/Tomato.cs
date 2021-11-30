using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Tomato : Vegetable 
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
        string[] Sorts = { "Первоклашка", "Красный петух", "Рио Гранде", "Снежный барс", "Гигант лимонный", "Снегирек" };
        public Tomato(int Amount, string sort)
        : base(Amount)
        {
            Name = "Tomato";
            Color = "Red";
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
        public Tomato() : base()
        {
            Sort = "Первоклашка";
        }
        Dictionary<string, int> prices = new Dictionary<string, int>
        {
            ["Первоклашка"] = 15,
            ["Красный петух"] = 25,
            ["Рио Гранде"] = 30,
            ["Снежный барс"] = 45,
            ["Гигант лимонный"] = 50,
            ["Снегирек"] = 20
        };
        Dictionary<string, int> calories = new Dictionary<string, int>
        {
            ["Первоклашка"] = 10,
            ["Красный петух"] = 30,
            ["Рио Гранде"] = 20,
            ["Снежный барс"] = 40,
            ["Гигант лимонный"] = 55,
            ["Снегирек"] = 25
        };
        public void showAllInfo()
        {
            Console.Write("Sorts of Tomato\n");
            foreach (var pair in prices)
            {
                Console.WriteLine("{0} - {1} - {2}", pair.Key, pair.Value, calories[pair.Key]);
            }
        }
        public override void show()
        {
            Console.WriteLine(" Tomato {0} - {1}", Sort, Amount);
        }
    }
}
