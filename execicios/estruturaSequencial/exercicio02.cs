//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
//casas decimais conforme exemplos.
//Fórmula da área: area = π . raio2
//Considere o valor de π = 3.14159

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