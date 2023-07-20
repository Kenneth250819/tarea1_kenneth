using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calcu
    {
        public double sumar(double x, double y)
        {
            return x + y;
        }

        public double restar(double x, double y)
        {
            return x - y;
        }

        public double multiplicar(double x, double y)
        {
            return x * y;
        }

        public double dividir(double x, double y)
        {
            try
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir entre cero.");
                return 0;
            }
        }
    }
}