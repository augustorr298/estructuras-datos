using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class ArbolB
    {
        private NodoArbolB Raiz;

        public ArbolB()
        {
            Raiz = null;
        }

        public void Insertar(int dato)
        {
            NodoArbolB nuevoNodo = new NodoArbolB(dato);
            if (Raiz == null)
            {
                Raiz = nuevoNodo;
                Console.WriteLine("El nodo " + dato + " fue insertado como raíz");
            }
            else
            {
                NodoArbolB actual = Raiz;
                NodoArbolB padre = null;

                while (actual != null)
                {
                    padre = actual;
                    if (dato < actual.Dato)
                    {
                        actual = actual.izq;
                    }
                    else
                    {
                        if (dato > actual.Dato)
                        {
                            actual = actual.der;
                        }
                        else
                        {
                            Console.WriteLine("El dato " + dato +
                                " ya existe en el árbol y no fue insertado");

                        }
                    }
                }

                if(dato < padre.Dato)
                {
                    padre.izq = nuevoNodo;
                    Console.WriteLine("El dato " + dato +
                                " fue insertado a la izquierda de " +padre.Dato);
                }
                else
                {
                    padre.der = nuevoNodo;
                    Console.WriteLine("El dato " + dato +
                                " fue insertado a la derecha de " + padre.Dato);
                }
            }
        }

        public void Eliminar(int dato)
        {
            Raiz = Eliminar(Raiz, dato);
        }

        private NodoArbolB Eliminar(NodoArbolB Raiz, int dato)
        {
            if(Raiz == null)
            {
                Console.WriteLine("El dato " + dato + " no se encontro en el arbol");
                return null;
            }


            if(dato < Raiz.Dato)
            {
                Raiz.izq = Eliminar(Raiz.izq, dato);

            }else


            if (dato > Raiz.Dato)
            {
                Raiz.der = Eliminar(Raiz.der, dato);

            }
            else
            {
                if (Raiz == null)
                {
                    Console.WriteLine("El dato " + dato + " no se encontró en el árbol");
                    return null;
                }

                NodoArbolB NodoEliminar = Raiz;

                if(NodoEliminar.der == null)
                {
                    Console.WriteLine("El nodo " + dato + " se ha eliminado del lado derecho");
                    return NodoEliminar.izq;

                }
                else
                {
                    if (NodoEliminar.izq == null)
                    {
                        Console.WriteLine("El nodo " + dato +  "se ha eliminado del lado izquierdo");
                        return NodoEliminar.der;

                    }
                }

                NodoArbolB sucesor = Minimo(Raiz.der);
                Console.WriteLine("El nodo " + dato + " fue reemplazado por "
                    + sucesor.Dato);
                Raiz.Dato = sucesor.Dato;
                Raiz.der = Eliminar(Raiz.der, sucesor.Dato);

                  
            }

            return Raiz;

        }

    private NodoArbolB Minimo(NodoArbolB nodo)
        {
            while(nodo.izq != null)
            {
                nodo = nodo.izq;
            }

            return nodo;
        }

        public void Buscar(int dato)
        {
            if (Raiz == null)
            {
                Console.WriteLine("\nEl árbol está vacío");
                return;
            }

            BuscarRec(Raiz);
            

            void BuscarRec(NodoArbolB nodo)
            {
                if (nodo == null)
                {
                    Console.WriteLine("\nEl dato " + dato + " NO se encontró en el árbol");
                    return;
                }

                if (nodo.Dato == dato)
                {
                    Console.WriteLine("\nEl dato " + dato + " fue encontrado dentro del árbol");
                    return;
                }

                if (dato < nodo.Dato)
                    BuscarRec(nodo.izq);
                else
                    BuscarRec(nodo.der);
            }

            
            
        }

        public void ImprimirArbol()
        {
            if (Raiz == null)
            {
                Console.WriteLine("\nEl arbol esta vacio");
                return;
            }

            Console.WriteLine("\n--- Estructura del Arbol ---\n");
            ImprimirArbol(Raiz, "");
        }

        private void ImprimirArbol(NodoArbolB nodo, string espacios)
        {
            if (nodo == null)
            {
                return;
            }

            Console.WriteLine(espacios + nodo.Dato);

            if (nodo.der != null)
            {
                Console.WriteLine(espacios + " |");
                Console.Write(espacios + " |-Der: ");
                ImprimirArbol(nodo.der, espacios + " |    ");
            }

            if (nodo.izq != null)
            {
                Console.WriteLine(espacios + " |");
                Console.Write(espacios + " L-Izq: ");
                ImprimirArbol(nodo.izq, espacios + "      ");
            }
        }
    }

   
}
