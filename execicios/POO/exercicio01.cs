using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Retangulo  r = new Retangulo();
            Console.WriteLine("Digite a Altura do Triangulo:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Largura do triangulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Dimensoes do Triangulo: {r}");

        }
    }
}