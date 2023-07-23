using System;
using System.Globalization;

namespace whi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero != 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outo numero ou '0'para finalizar");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Programa finalizado");
        }
    }
}