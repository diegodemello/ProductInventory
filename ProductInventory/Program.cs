using System.Globalization;

namespace ProductInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto.");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int amount = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, amount);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + product);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int newAmount = int.Parse(Console.ReadLine());
            product.AddAmount(newAmount);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + product);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            newAmount = int.Parse(Console.ReadLine());
            product.RemoveAmount(newAmount);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + product);
        }
    }
}
