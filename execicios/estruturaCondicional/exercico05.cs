using System;

namespace ExercicioCinco
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tDigite o codigo de um item:\n ");
            Console.WriteLine ("|CODIGO|\t | ESPECIFICACAO |\t| PRECO |");
            Console.WriteLine(" 1 \t\t Cachorro Quente \t R$4.00");
            Console.WriteLine(" 2 \t\t X-Salada \t\t R$4.50");
            Console.WriteLine(" 3 \t\t X-Bacon \t\t R$5.00");
            Console.WriteLine(" 4 \t\t Torrada Simples \t R$2.00");
            Console.WriteLine(" 5 \t\t Refrigerante \t\t R$1.50");
            Console.Write("-------------------------------------------------\n");
            Console.Write("Escolha: ");
            int codigo = int.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());
            double valor;
            double valorFinal;

            switch (codigo){
                case 1:
                    valor = 4.00;
                    valorFinal = quantidade * valor; 
                    Console.WriteLine($"Valor Final: {valorFinal}");
                    break;
                case 2:
                    valor = 4.50;
                    valorFinal = quantidade * valor; 
                    Console.WriteLine($"Valor Final: {valorFinal}");
                    break;
                case 3:
                    valor = 5.00;
                    valorFinal = quantidade * valor; 
                    Console.WriteLine($"Valor Final: {valorFinal}");
                    break;
                case 4: 
                    valor = 2.00;
                    valorFinal = quantidade * valor; 
                    Console.WriteLine($"Valor Final: {valorFinal}");
                    break;
                case 5: 
                    valor = 1.50;
                    valorFinal = quantidade * valor; 
                    Console.WriteLine($"Valor Final: {valorFinal}");
                    break;
                default:
                    Console.WriteLine("opcao invalida");
                    break;
            }
           


        }
    }
}