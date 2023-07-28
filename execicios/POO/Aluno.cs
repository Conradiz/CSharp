using System.Globalization;
namespace ExercicioCinco{

    internal class Aluno 
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;
        public double NotaFinal(){
            return NotaA + NotaB + NotaC;
        }

        public bool Aprovacao(){
            if (NotaFinal() >=  60.00){
                return true;
            }
            else {
                return false;
            }            
        }
        public double NotaRestante(){
            if (Aprovacao()){
                return 0.0;
            }
            else{
                return 60.0 - NotaFinal();
            }
        }

        
    }
 }