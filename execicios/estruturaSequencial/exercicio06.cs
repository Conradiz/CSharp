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

            double areaTrianguloRetangulo = (ladoA * ladoC) / 2;
            double areaTrapezio = ((ladoA + ladoB) * (ladoC)) / 2;
            Console.WriteLine($"Area do Triangulo Retangulo: {areaTrianguloretangulo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Trapezio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}