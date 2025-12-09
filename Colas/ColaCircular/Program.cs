// Cola Circular Estática

int frente = -1, final = -1, dato, i, opcion, max = 5;
int[] cola = new int[5];

do
{
    Console.WriteLine("\n-- COLA CIRCULAR ESTÁTICA --");
    Console.WriteLine("1. Encolar");
    Console.WriteLine("2. Desencolar");
    Console.WriteLine("3. Consultar");
    Console.WriteLine("4. Imprimir cola");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: // Encolar
            if ((final + 1 == frente) || (frente == 0 && final == max - 1))
            {
                Console.WriteLine("Cola llena");
            }
            else
            {
                Console.Write("Ingrese dato: ");
                dato = int.Parse(Console.ReadLine());
                
                if (final == max - 1)
                {
                    final = 0;
                }
                else
                {
                    final++;
                }
                
                cola[final] = dato;
                
                if (frente == -1)
                {
                    frente = 0;
                }
                Console.WriteLine("Dato encolado en posición " + final);
            }
            break;

        case 2: // Desencolar
            if (frente == -1)
            {
                Console.WriteLine("Cola vacía, no se puede eliminar");
            }
            else
            {
                Console.WriteLine("Dato desencolado: " + cola[frente]);
                cola[frente] = 0;
                
                if (frente == final)
                {
                    frente = -1;
                    final = -1;
                }
                else
                {
                    if (frente == max - 1)
                    {
                        frente = 0;
                    }
                    else
                    {
                        frente++;
                    }
                }
            }
            break;

        case 3: // Consultar
            if (frente == -1)
            {
                Console.WriteLine("Cola vacía");
            }
            else
            {
                Console.Write("Ingrese dato a buscar: ");
                dato = int.Parse(Console.ReadLine());
                bool encontrado = false;
                
                i = frente;
                do
                {
                    if (cola[i] == dato)
                    {
                        Console.WriteLine("Dato encontrado en posición " + i);
                        encontrado = true;
                        break;
                    }
                    
                    if (i == final) break;
                    
                    if (i == max - 1)
                        i = 0;
                    else
                        i++;
                        
                } while (true);
                
                if (!encontrado)
                {
                    Console.WriteLine("Dato no encontrado");
                }
            }
            break;

        case 4: // Imprimir cola
            Console.Write("Frente=" + frente + "\t");
            for (int j = 0; j < max; j++)
            {
                Console.Write("|" + cola[j] + "|");
            }
            Console.WriteLine("\tFinal=" + final);
            break;

        case 5:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción no válida");
            break;
    }
} while (opcion != 5);