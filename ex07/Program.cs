namespace Course
{
	class Program
	{
		static double Pi = 3.1415;
		static void Main(string[] args)
		{
			Console.Write("Entre com o valor do raio: ");
			double raio = double.Parse(Console.ReadLine());

			double circ = Circunferencia(raio);
			double vol = Volume(raio);
			Console.WriteLine($"Circunferencia: {Circunferencia(raio)}");
			Console.WriteLine($"Volume: {Volume(raio)}");
		}
		static double Circunferencia(double r) => 2.0*Pi*r;
		static double Volume (double r) => 4.0/3.0*Pi*Math.Pow(r,3);
	}
}