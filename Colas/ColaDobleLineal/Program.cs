// Cola Doble Lineal Estática
// Cola 1: crece hacia la derecha (desde 0)
// Cola 2: crece hacia la izquierda (desde max-1)

int frente1 = -1, final1 = -1;  // Cola 1
int frente2 = -1, final2 = -1;  // Cola 2
int dato, opcion, max = 10;
int[] cola = new int[10];

do
{
    Console.WriteLine("\n-- COLA DOBLE LINEAL ESTÁTICA --");
    Console.WriteLine("Cola 1 (→ frente)  |  Cola 2 (← atrás)");
    Console.WriteLine("1. Encolar desde el Frente (Cola 1)");
    Console.WriteLine("2. Encolar desde Atrás (Cola 2)");
    Console.WriteLine("3. Desencolar Cola 1 (izquierda)");
    Console.WriteLine("4. Desencolar Cola 2 (derecha)");
    Console.WriteLine("5. Buscar");
    Console.WriteLine("6. Imprimir cola");
    Console.WriteLine("7. Salir");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: // Encolar desde el Frente - Cola 1 (crece →)
            if (frente1 == -1)
            {
                frente1 = 0;
                final1 = 0;
                Console.Write("Ingrese dato: ");
                dato = int.Parse(Console.ReadLine());
                cola[final1] = dato;
                Console.WriteLine("Dato encolado en Cola 1, posición " + final1);
            }
            else
            {
                int nuevoFinal1 = final1 + 1;
                
                if (frente2 != -1 && nuevoFinal1 >= final2)
                {
                    Console.WriteLine("No hay espacio - Colisión con Cola 2");
                }
                else if (nuevoFinal1 >= max)
                {
                    Console.WriteLine("Cola 1 llena");
                }
                else
                {
                    Console.Write("Ingrese dato: ");
                    dato = int.Parse(Console.ReadLine());
                    final1 = nuevoFinal1;
                    cola[final1] = dato;
                    Console.WriteLine("Dato encolado en Cola 1, posición " + final1);
                }
            }
            break;

        case 2: // Encolar desde Atrás - Cola 2 (crece ←)
            if (frente2 == -1)
            {
                frente2 = max - 1;
                final2 = max - 1;
                Console.Write("Ingrese dato: ");
                dato = int.Parse(Console.ReadLine());
                cola[final2] = dato;
                Console.WriteLine("Dato encolado en Cola 2, posición " + final2);
            }
            else
            {
                int nuevoFinal2 = final2 - 1;
                
                if (frente1 != -1 && nuevoFinal2 <= final1)
                {
                    Console.WriteLine("No hay espacio - Colisión con Cola 1");
                }
                else if (nuevoFinal2 < 0)
                {
                    Console.WriteLine("Cola 2 llena");
                }
                else
                {
                    Console.Write("Ingrese dato: ");
                    dato = int.Parse(Console.ReadLine());
                    final2 = nuevoFinal2;
                    cola[final2] = dato;
                    Console.WriteLine("Dato encolado en Cola 2, posición " + final2);
                }
            }
            break;

        case 3: // Desencolar Cola 1 (izquierda)
            if (frente1 == -1)
            {
                Console.WriteLine("Cola 1 vacía");
            }
            else
            {
                Console.WriteLine("Dato desencolado de Cola 1: " + cola[frente1]);
                cola[frente1] = 0;
                
                if (frente1 == final1)
                {
                    frente1 = -1;
                    final1 = -1;
                }
                else
                {
                    frente1++;
                }
            }
            break;

        case 4: // Desencolar Cola 2 (derecha)
            if (frente2 == -1)
            {
                Console.WriteLine("Cola 2 vacía");
            }
            else
            {
                Console.WriteLine("Dato desencolado de Cola 2: " + cola[frente2]);
                cola[frente2] = 0;
                
                if (frente2 == final2)
                {
                    frente2 = -1;
                    final2 = -1;
                }
                else
                {
                    frente2--;
                }
            }
            break;

        case 5: // Buscar
            Console.Write("Ingrese dato a buscar: ");
            dato = int.Parse(Console.ReadLine());
            bool encontrado = false;
            
            // Buscar en Cola 1
            if (frente1 != -1)
            {
                for (int i = frente1; i <= final1; i++)
                {
                    if (cola[i] == dato)
                    {
                        Console.WriteLine("Encontrado en Cola 1, posición " + i);
                        encontrado = true;
                        break;
                    }
                }
            }
            
            // Buscar en Cola 2
            if (!encontrado && frente2 != -1)
            {
                for (int i = frente2; i >= final2; i--)
                {
                    if (cola[i] == dato)
                    {
                        Console.WriteLine("Encontrado en Cola 2, posición " + i);
                        encontrado = true;
                        break;
                    }
                }
            }
            
            if (!encontrado)
            {
                Console.WriteLine("Dato no encontrado en ninguna cola");
            }
            break;

        case 6: // Imprimir cola
            Console.WriteLine("Cola 1: frente1=" + frente1 + ", final1=" + final1);
            Console.WriteLine("Cola 2: frente2=" + frente2 + ", final2=" + final2);
            Console.Write("Arreglo: ");
            for (int j = 0; j < max; j++)
            {
                Console.Write("|" + cola[j] + "|");
            }
            Console.WriteLine();
            break;

        case 7:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción no válida");
            break;
    }
} while (opcion != 7);