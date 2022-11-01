using System;


namespace Salario
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Funcionario> f1 = new List<Funcionario>();
			int i = 0;
			int a;
			do
			{
				System.Console.Write($"Digite o nome do {i++} funcionario: ");
				a = Console.Write();
				i++;
			}
			while(a != 0);


		}

	}
}