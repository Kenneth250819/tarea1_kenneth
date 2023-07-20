using interfaz.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona();
            Console.WriteLine(" Ingresa tu edad ");
            try
            {
                pers.Edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            //if(pers.edad < 0 ) 
           // {
              //  Console.WriteLine(" Edad no valida");
           // }
           Console.ReadKey();

        }
    }
}
