namespace ContacaoDolar
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Qual é a cotacao do dolar hoje? ");
			double dolar = Double.Parse(Console.ReadLine());
			Console.Write("Quantos dolares voce vai comprar? ");
			double qt = Double.Parse(Console.ReadLine());
			Console.WriteLine($"Valor a ser pago em reais = {Conversao.Dolar(dolar,qt)}");
		}
	}
}