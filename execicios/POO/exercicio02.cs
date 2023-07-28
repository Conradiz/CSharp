using System;
using System.Globalization;

namespace ExercicioDois 
{
    class Program
    {
        public static void Main (string[] args){
          Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f);

            Console.Write($"Salario Liquido: {f.SalarioLiquido()}");
            
            Console.Write ("Digite a porcentagem para aumentar o salario: ");
            double por = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(por);

            Console.Write($"Dados atualizados: {f}");


        }
    }
}