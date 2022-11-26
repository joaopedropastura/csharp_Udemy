namespace Bank
{
	class Program
	{
		static void Main(string[] args)
		{
			Banco novoUser = new Banco("Joao Pedro",432.45,"564323");
			// Banco novoUser2 = new Banco()
			// {
			// 	"Joao Pedro",
			// 	4543,34,
			// 	"5T432F3"
			// };
			novoUser.Deposito(100);
			novoUser.Saque(95);
			Console.WriteLine(novoUser);
			// Console.WriteLine(novoUser2);
		}
	}
}