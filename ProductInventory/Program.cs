using System.Globalization;

namespace ProductInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("TV", 500.00, 10);

            product.SetName("TV 4K");
        }
    }
}
