using System;

namespace DesafioOito
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Random dado = new Random();
            int diasExpiracao = dado.Next(12);
            int disconto = 0;

            if (diasExpiracao == 0) {
                Console.WriteLine("Sua assinatura expirou");
                
            }
            else if (diasExpiracao == 1) {
                    disconto = 20;
                    Console.WriteLine("Your subscription expires within a day. Renew now and save 20 %");
                }
            else if (diasExpiracao <= 5){
                Console.WriteLine($"Sua assinatura expira em {diasExpiracao}");
                disconto = 10;
            }

            else if (diasExpiracao <= 10){
                    Console.WriteLine("Sua assinatura expirará em breve. Renovar agora!");
                }

            if (disconto > 0){
                Console.WriteLine($"Renove agora com {disconto}% de desconto");
            }
            else{
                Console.WriteLine($"Falta {diasExpiracao} dias para expirar");
            }     
        }
    }
}