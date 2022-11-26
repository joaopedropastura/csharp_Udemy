using System.Globalization;

namespace Bank
{
	public class Banco
	{
		public string Nome { get; private set; }
		public double Saldo { get; private set; }
		public string numAccount { get; private set; }

		public Banco (string nome, double saldo, string numConta)
		{
			this.Nome = nome;
			this.Saldo = saldo;
			this.numAccount = numConta;
		}
		public void Deposito(double valor) => this.Saldo += valor;

		public void Saque(double valor) => this.Saldo -= (valor + 5);

		public void MundacaNome(string nome) => this.Nome = nome;


		public override string ToString()
		{
			return $"Nome: {this.Nome}, Numero da Conta: {this.numAccount}, Saldo: $ {this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
		}
	}
}