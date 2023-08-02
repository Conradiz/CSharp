namespace ExercicioTres
{
    class Program
    {
        public static void Main (string[] args)
        {
            Retangulo dimensoes = new Retangulo();
            Console.Write("Digite a Largura do Retangulo: ");
            dimensoes.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Altura do Retangulo: ");
            dimensoes.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine($"Area do Retangulo = {dimensoes.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro do Retangulo = {dimensoes.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal do Retangulo = {dimensoes.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }

}