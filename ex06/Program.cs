namespace Aluno
{
	class Program
	{
		static void Main(string[] args)
		{
			MeuDelegate Print = s => Console.Write(s);
			MeuDelegate PrintLine = s => Console.WriteLine(s);
			List<Alunos> listAlunos = new List<Alunos>();
			int quantAlunos;
			Print("Digite a quantidade de aulos que deseja lancar a nota: ");
			quantAlunos = int.Parse(Console.ReadLine());
			for(int x = 0; x < quantAlunos; x++)
			{
				Print("Digite o nome do aluno: ");
				listAlunos[x].Name = Console.ReadLine();
				for (int j = 0; j < 2; j++)
				{
					Print($"Digite o nota{j+1} do aluno: ");
					listAlunos[x].LancaNota(Int64.Parse(Console.ReadLine()));
				}
			}
			// Print($"NOta final :{lAluno[0].NotaFinal}");
		}
		public delegate void MeuDelegate(object s);
	}
}