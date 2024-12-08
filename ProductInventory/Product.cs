using System;
using System.Globalization;

namespace ProductInventory
{
    internal class Product
    {
        private string _name;
        public double price { get; private set; }
        public int amount { get; private set; }

        public Product()
        {
        }

        public Product(string Name, double Price, int Amount) {
            _name = Name;
            price = Price;
            amount = Amount;
        }

        public string Name
        {
            get { return _name;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("ERRO!");
                }
            }
        }
        public double TotalValueAmount()
        {
            return price * amount;
        }

        public void AddAmount(int newAmount)
        {
            amount += newAmount;
        }

        public void RemoveAmount(int newAmount)
        {
            amount -= newAmount;
        }

        public override string ToString()
        {
            return _name
                + ", R$ " 
                + price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + amount
                + " unidades, Total: R$ "
                + TotalValueAmount().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
