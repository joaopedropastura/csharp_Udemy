namespace Product
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto novoProd = new Produto
			{
				Nome = "TV",
				Preco = 400,
				Quantidade = 40
			};
			Console.WriteLine(novoProd);
		}
	}
}