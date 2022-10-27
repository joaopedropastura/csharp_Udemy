class Program
{
	static void Main(string[] args)
	{
		Triangulo x, y;

		x = new Triangulo();
		y = new Triangulo();

		x.a = double.Parse(Console.ReadLine());
		x.b = double.Parse(Console.ReadLine());
		x.c = double.Parse(Console.ReadLine());

		y.a = double.Parse(Console.ReadLine());
		y.b = double.Parse(Console.ReadLine());
		y.c = double.Parse(Console.ReadLine());


		System.Console.WriteLine("${x.Area():2F}");
		System.Console.WriteLine("${y.Area():2F}");

	}

}