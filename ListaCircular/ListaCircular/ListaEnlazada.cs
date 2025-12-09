using System;

namespace ListaCircular
{
    internal class ListaCircularEnlazada
    {
        private Nodo P;

        public ListaCircularEnlazada()
        {
            P = new Nodo();
            P.sig = P;
        }

        public void Recorrido()
        {
            if (P.sig == P)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Console.Write("Lista: [P] --> ");
                Nodo Q = P.sig;
                do
                {
                    Console.Write("[" + Q.Dato + "]");
                    Q = Q.sig;

                    if (Q != P)
                    {
                        Console.Write(" --> ");
                    }
                } while (Q != P);
                Console.WriteLine(" --> [P] (circular)");
            }
        }

        public void InsertarAlInicio(string dato)
        {
            Nodo Q = new Nodo(dato);
            Q.sig = P.sig;
            P.sig = Q;
            Console.WriteLine("Nodo '" + Q.Dato + "' insertado al inicio.");
        }

        public void InsertarAlFinal(string dato)
        {
            Nodo Q = P;
            while (Q.sig != P)
            {
                Q = Q.sig;
            }
            Nodo nuevo = new Nodo(dato);
            nuevo.sig = P;
            Q.sig = nuevo;
            Console.WriteLine("Nodo '" + dato + "' insertado al final.");
        }

        public void InsertarDespuesDe(string dato, string datoBuscado)
        {
            Nodo Q = P.sig;
            while (Q != P && Q.Dato != datoBuscado)
            {
                Q = Q.sig;
            }

            if (Q != P)
            {
                Nodo NuevoNodo = new Nodo(dato);
                NuevoNodo.sig = Q.sig;
                Q.sig = NuevoNodo;
                Console.WriteLine("Nodo '" + dato + "' insertado después del nodo '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo '" + datoBuscado + "'.");
            }
        }

        public void EliminarPrimerNodo()
        {
            if (P.sig == P)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Console.WriteLine("El nodo '" + P.sig.Dato + "' fue eliminado.");
                P.sig = P.sig.sig;
            }
        }

        public void EliminarUltimoNodo()
        {
            if (P.sig == P)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Nodo Q = P;
                while (Q.sig.sig != P)
                {
                    Q = Q.sig;
                }
                Console.WriteLine("El nodo '" + Q.sig.Dato + "' fue eliminado.");
                Q.sig = P;
            }
        }

        public void EliminarNodoPorDato(string datoBuscado)
        {
            if (P.sig == P)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Nodo Q = P;
                while (Q.sig != P && Q.sig.Dato != datoBuscado)
                {
                    Q = Q.sig;
                }
                if (Q.sig != P)
                {
                    Console.WriteLine("El nodo '" + datoBuscado + "' fue eliminado.");
                    Q.sig = Q.sig.sig;
                }
                else
                {
                    Console.WriteLine("No se encontró el dato '" + datoBuscado + "'.");
                }
            }
        }

        public void BuscarNodo(string datoBuscado)
        {
            if (P.sig == P)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Nodo Q = P.sig;
                bool encontrado = false;
                int posicion = 1;

                while (Q != P)
                {
                    if (Q.Dato == datoBuscado)
                    {
                        encontrado = true;
                        Console.WriteLine("Nodo '" + datoBuscado + "' encontrado en la posición " + posicion + ".");
                    }
                    Q = Q.sig;
                    posicion++;
                }

                if (!encontrado)
                {
                    Console.WriteLine("El dato '" + datoBuscado + "' no se encontró en la lista.");
                }
            }
        }
    }
}
