namespace Aluno
{
	public class Alunos
	{
		public string Name{get;set;}
		public double NotaFinal{get;set;} = 0;

		public void LancaNota(double nota) => NotaFinal += nota;
		public string Resultado() => NotaFinal >= 180.00 ? "APROVADO" : "REPROVADO";
	}
}