//Em Programação, "vetor' é o nome dado a arranjos inidimensionais
using System.Globalization;

namespace Vetores {
    static void Main (string[] args) {
        Console.WriteLine("Ate quanto voce deseja contar?");
        int n = int.Parse(Console.ReadLine());

        double [] vect = new double [n];

        for (int i = 0; i < n; i++){
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}