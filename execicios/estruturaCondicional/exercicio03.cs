using System;
using System.Globalization;

namespace ExecicioDois {
    class Program{
        public static void Main (string[] args){

           Console.Write("Digite um numero A:");
           int numeroA = int.Parse(Console.ReadLine());
           Console.Write("Digite um numero B: ");
           int numeroB = int.Parse(Console.ReadLine());

           if (numeroA % numeroB == 0){
            Console.WriteLine("São multiplos");
           } 
           else {
            Console.WriteLine("Não sao multiplos");
           }
        }
    }
}