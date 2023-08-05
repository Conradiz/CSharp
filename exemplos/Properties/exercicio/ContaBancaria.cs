using System.Globalization;
namespace ConsoleApp
{
    internal class ContaBancaria
    { 
         private double _saldo;
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        
        //Construtor Personalizado
        public ContaBancaria(int numero, string titular, double saldo) { 
                Numero = numero;
                Titular = titular;
                _saldo = saldo;
        }
    }
}