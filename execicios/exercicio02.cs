using System;
using System.Globalization;
namespace Exercicio
{
    class Program
    {
        public static void Main(string[] args) {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = (pi * (Math.Pow(raio, 2)));
            
            Console.WriteLine($" A area de {raio} vale : {area.ToString ("F4", CultureInfo.InvariantCulture)}");
        }
    }
}