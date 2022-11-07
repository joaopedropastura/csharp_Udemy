namespace Calcular
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite o valor do raio: ");
			double raio = Int64.Parse(Console.ReadLine());
			Console.WriteLine($"Volume: {Calculadora.Volume(raio)}");
			Console.WriteLine($"Circunferencia: {Calculadora.Circunferencia(raio)}");
		}
	}
}