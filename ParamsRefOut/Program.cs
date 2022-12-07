class Calculator{
    public static void Triple(ref int x)
    {
        x = x*3;
    }

    public static void TripleRef(int origin, out int result)
    {
        result = origin*3;
    }
}

class Program{

    static void Main(string[] args)
    {

        int a = 10;
        int triple;
        Calculator.Triple(ref a);
        Calculator.TripleRef(a,out triple);
        System.Console.WriteLine(a);
        System.Console.WriteLine(triple);
    }
}