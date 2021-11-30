using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Product
    {
        public string Name { get; set; }
        private double price;
        public double Price 
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        private int amount;
        public int Amount 
        {
            get => amount;
            set
            {
                if (value >= 0)
                    amount = value;
            }
        }
        private double volume;
        public double Volume 
        {
            get => volume;
            set
            {
                if (value > 0)
                    volume = value;
            }
        }

        public Product(string Name, double Price, int Amount, double Volume)
        {
            this.Volume = Volume;
            this.Amount = Amount;
            this.Price = Price;
            this.Name = Name;
        }
        public Product(string Name, double Price, double Volume)
        {
            this.Volume = Volume;
            this.Price = Price;
            this.Name = Name;
        }

    }
}
