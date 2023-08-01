/* Declare uma matriz e inicialize-a com os seguintes elementos: B123
C234, A345, C15 ,B177, G3003, C235, B179
Esses valores representam as IDs de pedidos fraudulentos que seu aplicativo usará.

Crie uma instrução foreach para percorrer cada elemento da sua matriz.

Reporte as IDs de pedido que começam com a letra "B".

É necessário avaliar cada elemento da matriz. Reporte as IDs de pedido potencialmente fraudulentos detectando os pedidos que começam com a letra "B". Para determinar se um elemento começa ou não com a letra "B", use o método String.StartsWith(). */
using System;
using System.Globalization;

namespace DesafioNove
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string[] ids = {"B123","C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

            foreach (string id in ids){
                Console.WriteLine($"Pedidos com possiveis fraudes: {id}");
            }
        }
    }
}