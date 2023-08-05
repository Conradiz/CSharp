namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            double saldo;
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da Conta:");
            string nome = Console.ReadLine();
            Console.Write("Havera Deposito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.Write("Entre com o valor do deposito: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                saldo = 0;          
            }
  
            ContaBancaria conta = new ContaBancaria(numero, nome, saldo);

            Console.WriteLine(conta);

            Console.WriteLine("Valor do deposito: ");
            saldo = double.Parse(Console.ReadLine());
            conta.Deposito(saldo);

            Console.WriteLine(conta);
            Console.WriteLine("Entre com um valor para Saque: ");
            saldo = double.Parse(Console.ReadLine());
            conta.Saque(saldo);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);
        }
    }
}