// See https://aka.ms/new-console-template for more information
namespace Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            tri.Area(12,23);
            System.Console.WriteLine(tri);
        }
    }
}