namespace Calcular
{
	public class Calculadora
	{
		public static double Pi = 3.14;


		public static double Circunferencia(double r) => 2.0*Pi*r;
		public static double Volume(double r) => 4.0/3.0 *Pi*Math.Pow(r,3);
	}
}