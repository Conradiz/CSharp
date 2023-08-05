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
         public double Saldo { 
            get { return (double)_saldo; }
            set
            {
                if ( value > 0 ) {
                    _saldo = value;
                }
            }
        }

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public void Saque(double quantia)
        {
            _saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numero
            + ", Titular: " + Titular
            + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}