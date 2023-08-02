//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

using System;

namespace ExercicioDois
{
    class Program
    {
        public static void Main (string[] args)
        {
             Console.WriteLine("Quantos valores voce deseja inserir");
            int n = int.Parse(Console.ReadLine());
            int x = 0; 
            int[] numeros = new int[n];
            int nTotaisForaIntervalo = 0;
            int nTotaisIntervalo = 0;
            int i = 0;

            for (i = 0; i < n; i++){
                Console.Write($"Digite o {i+1}° valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if ((numeros[i] > 10) && (numeros[i] <20)){
                    nTotaisIntervalo += 1;
                    Console.WriteLine($"{numeros[i]} esta dentro do intervalo");
                }
                else {
                    Console.WriteLine($"Numero {numeros[i]} esta fora do intervalo");
                    nTotaisForaIntervalo +=1;
                }
            }
            Console.WriteLine("Finish");
            Console.WriteLine($"{nTotaisForaIntervalo} valores estão fora do intervalo");
            Console.WriteLine($"{nTotaisIntervalo} valores estão dentro do intervalo");

        }
    }
}