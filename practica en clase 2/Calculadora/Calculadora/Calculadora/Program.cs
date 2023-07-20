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
            Console.WriteLine(" Calculadora ");

            Calcu calcu = new Calcu();


            while(true)
            {
                Console.WriteLine("Elija que operacion quiere realizar");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. division ");
                Console.WriteLine("5. Salir ");


                Console.Write("Opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    Console.WriteLine("Gracias por usar la Calculadora.");
                    break;
                }

                Console.Write("Digite el primer número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite el segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = calcu.sumar(numero1, numero2);
                        break;
                    case 2:
                        resultado = calcu.restar(numero1, numero2);
                        break;
                    case 3:
                        resultado = calcu.multiplicar(numero1, numero2);
                        break;
                    case 4:
                        resultado = calcu.dividir(numero1, numero2);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Elija una opción válida.");
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);
                Console.WriteLine();
            }

        }
    }
}
