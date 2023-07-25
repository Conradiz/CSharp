// See https://aka.ms/new-console-template for more information 
using PrimeiroProjeto;
using System;
using System.Globalization;
namespace Exercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoaUm, pessoaDois;
            pessoaUm = new Pessoa();
            pessoaDois = new Pessoa();

            Console.WriteLine("Entre com o nome e idade da primeira pessoa");
            Console.WriteLine("Nome:");
            pessoaUm.Nome = Console.ReadLine();
            Console.WriteLine("Idade");
            pessoaUm.Idade = int.Parse(Console.ReadLine());
            //Segunda Pessoa
            Console.WriteLine("Entre com o nome e idade da segunda pessoa");
            Console.WriteLine("Nome:");
            pessoaDois.Nome = Console.ReadLine();
            Console.WriteLine("Idade");
            pessoaDois.Idade = int.Parse(Console.ReadLine());
            int maiorIdade = 0;
            string maiorNome = " ";
            if (pessoaUm.Idade > pessoaDois.Idade)
            {
                maiorIdade = pessoaUm.Idade;
                maiorNome = pessoaUm.Nome;
                
            }
            else
            {
                maiorIdade = pessoaDois.Idade;
                maiorNome = pessoaDois.Nome;
            }

            Console.WriteLine($"Primeira Pessoa \nNOME: {pessoaUm.Nome}, IDADE: {pessoaUm.Idade}");
            Console.WriteLine($"Segunda Pessoa \nNOME: {pessoaDois.Nome}, IDADE: {pessoaDois.Idade}");
            Console.WriteLine($"{maiorNome} é o mais velho(a) com {maiorIdade} anos");



        }
    }
}