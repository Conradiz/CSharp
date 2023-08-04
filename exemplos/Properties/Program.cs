using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Produto p = new Produto("Galaxy", 500.00, 10);
            Console.WriteLine(p.Nome);

            p.Nome = (Console.ReadLine());
            

            Console.WriteLine(p);
        }
    }
}