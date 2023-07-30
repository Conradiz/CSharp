/* Desafio de código – Escrever um código para implementar as regras de jogo
Veja as regras para o jogo de batalha que você precisa implementar em seu projeto de código:

Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.
O herói e o monstro começarão com dez pontos de integridade.
Todos os ataques serão um valor entre 1 e 10.
O herói atacará primeiro.
Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
Imprima quem foi o vencedor. */

using System;
using System.Globalization;

namespace ExercicioQuatro
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

        }
    }
}