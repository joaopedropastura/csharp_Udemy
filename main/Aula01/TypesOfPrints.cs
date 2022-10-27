// using System;
// using System.Globalization;

// namespace Aula01
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
// 			double saldo = 10.324532;
// 			string nome = "Joao Pedro";
// 			int idade = 22;
// 			Console.WriteLine(saldo.ToString("F4"));
// 			Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


// 			//PlaceHolders
// 			Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reias", nome, idade, saldo);
// 			//Concatenação
// 			Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
// 			//Interpolação
// 			Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
// 			//utilizando o padrao global para imprimir valores com o CultureInfo.InvariantCulture
// 		}
// 	}
// }