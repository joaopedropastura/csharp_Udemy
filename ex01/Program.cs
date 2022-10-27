public class Program
{
	static void Main(string[] args)
	{
		Pessoa b;
		Funcionario x,y;


		Pessoa a = new Pessoa();
		b = new Pessoa();
		System.Console.WriteLine("Dados da primeira pessoa:");
		System.Console.Write("Nome: ");
		a.Name = Console.ReadLine();
		System.Console.Write("Idade ");
		a.Idade = int.Parse(Console.ReadLine());


		System.Console.WriteLine("Dados da primeira pessoa:");
		System.Console.Write("Nome: ");
		b.Name = Console.ReadLine();
		System.Console.Write("Idade ");
		b.Idade = int.Parse(Console.ReadLine());

	}
}