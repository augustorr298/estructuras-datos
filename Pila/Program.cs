using System;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pila Estática
            int tope = -1;
            int dato, i, opcion, max = 10;
            int[] pila = new int[10];

            do
            {
                Console.WriteLine("\n--- PILA ESTÁTICA ---");
                Console.WriteLine("1. Push (Apilar)");
                Console.WriteLine("2. Pop (Desapilar)");
                Console.WriteLine("3. Peek (Consultar tope)");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Imprimir");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Push - Apilar
                        if (tope == max - 1)
                        {
                            Console.WriteLine("Pila llena (Stack Overflow)");
                        }
                        else
                        {
                            Console.Write("Ingrese dato: ");
                            dato = int.Parse(Console.ReadLine());
                            tope++;
                            pila[tope] = dato;
                            Console.WriteLine("Dato apilado en posición " + tope);
                        }
                        break;

                    case 2: // Pop - Desapilar
                        if (tope == -1)
                        {
                            Console.WriteLine("Pila vacía (Stack Underflow)");
                        }
                        else
                        {
                            Console.WriteLine("Dato desapilado: " + pila[tope]);
                            pila[tope] = 0;
                            tope--;
                        }
                        break;

                    case 3: // Peek - Consultar tope
                        if (tope == -1)
                        {
                            Console.WriteLine("Pila vacía");
                        }
                        else
                        {
                            Console.WriteLine("Tope de la pila: " + pila[tope]);
                        }
                        break;

                    case 4: // Buscar
                        if (tope == -1)
                        {
                            Console.WriteLine("Pila vacía");
                        }
                        else
                        {
                            Console.Write("Ingrese dato a buscar: ");
                            dato = int.Parse(Console.ReadLine());
                            int pos = -1;
                            for (i = tope; i >= 0; i--)
                            {
                                if (pila[i] == dato)
                                {
                                    pos = i;
                                    break;
                                }
                            }
                            if (pos != -1)
                            {
                                Console.WriteLine("Dato encontrado en posición " + pos);
                            }
                            else
                            {
                                Console.WriteLine("Dato no encontrado");
                            }
                        }
                        break;

                    case 5: // Imprimir
                        Console.WriteLine("Estado de la pila (tope=" + tope + "):");
                        if (tope == -1)
                        {
                            Console.WriteLine("[ Pila vacía ]");
                        }
                        else
                        {
                            Console.WriteLine("--- Tope ---");
                            for (i = tope; i >= 0; i--)
                            {
                                Console.WriteLine("| " + pila[i] + " | [" + i + "]");
                            }
                            Console.WriteLine("--- Base ---");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion != 6);
        }
    }
}