using System;
using System.Globalization;
namespace ExercicioSeis
    {
    class Program
    {
        public static void Main(string[] args){
            double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//base 
            double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//altura

            double pi = 3.14159;
            double areaTrianguloRetangulo = (ladoA * ladoC) / 2;
            double areaCirculo = pi * ladoC ;
            double areaQuadrado = ladoB * ladoB;
            double areaTrapezio = ((ladoA + ladoB) * (ladoC)) / 2;
            double areaRetangulo =  Math.Pow(ladoA * ladoB, 2);
            Console.WriteLine($"Area do Triangulo Retangulo: {areaTrianguloRetangulo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Trapezio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        
        }
    }
}