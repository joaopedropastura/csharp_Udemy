namespace Product
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto novoProduto = new Produto("TV", 349);

			novoProduto.AddProduto(300);
			// novoProduto.Quantidade = 200;
			Console.WriteLine(novoProduto);
		}
	}
}