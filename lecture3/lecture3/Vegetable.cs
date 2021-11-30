using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    abstract class Vegetable : IComparable<Vegetable>
    {
        public string Name {get; set;}
        public string Color {get; set;}
        protected double calories;
        public double Calories
        {
            get => calories;
            set
            {
                if (value > 0)
                    calories = value;
            }
        }
        protected double price;
        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        protected int amount;
        public int Amount
        {
            get => amount;
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("Wrong input");
                }
            }

        }
        public Vegetable(int Amount)
        {
            this.Amount = Amount;
        }
        public Vegetable()
        {
            Amount = 1;
        }
        public abstract void show();

        public int CompareTo(Vegetable other)
        {
            return Amount.CompareTo(other.Amount);
        }
    }
}
