public class Funcionario
{
	public string Name{get;set;}
	public float Salario{get;set;}

	
	public virtual string PrintData()
	{
		return ($"Nome: {this.Name}\n Salario: {this.Salario}");
	}
}