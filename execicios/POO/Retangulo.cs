using System.Globalization;
namespace ExercicioCinco{

    internal class Retangulo{

        public double Largura;
        public double Altura;

        public double Area(){
            return Largura * Altura;
        }

        public double Perimetro(){
            return (Largura + Altura) * 2;
        }

        public double Diagonal(){
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

         public override string ToString(){
            return "AREA: " + Area().ToString("F2", CultureInfo.InvariantCulture) + ", "
            + " PERIMETRO: " + Perimetro().ToString("F2") + ", "
            + " DIAGONAL: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
         }
    }
}