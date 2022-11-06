using System.Globalization;

namespace Salario
{
	class Program
	{
		static void Main(string[] args)
		{
			MeuDelegate Print = s => Console.Write(s);
			MeuDelegate PrintLine = s => Console.WriteLine(s);
			Funcionario func = new Funcionario();
			func.Nome = "João Pedro Soares";
			func.SalarioBtr = 6000.00;
			func.Imposto = 1000.00;
			PrintLine($"Funcionario: {func.Nome}");
			PrintLine($"Salario bruto: {func.SalarioBtr}");
			PrintLine($"Imposto: {func.Imposto}");
			PrintLine($"\nFuncionario: {func.Nome}, Salario Liquido: ${func.SalarioLiq().ToString("F2", CultureInfo.InvariantCulture)}");
			PrintLine($"Dados atualizados: {func.Nome}, Salario Liquido: ${func.AumentaSalario(10.00).ToString("F2", CultureInfo.InvariantCulture)}");
		}
		public delegate void MeuDelegate(object s);
	}
}