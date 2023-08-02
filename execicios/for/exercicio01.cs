//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
using System;

namespace ExercicioUm
{
    class Program
    {
        public static void Main (string[] args )
        {
            Console.Write("Digite um valor:  ");
            int valor = int.Parse(Console.ReadLine());
            int cont = 0;
            while (cont <= valor){
                cont++;
                if (cont % 2 == 1){
                    Console.WriteLine($"Numero: {cont} IMPAR");
                }
            } 
            Console.WriteLine("Finalizado");
        }
    }
}