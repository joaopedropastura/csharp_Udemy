using System.Globalization;


namespace Product
{
	public class Produto
	{
		public string Nome{get; private set;}
		public double Preco{get; private set;}
		public int Quantidade{get;private set;}

		public Produto() => Quantidade = 1;

		// reutilizando contrutores
		public Produto(string nome, double preco) : this()
		{
			this.Nome = nome;
			this.Preco = preco;
		}
		//reutilizando construtores que criamos anteriormente
		public Produto(string nome, double preco, int quantidade) :this(nome,preco) => this.Quantidade = quantidade;

		public void RemProduto(int quantidade) => this.Quantidade -= quantidade;

		public void AddProduto(int quantidade) => this.Quantidade += quantidade;

		public override string ToString()
		{
			return $"Nome: {this.Nome}, Preco: $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {this.Quantidade}, Total: $ {(this.Quantidade*this.Preco).ToString("F2", CultureInfo.InvariantCulture)}";
		}
	}
}
