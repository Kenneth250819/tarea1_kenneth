using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[] calificaciones = { 85, 90, 76, 92, 88, 79 };

            int calificacionMasAlta = calificaciones[0];
            int calificacionMasBaja = calificaciones[0];

            for (int i = 1; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] > calificacionMasAlta)
                {
                    calificacionMasAlta = calificaciones[i];
                }

                if (calificaciones[i] < calificacionMasBaja)
                {
                    calificacionMasBaja = calificaciones[i];
                }
            }

            Console.WriteLine("La calificación más alta es: " + calificacionMasAlta);
            Console.WriteLine("La calificación más baja es: " + calificacionMasBaja);

        }
    }
}
