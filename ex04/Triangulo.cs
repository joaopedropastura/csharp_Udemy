namespace Poligono
{
    public class Triangulo
    {
        private double largura{get;set;}
        private double altura{get;set;}
        private double area{get;set;}
        public void Area(double largura, double altura)
        {
            this.altura = altura;
            this.largura = largura;
            this.area = (altura*largura)/2;
        }   
        public override string ToString()
        {
            return $"AREA = {this.area}\nAltura = {this.altura}\nLargura = {this.largura}";

        }
    }  
}