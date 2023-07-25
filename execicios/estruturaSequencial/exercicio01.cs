using System;

namespace exercicio
{
    class Program
    {
        public static void Main(string[] args){
            
            int numeroUm = int.Parse(Console.ReadLine());
            int numeroDois = int.Parse(Console.ReadLine());
            int soma = numeroUm + numeroDois;
            Console.WriteLine($"A soma de {numeroUm} + {numeroDois} é igual a: {soma}");
        }

    }
}