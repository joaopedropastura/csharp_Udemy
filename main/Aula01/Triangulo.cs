//criar uma classe para criar um triangulo
using System;
class Triangulo
{
	public double a;
	public double b;
	public double c;

	public double Area()
	{
		double p = (a + b + c) / 2.0;
		return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
	}

}

