namespace Salario
{
    public class Funcionario
    {
        public string Nome {get;set;}
        public double SalarioBtr {get;set;}
        public double Imposto {get;set;}


        public double SalarioLiq() => this.SalarioBtr - this.Imposto;
        public double AumentaSalario(double porcent) => this.SalarioBtr += (this.SalarioBtr*porcent)/100.0;
    }
}