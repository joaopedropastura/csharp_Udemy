using System.Globalization;


namespace Product
{
	public class Produto
	{
		private string nome;
		private double preco{get; set;}
		private int quantidade{get; set;}

		public Produto() => quantidade = 1;

		// reutilizando contrutores
		public Produto(string nome, double preco) : this()
		{
			this.nome = nome;
			this.preco = preco;
		}
		//reutilizando construtores que criamos anteriormente
		public Produto(string nome, double preco, int quantidade) :this(nome,preco) => this.quantidade = quantidade;

		//propriedades sao uteis para melhor usabilidade das nossas classes criadas
		public string Nome
		{
			get => this.nome;
			set
			{
				if (value != null && nome.Length > 1)
					this.nome = value;
			}

		}
		public int Quantidade
		{
			get => this.quantidade;
		}
		public double Preco
		{
			get => this.preco;
		}
		public void RemProduto(int quantidade) => this.quantidade -= quantidade;

		public void AddProduto(int quantidade) => this.quantidade += quantidade;

		public override string ToString()
		{
			return $"nome: {this.nome}, preco: $ {this.preco.ToString("F2", CultureInfo.InvariantCulture)}, quantidade: {this.quantidade}, Total: $ {(this.quantidade*this.preco).ToString("F2", CultureInfo.InvariantCulture)}";
		}
	}
}
