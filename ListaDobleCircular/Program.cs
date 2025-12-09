using System;

namespace ListaDobleCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDobleCircular miLista = new ListaDobleCircular();
            int opcion;

            Console.WriteLine("LISTA DOBLEMENTE ENLAZADA CIRCULAR");
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
                Console.WriteLine("8. Eliminar antes de un dato");
                Console.WriteLine("9. Eliminar después de un dato");

                Console.WriteLine("\nBÚSQUEDA:");
                Console.WriteLine("10. Buscar nodo");
                Console.WriteLine("11. Buscar nodo anterior");
                Console.WriteLine("12. Buscar nodo siguiente");

                Console.WriteLine("\nRECORRIDOS:");
                Console.WriteLine("13. Recorrido a la derecha (sig)");
                Console.WriteLine("14. Recorrido a la izquierda (ant)");
                Console.WriteLine("15. Mostrar estructura");

                Console.WriteLine("\n0. Salir");

                Console.Write("\nIngrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                string dato, datoBuscado;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el dato a insertar: ");
                        dato = Console.ReadLine();
                        miLista.InsertarInicio(dato);
                        break;

                    case 2:
                        Console.Write("Ingrese el dato a insertar: ");
                        dato = Console.ReadLine();
                        miLista.InsertarFinal(dato);
                        break;

                    case 3:
                        Console.Write("Ingrese el nuevo dato: ");
                        dato = Console.ReadLine();
                        Console.Write("Insertar despues de: ");
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
                        miLista.EliminarPrimero();
                        break;

                    case 6:
                        miLista.EliminarUltimo();
                        break;

                    case 7:
                        Console.Write("Ingrese el dato del nodo a eliminar: ");
                        datoBuscado = Console.ReadLine();
                        miLista.EliminarPorDato(datoBuscado);
                        break;

                    case 8:
                        Console.Write("Eliminar el nodo ANTES de: ");
                        datoBuscado = Console.ReadLine();
                        miLista.EliminarAntesDe(datoBuscado);
                        break;

                    case 9:
                        Console.Write("Eliminar el nodo DESPUES de: ");
                        datoBuscado = Console.ReadLine();
                        miLista.EliminarDespuesDe(datoBuscado);
                        break;

                    case 10:
                        Console.Write("Ingrese el dato a buscar: ");
                        datoBuscado = Console.ReadLine();
                        miLista.BuscarNodo(datoBuscado);
                        break;

                    case 11:
                        Console.Write("Buscar nodo ANTERIOR a: ");
                        datoBuscado = Console.ReadLine();
                        miLista.BuscarNodoAnterior(datoBuscado);
                        break;

                    case 12:
                        Console.Write("Buscar nodo SIGUIENTE a: ");
                        datoBuscado = Console.ReadLine();
                        miLista.BuscarNodoSiguiente(datoBuscado);
                        break;

                    case 13:
                        Console.WriteLine("\n--- Recorrido a la DERECHA (usando sig) ---");
                        miLista.RecorridoDerecha();
                        break;

                    case 14:
                        Console.WriteLine("\n--- Recorrido a la IZQUIERDA (usando ant) ---");
                        miLista.RecorridoIzquierda();
                        break;

                    case 15:
                        miLista.MostrarEstructura();
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
                    miLista.RecorridoDerecha();
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 0);
        }
    }
}
