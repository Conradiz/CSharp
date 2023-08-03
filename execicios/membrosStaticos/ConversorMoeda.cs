using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ConversorMoeda
    {
        static public double Iof = 6.0;

        static public double ValorFinal(double c, double v)
        {
            return c * v + ((Iof/100) * (c*v));
        }
    }
}
