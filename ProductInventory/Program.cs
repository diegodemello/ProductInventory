using System.Globalization;

namespace ProductInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Entre com os dados do produto.");
            Console.Write("Nome: ");
            product.name = Console.ReadLine();
            Console.Write("Preço: ");
            product.price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            product.amount = int.Parse(Console.ReadLine());

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
