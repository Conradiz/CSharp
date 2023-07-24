using System;
using System.Globalization;
namespace Exercicio
{
    class Program
    {
        public static void Main(string[] args) {

            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as tres medidas do triangulo X");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Entre com as tres medidas do triangulo Y");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InstalledUICulture));
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) *(p - yB) * (p - yC));
            Console.WriteLine("Area de Y: "+ areaY.ToString("F4", CultureInfo.InvariantCulture));
             double maiorArea;
            if (areaX > areaY) {
                maiorArea = areaX;
            }
            else {
                maiorArea = areaY;
            }
           Console.WriteLine("A maior area é: "+ maiorArea);


        }
    }
}

