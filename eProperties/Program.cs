namespace Product
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto novoProd = new Produto("TV", 500.34, 12);

			novoProd.Nome = "TV 4K";
			Console.WriteLine(novoProd);
			Console.WriteLine(novoProd.Preco);
			Console.WriteLine(novoProd.Quantidade);
		}
	}
}


//Propriedades entao, sao muito utilizadas para proteger os acessos dos usuarios.
//na pratica, tornamos todos atributos totalmente privados e criamos uma PROPRIEDADE, assim o usuario acessaria
// de forma identica a um atributo porem protejendo-os