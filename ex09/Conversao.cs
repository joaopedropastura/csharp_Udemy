namespace ContacaoDolar
{
	public class Conversao
	{
		static double IOF = 1.06;
		public static double Dolar(double dolar, double quant) => dolar*quant*IOF;
	}
}