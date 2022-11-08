namespace Product
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto p = new Produto()
			{
				Nome = "TV",
				Preco = 500.00,
				Quantidade = 20
			};
			Console.WriteLine(p);
		}
	}
}



//Usando costrutores



// namespace Product
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
// 			Produto p = new Produto("Tv", 500.00, 4);
// 			Console.WriteLine(p);
// 		}
// 	}
// }