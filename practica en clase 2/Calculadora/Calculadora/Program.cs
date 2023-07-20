using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int numero = 0;

            //programa principal

            Console.WriteLine("Digite un numero para mostrar su tabla de multiplicar: ");

            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Tabla(i, numero);
            }

            Console.ReadKey();
        }

        static void Tabla(int x, int y)
        {
            int multiplicacion = 0;
            multiplicacion = x * y;
            Console.WriteLine(x + "*" + y + "=" + multiplicacion);
        }



    }
}
