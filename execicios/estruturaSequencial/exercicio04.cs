using System;
using System.Globalization;
namespace exercicio{
    class Program{
        public static void Main(string[] args){

        Console.Write("Numero do Funcionario:");
        int numFuncionario = int.Parse(Console.ReadLine());
        double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = horas * valorHora;
        Console.WriteLine($"Numero do funcionario = {numFuncionario}");
        Console.WriteLine($" Salario = {salario.ToString("F2", CultureInfo.InvariantCulture)} R$");
        }
    }
}