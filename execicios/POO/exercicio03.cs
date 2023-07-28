using System.Globalization;

namespace Exerciciotres
{
    class Program
    {
        public static void Main (string[] args)
        {


            Aluno al = new Aluno();

           Console.Write("Digite o nome do aluno:");
           al.Nome = Console.ReadLine();
           Console.Write("Digite as tres notas do aluno");
           al.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           al.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           al.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NOTA FINAL = {al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (al.Aprovacao()){
                Console.Write("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} Pontos");
            }


        }
    }
}