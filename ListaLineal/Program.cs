using System;

namespace ListaLineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada miLista = new ListaEnlazada();
            int opcion;

            Console.WriteLine("LISTA ENLAZADA SIMPLE (LINEAL)");
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
                Console.WriteLine("4. Insertar antes de un dato");

                Console.WriteLine("\nELIMINACIÓN:");
                Console.WriteLine("5. Eliminar el primer nodo");
                Console.WriteLine("6. Eliminar el último nodo");
                Console.WriteLine("7. Eliminar por dato");
                Console.WriteLine("8. Eliminar después de un dato");

                Console.WriteLine("\nBÚSQUEDA:");
                Console.WriteLine("9. Buscar nodo");
                Console.WriteLine("10. Buscar nodo siguiente");

                Console.WriteLine("\nRECORRIDO:");
                Console.WriteLine("11. Mostrar lista");

                Console.WriteLine("\n0. Salir");

                Console.Write("\nIngrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                string dato, datoBuscado;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el dato a insertar: ");
                        dato = Console.ReadLine();
                        miLista.InsertarAlInicio(dato);
                        break;

                    case 2:
                        Console.Write("Ingrese el dato a insertar: ");
                        dato = Console.ReadLine();
                        miLista.InsertarAlFinal(dato);
                        break;

                    case 3:
                        Console.Write("Ingrese el nuevo dato: ");
                        dato = Console.ReadLine();
                        Console.Write("Insertar después de: ");
                        datoBuscado = Console.ReadLine();
                        miLista.InsertarDespuesDe(dato, datoBuscado);
                        break;

                    case 4:
                        Console.Write("Ingrese el nuevo dato: ");
                        dato = Console.ReadLine();
                        Console.Write("Insertar antes de: ");
                        datoBuscado = Console.ReadLine();
                        miLista.InsertarAntesDe(dato, datoBuscado);
                        break;

                    case 5:
                        miLista.EliminarPrimerNodo();
                        break;

                    case 6:
                        miLista.EliminarUltimoNodo();
                        break;

                    case 7:
                        Console.Write("Ingrese el dato del nodo a eliminar: ");
                        datoBuscado = Console.ReadLine();
                        miLista.EliminarNodoPorDato(datoBuscado);
                        break;

                    case 8:
                        Console.Write("Eliminar el nodo DESPUÉS de: ");
                        datoBuscado = Console.ReadLine();
                        miLista.EliminarDespuesDe(datoBuscado);
                        break;

                    case 9:
                        Console.Write("Ingrese el dato a buscar: ");
                        datoBuscado = Console.ReadLine();
                        miLista.BuscarNodo(datoBuscado);
                        break;

                    case 10:
                        Console.Write("Buscar nodo SIGUIENTE a: ");
                        datoBuscado = Console.ReadLine();
                        miLista.BuscarNodoSiguiente(datoBuscado);
                        break;

                    case 11:
                        Console.WriteLine("\n--- Recorrido de la lista ---");
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
