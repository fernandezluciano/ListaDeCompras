using System;
using System.Collections.Generic;

namespace ListaDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            List<string> listaDeCompras = new List<string>();

            while(opcion != 5){
                Console.Clear();

                Console.WriteLine("\t\t\tLISTA DE COMPRAS");
                Console.WriteLine(" --------- Desarrollado por Luciano Fernández © 2019 ---------");
                Console.WriteLine();
                Console.WriteLine("Menú:");
                Console.WriteLine("1: Agregar elemento");
                Console.WriteLine("2: Eliminar elemento");
                Console.WriteLine("3: Ver lista completa");
                Console.WriteLine("4: Vaciar la lista");
                Console.WriteLine("5: Salir");
                Console.WriteLine("Ingrese la opción de la operación que desea realizar:");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    default:
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("----------Agregar elementos----------");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el elemento que quiere agregar:");
                        string elementoAgregar = Console.ReadLine();
                        if (listaDeCompras.Contains(elementoAgregar))
                        {
                            Console.WriteLine($"El elemento {elementoAgregar} ya existe en la lista! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            listaDeCompras.Add(elementoAgregar);
                            Console.WriteLine($"Se agregó {elementoAgregar} a la lista! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        if (listaDeCompras.Count <= 0)
                        {
                            Console.WriteLine("La lista está vacía. No hay elementos para eliminar." + Environment.NewLine + "Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----------Eliminar elementos----------");
                            Console.WriteLine();
                            foreach (var elemento in listaDeCompras)
                            {
                                Console.WriteLine($"{listaDeCompras.IndexOf(elemento) + 1}: {elemento}");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Ingrese el número del elemento que quiere eliminar:");
                            int elementoEliminar = Convert.ToInt32(Console.ReadLine());
                            listaDeCompras.Remove(listaDeCompras[elementoEliminar - 1]);
                            Console.WriteLine("Se eliminó el elemento de la lista! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (listaDeCompras.Count <= 0)
                        {
                            Console.WriteLine("La lista está vacía! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----------Lista completa----------");
                            Console.WriteLine();
                            foreach (var elemento in listaDeCompras)
                            {
                                Console.WriteLine(elemento);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Presione la tecla enter para continuar");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        Console.Clear();
                        if(listaDeCompras.Count <= 0)
                        {
                            Console.WriteLine("La lista está vacía! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            listaDeCompras.Clear();
                            Console.WriteLine("Se ha vaciado la lista de compras! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}

