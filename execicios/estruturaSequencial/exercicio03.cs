using System;

namespace exercicio{
    class Program{
        public static void Main(string[] args){
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = (A*B) - (C*D);

            Console.WriteLine($"A diferença é: {diferenca}");

            
        }
    }
}