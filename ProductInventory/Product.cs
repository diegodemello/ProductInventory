using System;
using System.Globalization;

namespace ProductInventory
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product()
        {
        }

        public Product(string Name, double Price, int Amount) {
            _name = Name;
            _price = Price;
            _amount = Amount;
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

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public int Amount
        {
            get
            {
                return _amount;
            }
        }

        public double TotalValueAmount()
        {
            return _price * _amount;
        }

        public void AddAmount(int newAmount)
        {
            _amount += newAmount;
        }

        public void RemoveAmount(int newAmount)
        {
            _amount -= newAmount;
        }

        public override string ToString()
        {
            return _name
                + ", R$ " 
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _amount
                + " unidades, Total: R$ "
                + TotalValueAmount().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
