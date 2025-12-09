using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolB arbol = new ArbolB();
            bool salir = false;
            while (!salir)
            {
                //Console.Clear();//Limpiar consola
                Console.WriteLine("***************************************");
                Console.WriteLine("******* MENÚ DE ARBOL BINARIO ********");
                Console.WriteLine("**************************************");
                Console.WriteLine("OPERACIONES");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese opción: ");
                string opcion = Console.ReadLine();
                string dato;

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese dato: ");
                        dato = Console.ReadLine();
                        arbol.Insertar(int.Parse(dato));
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el dato a eliminar: ");
                        dato = Console.ReadLine();
                        arbol.Eliminar(int.Parse(dato));
                        break;

                    case "3":
                        Console.WriteLine("Ingrese dato: ");
                        dato = Console.ReadLine();
                        arbol.Buscar(int.Parse(dato));
                        break;

                    
                    case "0":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }
        }
    }
}
