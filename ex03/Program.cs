// See https://aka.ms/new-console-template for more information
using System.Globalization;
namespace Product
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto p = new Produto();
			Console.WriteLine("Entre os dados do produto: ");
			Console.Write("Nome: ");
			p.Nome = Console.ReadLine();
			Console.Write("Preço: ");
			p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Quantidade no estoque: ");
			p.Quantidade = int.Parse(Console.ReadLine());

			Console.WriteLine(p);




		}
	}
}