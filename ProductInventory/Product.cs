using System;
using System.Globalization;

namespace ProductInventory
{
    internal class Product
    {
        public string name;
        public double price;
        public int amount;

        public Product()
        {

        }

        public Product(string Name, double Price)
        {
            name = Name;
            price = Price;
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
            return name 
                + ", R$ " 
                + price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + amount
                + " unidades, Total: R$ "
                + TotalValueAmount().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
