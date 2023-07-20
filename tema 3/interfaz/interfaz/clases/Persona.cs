using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz.clases
{
    internal class Persona
    {

		private string nombre;
		private string apellido;
		private int edad;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}


		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

        //constructores
        public Persona()
        {
             


        }




    }
}
