using System.Globalization;

namespace Product
{
	public class Produto
	{
		public string Nome{get;set;}
		public double Preco{get;set;}
		public int Quantidade{get;set;}
		public double ValorTotalEmEstoque()
		{
			return this.Quantidade * this.Preco;
		}
		public void AdicionarProdutos(int qtd) => this.Quantidade = Quantidade + qtd;

		public void RemoverProdutos(int qtd) => this.Quantidade = Quantidade - qtd;
		public override string ToString()
		{
			return $"Nome: {Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
		}



	}
}