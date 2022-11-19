using System.Globalization;


namespace Product
{
	public class Produto
	{
		public string Nome{get;set;}
		public double Preco{get;set;}
		public int Quantidade{get;set;}

		public Produto() => Quantidade = 1;

		// reutilizando contrutores
		public Produto(string nome, double preco) : this()
		{
			this.Nome = nome;
			this.Preco = preco;
		}
		//reutilizando construtores que criamos anteriormente
		public Produto(string nome, double preco, int quantidade) :this(nome,preco) => this.Quantidade = quantidade;

		public override string ToString()
		{
			return $"Nome: {this.Nome}, Preco: $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {this.Quantidade}";
		}
	}
}







//Usando costrutores


// namespace Product
// {
// 	public class Produto
// 	{
// 		public string Nome{get;set;}
// 		public double Preco{get;set;}
// 		public int Quantidade{get;set;}

// 		public Produto(string nome, double preco, int quantidade)
// 		{
// 			this.Nome = nome;
// 			this.Preco = preco;
// 			this.Quantidade = quantidade;
// 		}
// 		public Produto(string nome, double preco)
// 		{
// 			this.Nome = nome;
// 			this.Preco = preco;
// 			this.Quantidade = 0;
// 		}

// 		public override string ToString()
// 		{
// 			return $"Nome: {this.Nome}, Preco: $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {this.Quantidade}";
// 		}
// 	}
// }