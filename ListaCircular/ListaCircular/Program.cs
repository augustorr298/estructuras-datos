using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaCircularEnlazada miLista = new ListaCircularEnlazada();
            int opcion;

            Console.WriteLine("LISTA CIRCULAR ENLAZADA");
            Console.WriteLine("================================================\n");

            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("       MENÚ");
                Console.WriteLine("====================");
                
                Console.WriteLine("\nINSERCIÓN:");
                Console.WriteLine("1. Insertar al inicio");
                Console.WriteLine("2. Insertar al final");
                Console.WriteLine("3. Insertar después de un dato");
                
                Console.WriteLine("\nELIMINACIÓN:");
                Console.WriteLine("4. Eliminar el primer nodo");
                Console.WriteLine("5. Eliminar el último nodo");
                Console.WriteLine("6. Eliminar por dato");
                
                Console.WriteLine("\nBÚSQUEDA Y RECORRIDO:");
                Console.WriteLine("7. Buscar nodo");
                Console.WriteLine("8. Recorrido");
                
                Console.WriteLine("\n0. Salir");

                Console.Write("\nIngrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                string dato, datoBuscado;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese dato: ");
                        dato = Console.ReadLine();
                        miLista.InsertarAlInicio(dato);
                        break;

                    case 2:
                        Console.Write("Ingrese dato: ");
                        dato = Console.ReadLine();
                        miLista.InsertarAlFinal(dato);
                        break;

                    case 3:
                        Console.Write("Ingrese nuevo dato: ");
                        dato = Console.ReadLine();
                        Console.Write("Ingrese dato de referencia: ");
                        datoBuscado = Console.ReadLine();
                        miLista.InsertarDespuesDe(dato, datoBuscado);
                        break;

                    case 4:
                        miLista.EliminarPrimerNodo();
                        break;

                    case 5:
                        miLista.EliminarUltimoNodo();
                        break;

                    case 6:
                        Console.Write("Ingrese dato del nodo a eliminar: ");
                        datoBuscado = Console.ReadLine();
                        miLista.EliminarNodoPorDato(datoBuscado);
                        break;

                    case 7:
                        Console.Write("Ingrese dato a buscar: ");
                        datoBuscado = Console.ReadLine();
                        miLista.BuscarNodo(datoBuscado);
                        break;

                    case 8:
                        Console.WriteLine("\n--- Recorrido ---");
                        miLista.Recorrido();
                        break;

                    case 0:
                        Console.WriteLine("\nPrograma finalizado.");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                        break;
                }

                // Mostrar la lista actual después de cada operación (excepto salir)
                if (opcion != 0)
                {
                    Console.WriteLine("\n--- Estado actual de la lista ---");
                    miLista.Recorrido();
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 0);
        }
    }
}
