using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operaciones
    {
        double resultado = 0;

        public Operaciones() 
        {

        }    
        public double suma(double val1, double val2)
        {
            try
            {
                resultado = val1 + val2;
                return resultado;
            }
            catch
            {
                return resultado;
            }
        }
      
    }
}
