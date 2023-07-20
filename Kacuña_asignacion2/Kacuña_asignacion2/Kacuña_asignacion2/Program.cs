using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Kacuña_asignacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadProduc = 0;
            string[] nombreProduc = new string[CantidadProduc];
            decimal[] precioProduc = new decimal[CantidadProduc];
            int[] cantidades = new int[CantidadProduc];
            decimal[] ventas = new decimal[CantidadProduc];
            bool salir = false;
            while (!salir)
            {
                if (CantidadProduc == 0)
                {
                    Console.WriteLine("Ingrese la cantidad de productos para el inventario: ");
                    CantidadProduc = int.Parse(Console.ReadLine());

                    nombreProduc = new string[CantidadProduc];
                    precioProduc = new decimal[CantidadProduc];
                    cantidades = new int[CantidadProduc];
                    ventas = new decimal[CantidadProduc];
                }
                else
                {
                    Console.WriteLine("------Menu Principal-------");
                    Console.WriteLine();
                    Console.WriteLine("1. Agregar un producto al inventario y precio. ");
                    Console.WriteLine("2. Mostrar la lista de productos disponibles. ");
                    Console.WriteLine("3. Realizar una venta.");
                    Console.WriteLine("4. Mostrar el reporte de ventas.");
                    Console.WriteLine("5. Salir del programa.");
                    


                    string opcion = (Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case "1":

                            Console.WriteLine("Que productos desea agregar al inventario: ");
                            for (int i = 0; i < CantidadProduc; i++)
                            {
                                Console.WriteLine("Ingrese el nombre del producto {0}:", i + 1);
                                nombreProduc[i] = Console.ReadLine();

                                Console.WriteLine("Ingrese el precio del producto {0}:", i + 1 );
                                precioProduc[i] = decimal.Parse(Console.ReadLine());

                                Console.WriteLine("Ingrese la cantidad del producto {0}:", i + 1);
                                cantidades[i] = int.Parse(Console.ReadLine());

                            }

                            break;
                        case "2":
                            Console.WriteLine("Mostrando lista de productos: ");
                            foreach (string elemento in nombreProduc)
                            {
                                Console.WriteLine(elemento);
                            }
                            break;
                        case "3":
                            Console.WriteLine("Realizar una venta: ");
                            Console.WriteLine("Seleccione el producto a vender por el numero indicado en pantalla :");
                            for (int i = 0; i < CantidadProduc; i++)
                            {
                                Console.WriteLine("{0}. {1}", i + 1, nombreProduc[i]);
                            }
                            
                            int productoSeleccionado = int.Parse(Console.ReadLine()) - 1;

                            if (productoSeleccionado >= 0 && productoSeleccionado < CantidadProduc)
                            {
                                bool ventaValida = true;
                                while(ventaValida)
                                    {
                                    try
                                    {
                                        Console.WriteLine("Ingrese la cantidad a vender:");
                                        int cantidadVenta = int.Parse(Console.ReadLine());
                                        if (cantidadVenta > 0)
                                        {
                                            
                                            if (cantidadVenta <= cantidades[productoSeleccionado])
                                            {
                                                cantidades[productoSeleccionado] -= cantidadVenta;
                                                decimal precioVenta = precioProduc[productoSeleccionado] * cantidadVenta;
                                                ventas[productoSeleccionado] += precioVenta;
                                                Console.WriteLine("Venta realizada exitosamente.");
                                                Console.WriteLine("Monto obtenido: {1}", precioVenta);
                                                ventaValida = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("No hay suficiente cantidad disponible para vender.");
                                                foreach(int elemento in cantidades)
                                                {
                                                    Console.WriteLine("La cantidad disponibles es: ");
                                                    Console.WriteLine(elemento);
                                                }
                                                ventaValida = true;
                                            }
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Cero no es valido para realizar la venta. ");
                                        ventaValida = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Número de producto inválido.");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Mostrando el reporte de ventas: ");
                            for (int i = 0; i < CantidadProduc; i++)
                            {
                                Console.WriteLine("Producto: {0}", nombreProduc[i]);
                                Console.WriteLine("Cantidad vendida: {0}", cantidades[i]);
                                Console.WriteLine("Ventas totales: {0}", ventas[i]);
                                Console.WriteLine();
                            }
                            break;
                        case "5":
                            Console.WriteLine("-----Programa cerrado exitosamente-----");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Número incorrecto. Intente otra vez. ");
                            break;  
                    }



                }

             }

        }
    }
}
