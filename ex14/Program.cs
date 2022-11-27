using System;


var n = Int16.Parse(Console.ReadLine());
Hotel[] novoHotel = new Hotel[n];


for(int i = 0; i < n; i++)
{
	Console.Write("Digite o nome: ");
	var nome = Console.ReadLine();
	Console.Write("Digite o Email: ");
	var email = Console.ReadLine();
	Console.Write("O numero do quarto: ");
	var qt = Int16.Parse(Console.ReadLine());

	novoHotel[i] = new Hotel{Nome = nome, Email = email, Quarto = qt};
}


for(int x = 0; x < n; x++)
{
	Console.WriteLine($"Rent #{x+1}:");
	Console.WriteLine(novoHotel[x]);
}
