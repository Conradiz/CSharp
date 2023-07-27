using System;
using System.Globalization;

namespace ExecicioDois {
    class Program{
        public static void Main (string[] args){
            
            Console.WriteLine("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0 ){
                Console.Write("Numero PAR");
            }
            else {
                Console.Write("Numero IMPAR");
            }

        }
    }
}