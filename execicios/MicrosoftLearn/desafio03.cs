using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program 
    {
        public static void Main(string[] args)
        {
          int [] numbers = {3, 9, 15, 16, 13, 52};
          int total = 0;
          bool found = false;

          foreach (int numero in numbers){

            total = total + numero;
            if (numero == 52) 
                found = true;
          }
          if (found)
            Console.WriteLine("Contein o numero 52");
        Console.WriteLine($"Total: {total}");
        }
    }
}