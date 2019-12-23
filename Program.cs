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

                Console.WriteLine("Lista de compras");
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Agregar elemento");
                Console.WriteLine("2: Eliminar elemento");
                Console.WriteLine("3: Ver lista completa");
                Console.WriteLine("4: Vaciar la lista");
                Console.WriteLine("5: Salir");
                Console.WriteLine("Ingrese la opcion de la operacion que desea realizar:");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    default:
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("----------Agregar elemento----------");
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
                            Console.WriteLine($"Se agrego {elementoAgregar} a la lista! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------Eliminar elemento----------");
                        Console.WriteLine();
                        if (listaDeCompras.Count <= 0)
                        {
                            Console.WriteLine("La lista esta vacia. No hay elemento para eliminar. Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            foreach (var elemento in listaDeCompras)
                            {
                                Console.WriteLine($"{listaDeCompras.IndexOf(elemento) + 1}: {elemento}");
                            }
                            Console.WriteLine("Ingrese el numero del elemento que quiere eliminar:");
                            int elementoEliminar = Convert.ToInt32(Console.ReadLine());
                            listaDeCompras.Remove(listaDeCompras[elementoEliminar - 1]);
                            Console.WriteLine("Se elimino el elemento de la lista! Presione la tecla enter para continuar.");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (listaDeCompras.Count <= 0)
                        {
                            Console.WriteLine("La lista esta vacia! Presione la tecla enter para continuar.");
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
                        if(listaDeCompras.Count <= 0)
                        {
                            Console.WriteLine("La lista esta vacia! Presione la tecla enter para continuar.");
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

