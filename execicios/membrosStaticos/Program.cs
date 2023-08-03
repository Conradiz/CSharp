using System.Globalization;
namespace Exercicio
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual é a cotação do dolar? : ");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares voce vai quere comprar");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorFinal = ConversorMoeda.ValorFinal(cota, valor);

            Console.WriteLine($"Valor a ser pago em Reais: {valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}