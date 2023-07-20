using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenneth_asignacion1
{
    public class Program
    {
        static double NotaFinal(int NotaEscrita, int NotaActividades, int NotaProyecto1, int NotaPrueba)
        {
            double PorctEscrita = (NotaEscrita * 25 )/100;
            double PorctActividades = (NotaActividades * 25) / 100;
            double PorctProyecto1 = (NotaProyecto1 * 25) / 100;
            double PorctNotaPureba = (NotaPrueba * 25) / 100;
            double PorctTotal = (PorctNotaPureba + PorctEscrita + PorctActividades + PorctProyecto1);
            return PorctTotal;
        }

        static void Promedio(double[] calificacion)
        {
            double SumaCalificaciones = 0;
            for(int i = 0;i < calificacion.Length;i++)
            {
                SumaCalificaciones += calificacion[i];
            }
            SumaCalificaciones /= calificacion.Length;
            Console.WriteLine("El promedio de calificaciones es : " +  SumaCalificaciones);

        }

        static void CalificacionEstudiante(string[] estudiantes, double[] calificacion)
        {
            for (int i = 1; i <= estudiantes.Length; i++) 
            {
                Console.WriteLine(i + " . " + estudiantes[i - 1]);

            }
            int pos;
            Console.Write("Seleccione un estudiante : ");
            pos = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(" la calififcacion del estudiante seleccionado es : "+ calificacion[pos - 1]);
            
            

        }
        
        public static void Main(string[] args)
        
        {

            {
                int CantidadEst = 0;

                string[] estudiantes = new string[CantidadEst];

                int[] Escritas = new int[CantidadEst];
                int[] Actividades = new int[CantidadEst];
                int[] Proyecto1 = new int[CantidadEst];
                int[] Prueba = new int[CantidadEst];
                double[] calificacion = new double[CantidadEst];

                bool salir = false;

                while (!salir)
                {
                    if (CantidadEst == 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de estudiantes : ");
                        CantidadEst = int.Parse(Console.ReadLine());

                        estudiantes = new string[CantidadEst];
                        Escritas = new int[CantidadEst];
                        Actividades = new int[CantidadEst];
                        Proyecto1 = new int[CantidadEst];
                        Prueba = new int[CantidadEst];
                        calificacion = new double[CantidadEst];
                    }
                    else
                    {
                        Console.WriteLine("------Menu Principal-------");
                        Console.WriteLine("Note : Cantidad de estudiantes maxima : "+CantidadEst);
                        Console.WriteLine();
                        Console.WriteLine("1. Ingreso de Estudiantes y calificaciones.");
                        Console.WriteLine("2. Lista de estudiantes");
                        Console.WriteLine("3. Calificaciones finales de los estudiantes.");
                        Console.WriteLine("4. Mostrar calificacion mas alta y baja.");
                        Console.WriteLine("5. Mostrar estudiantes aprovados.");
                        Console.WriteLine("6. Mostrar estudiantes reprovados.");
                        Console.WriteLine("7. Modificar calificacion estudiante.");
                        Console.WriteLine("8. Salir.");


                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                                Console.WriteLine("Selecciono el Ingreso de estudiantes y calificaciones.");
                                for (int i = 0; i < CantidadEst; i++)
                                {
                                    Console.WriteLine("Ingrese el nombre del estudiante {0}:", i + 1);
                                    estudiantes[i] = Console.ReadLine();

                                    Console.WriteLine("Ingrese la calificaciones de Escritas valor 25% :", i);
                                    Escritas[i] = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese la calificaciones de Actividades valor 25% :", i);
                                    Actividades[i] = int.Parse(Console.ReadLine());


                                    Console.WriteLine("Ingrese la calificaciones de Poyecto 1 valor 25% :", i);
                                    Proyecto1[i] = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese la calificaciones de Prueba valor 25% :", i);
                                    Prueba[i] = int.Parse(Console.ReadLine());
                                    calificacion[i] = NotaFinal(Escritas[i], Actividades[i], Proyecto1[i], Prueba[i]);
                                }
                                break;
                            case "2":
                                Console.WriteLine("Lista de estudiantes.");
                                foreach (string elemento in estudiantes)
                                {
                                    Console.WriteLine(elemento);
                                }
                                break;
                            case "3":
                                Promedio(calificacion);

                                break;
                            case "4":
                                Console.WriteLine("Calificacion mas alta y baja");
                                double calificacionMasAlta = calificacion.Max();
                                double calificacionMasBaja = calificacion.Min();
                                Console.WriteLine("La calificación más alta es: " + calificacionMasAlta);
                                Console.WriteLine("La calificación más baja es: " + calificacionMasBaja);
                                break;
                            case "5":
                                Console.WriteLine("Estudiantes con calificaciones mayores o iguales a 60:");
                                int ContApro = 0;
                                int ContRepro = 0;
                                for (int i = 0; i < estudiantes.Length; i++)
                                {
                                    if (calificacion[i] >= 60)
                                    {
                                        ContApro++;
                                    }
                                    else 
                                    {
                                        ContRepro++;  
                                    }
                                }
                                Console.WriteLine("Cantidad de aprobados : "+ ContApro);
                                Console.WriteLine("Cantidad de reprobados : "+ ContRepro);
                                break;

                            case "6":
                                CalificacionEstudiante(estudiantes, calificacion);

                                break;
                            case "7":
                                Console.WriteLine("selecione el estuditante a modificar");
                                for (int i = 1; i <= estudiantes.Length; i++)
                                {
                                    Console.WriteLine(i + " . " + estudiantes[i - 1]);
                                };
                                int pos;
                                Console.Write("numero de estudiante : ");
                                pos = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                Console.Write("calificacion : ");
                                calificacion[pos - 1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Nueva calificacion : " + calificacion[pos - 1]);

                                break;
                            case "8":
                                Console.WriteLine("Saliendo del programa...");
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opcion Invalida");
                                break;
                        }

                        Console.WriteLine();

                    }

                }
                Console.WriteLine("--El programa ha terminado");
                Console.ReadKey();
            }   
        }   
    }
}
