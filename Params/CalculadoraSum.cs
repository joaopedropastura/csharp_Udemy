public class Calculadora
{
	public static int Sum(params int[] numbers)
	{
		var sum = 0;
		foreach (int x in numbers)
			sum += x;
		return sum;
	}

	public static int Sub(params int[] numbers)
	{
		var sub = 0;
		foreach (int x in numbers)
			sub-= x;
		return sub;
	}
}