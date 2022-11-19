using System.Globalization;


//sem a necessecidade de um construtor

namespace Product
{
	public class Produto
	{
		public string Nome{get;set;}
		public double Preco{get;set;}
		public int Quantidade{get;set;}

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