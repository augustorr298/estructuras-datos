using System;

namespace ListaLineal
{
    internal class ListaEnlazada
    {
        private Nodo P;

        public ListaEnlazada()
        {
            P = new Nodo();
        }

        public void Recorrido()
        {
            if (P.sig == null)
            {
                Console.WriteLine("Lista vacía.");
                return;
            }

            Console.Write("Lista: [P] --> ");
            Nodo Q = P.sig;
            
            while (Q != null)
            {
                Console.Write("[" + Q.Dato + "]");
                Q = Q.sig;

                if (Q != null)
                    Console.Write(" --> ");
            }
            Console.WriteLine(" --> NULL");
        }

        public void InsertarAlInicio(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            nuevoNodo.sig = P.sig;
            P.sig = nuevoNodo;
            
            Console.WriteLine("Nodo '" + dato + "' insertado al inicio.");
        }

        public void InsertarAlFinal(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            
            Nodo Q = P;
            while (Q.sig != null)
            {
                Q = Q.sig;
            }
            
            Q.sig = nuevoNodo;
            
            Console.WriteLine("Nodo '" + dato + "' insertado al final.");
        }

        public void InsertarDespuesDe(string dato, string datoBuscado)
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = P.sig;

            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q != null)
            {
                Nodo nuevoNodo = new Nodo(dato);
                nuevoNodo.sig = Q.sig;
                Q.sig = nuevoNodo;

                Console.WriteLine("Nodo '" + dato + "' insertado después de '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }

            Recorrido();
        }

        public void InsertarAntesDe(string dato, string datoBuscado)
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo anterior = P;
            Nodo Q = P.sig;

            while (Q != null && Q.Dato != datoBuscado)
            {
                anterior = Q;
                Q = Q.sig;
            }

            if (Q != null)
            {
                Nodo nuevoNodo = new Nodo(dato);
                nuevoNodo.sig = Q;
                anterior.sig = nuevoNodo;

                Console.WriteLine("Nodo '" + dato + "' insertado antes de '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
        }

        public void EliminarPrimerNodo()
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
                return;
            }

            Nodo nodoEliminar = P.sig;
            P.sig = nodoEliminar.sig;

            Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado del inicio.");
        }

        // Elimina el último nodo de la lista
        public void EliminarUltimoNodo()
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
                return;
            }

            Nodo Q = P;
            while (Q.sig != null && Q.sig.sig != null)
                Q = Q.sig;

            string datoEliminado = Q.sig.Dato;
            Q.sig = null;

            Console.WriteLine("Nodo '" + datoEliminado + "' eliminado del final.");
            Recorrido();
        }

        public void EliminarNodoPorDato(string datoBuscado)
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
                return;
            }

            Nodo anterior = P;
            Nodo Q = P.sig;

            while (Q != null && Q.Dato != datoBuscado)
            {
                anterior = Q;
                Q = Q.sig;
            }

            if (Q != null)
            {
                anterior.sig = Q.sig;
                Console.WriteLine("Nodo '" + datoBuscado + "' eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo '" + datoBuscado + "'.");
            }

            Recorrido();
        }

        public void EliminarDespuesDe(string datoBuscado)
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = P.sig;

            // Buscar el nodo de referencia
            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q == null)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.sig == null)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el último. No hay nodo después para eliminar.");
            }
            else
            {
                Nodo nodoEliminar = Q.sig;
                Q.sig = nodoEliminar.sig;
                Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado (estaba después de '" + datoBuscado + "').");
            }
        }

        public void BuscarNodo(string datoBuscado)
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = P.sig;
            int posicion = 1;
            bool encontrado = false;

            while (Q != null)
            {
                if (Q.Dato == datoBuscado)
                {
                    Console.WriteLine("Nodo '" + datoBuscado + "' encontrado en la posición " + posicion + ".");
                    encontrado = true;
                    break;
                }
                Q = Q.sig;
                posicion++;
            }

            if (!encontrado)
            {
                Console.WriteLine("El dato '" + datoBuscado + "' no se encontró en la lista.");
            }
        }

        public void BuscarNodoSiguiente(string datoBuscado)
        {
            if (P.sig == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = P.sig;
            int posicion = 1;

            while (Q != null && Q.Dato != datoBuscado)
            {
                Q = Q.sig;
                posicion++;
            }

            if (Q == null)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.sig == null)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el último. No tiene nodo siguiente (NULL).");
            }
            else
            {
                Console.WriteLine("El nodo siguiente a '" + datoBuscado + "' es '" + Q.sig.Dato + "' en la posición " + (posicion + 1) + ".");
            }
        }
    }
}
