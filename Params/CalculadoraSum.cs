public class Calculadora
{
	public static int Sum(params int[] numbers)
	{
		var sum = 0;
		for(int i = 0; i < numbers.Length; i++)
			sum += numbers[i];
		return sum;
	}
}