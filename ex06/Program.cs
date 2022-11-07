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
				Alunos novoAluno = new Alunos();
				
				Print("Digite o nome do aluno: ");
				novoAluno.Name = Console.ReadLine();
				// novoAluno.Name = nome;
				for (int j = 0; j < 3; j++)
				{
					Print($"Digite o nota{j+1} do aluno: ");
					novoAluno.LancaNota(Int64.Parse(Console.ReadLine()));
				}
				listAlunos.Add(novoAluno);
			}
			Print($"Nota final: {listAlunos[0].NotaFinal}\nResultado: {listAlunos[0].Resultado()}");
		}
		public delegate void MeuDelegate(object s);
	}
}