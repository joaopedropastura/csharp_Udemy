using System;

var n = int.Parse(Console.ReadLine());


Produto[] novoProd = new Produto[n];

for(int i = 0; i < n; i++)
{
	string nome = Console.ReadLine();
	double preco = Double.Parse(Console.ReadLine());
	int quant = Int16.Parse(Console.ReadLine());

	novoProd[i] = new Produto{Nome = nome, Preco=preco, Quantidade=quant};
}

double sum = 0.0;
for(int i = 0; i < n; i++)
{
	sum += novoProd[i].Preco;
}

double avg = sum/n;

Console.WriteLine($"Media de precos da loja: {avg.ToString("F2")}");
