using System;

namespace ListaDobleCircular
{
    internal class ListaDobleCircular
    {
        private Nodo cabecera;

        public ListaDobleCircular()
        {
            cabecera = new Nodo();
            cabecera.sig = cabecera;
            cabecera.ant = cabecera;
        }

        public void RecorridoDerecha()
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.Write("Lista (derecha): [CAB] <--> ");
            Nodo Q = cabecera.sig;
            
            while (Q != cabecera)
            {
                Console.Write("[" + Q.Dato + "]");
                Q = Q.sig;
                
                if (Q != cabecera)
                    Console.Write(" <--> ");
            }
            Console.WriteLine(" <--> [CAB] (circular)");
        }

        public void RecorridoIzquierda()
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.Write("Lista (izquierda): [CAB] <--> ");
            Nodo Q = cabecera.ant;
            
            while (Q != cabecera)
            {
                Console.Write("[" + Q.Dato + "]");
                Q = Q.ant;
                
                if (Q != cabecera)
                    Console.Write(" <--> ");
            }
            Console.WriteLine(" <--> [CAB] (circular)");
        }

        public void MostrarEstructura()
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("Lista vacía: [CAB] <--> [CAB]");
                return;
            }

            RecorridoDerecha();
        }

        public void InsertarInicio(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            
            Nodo primerActual = cabecera.sig;
            
            // Conectar nuevo nodo
            nuevoNodo.sig = primerActual;
            nuevoNodo.ant = cabecera;
            
            // Actualizar conexiones existentes
            cabecera.sig = nuevoNodo;
            primerActual.ant = nuevoNodo;

            Console.WriteLine("Nodo '" + dato + "' insertado al inicio.");
            MostrarEstructura();
        }

          public void InsertarFinal(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            
            Nodo ultimoActual = cabecera.ant;
            
            // Conectar nuevo nodo
            nuevoNodo.sig = cabecera;
            nuevoNodo.ant = ultimoActual;
            
            // Actualizar conexiones existentes
            ultimoActual.sig = nuevoNodo;
            cabecera.ant = nuevoNodo;

            Console.WriteLine("Nodo '" + dato + "' insertado al final.");
            MostrarEstructura();
        }

    
        public void InsertarDespuesDe(string dato, string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;

            // Buscar el nodo de referencia (recorrido circular)
            while (Q != cabecera && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q != cabecera)
            {
                Nodo nuevoNodo = new Nodo(dato);
                Nodo siguiente = Q.sig;
                
                nuevoNodo.sig = siguiente;
                nuevoNodo.ant = Q;
                
                Q.sig = nuevoNodo;
                siguiente.ant = nuevoNodo;

                Console.WriteLine("Nodo '" + dato + "' insertado después de '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }

            MostrarEstructura();
        }

        // Inserta un nodo antes de un dato específico
        public void InsertarAntesDe(string dato, string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;

            // Buscar el nodo de referencia
            while (Q != cabecera && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q != cabecera)
            {
                Nodo nuevoNodo = new Nodo(dato);
                Nodo anterior = Q.ant;

                nuevoNodo.sig = Q;
                nuevoNodo.ant = anterior;

                anterior.sig = nuevoNodo;
                Q.ant = nuevoNodo;

                Console.WriteLine("Nodo '" + dato + "' insertado antes de '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }

            MostrarEstructura();
        }

       
        // Elimina el primer nodo después de la cabecera
        public void EliminarPrimero()
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
                return;
            }

            Nodo nodoEliminar = cabecera.sig;
            Nodo segundoNodo = nodoEliminar.sig;

            cabecera.sig = segundoNodo;
            segundoNodo.ant = cabecera;

            Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado del inicio.");
            MostrarEstructura();
        }

        // Elimina el último nodo (antes de la cabecera)
        public void EliminarUltimo()
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
                return;
            }

            Nodo nodoEliminar = cabecera.ant;
            Nodo penultimoNodo = nodoEliminar.ant;

            penultimoNodo.sig = cabecera;
            cabecera.ant = penultimoNodo;

            Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado del final.");
            MostrarEstructura();
        }

        // Elimina un nodo por su dato
        public void EliminarPorDato(string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
                return;
            }

            Nodo Q = cabecera.sig;

            // Buscar el nodo 
            while (Q != cabecera && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q != cabecera)
            {
                Nodo anterior = Q.ant;
                Nodo siguiente = Q.sig;

                anterior.sig = siguiente;
                siguiente.ant = anterior;

                Console.WriteLine("Nodo '" + datoBuscado + "' eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo '" + datoBuscado + "'.");
            }

            MostrarEstructura();
        }

        // Elimina el nodo anterior a un dato 
        public void EliminarAntesDe(string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;

            // Buscar el nodo de referencia
            while (Q != cabecera && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q == cabecera)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.ant == cabecera)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el primero. No hay nodo antes (solo la cabecera).");
            }
            else
            {
                Nodo nodoEliminar = Q.ant;
                Nodo anterior = nodoEliminar.ant;

                anterior.sig = Q;
                Q.ant = anterior;

                Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado (estaba antes de '" + datoBuscado + "').");
            }

            MostrarEstructura();
        }

        // Elimina el nodo después de un dato 
        public void EliminarDespuesDe(string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;

            // Buscar el nodo de referencia
            while (Q != cabecera && Q.Dato != datoBuscado)
                Q = Q.sig;

            if (Q == cabecera)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.sig == cabecera)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el último. No hay nodo después (solo la cabecera).");
            }
            else
            {
                Nodo nodoEliminar = Q.sig;
                Nodo siguiente = nodoEliminar.sig;

                Q.sig = siguiente;
                siguiente.ant = Q;

                Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado (estaba después de '" + datoBuscado + "').");
            }

            MostrarEstructura();
        }

        public void BuscarNodo(string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;
            int posicion = 1;
            bool encontrado = false;

            while (Q != cabecera)
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
                Console.WriteLine("Nodo '" + datoBuscado + "' no encontrado en la lista.");
            }

            RecorridoDerecha();
        }

        // Busca el nodo anterior a un dato específico
        public void BuscarNodoAnterior(string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;
            int posicion = 1;

            while (Q != cabecera && Q.Dato != datoBuscado)
            {
                Q = Q.sig;
                posicion++;
            }

            if (Q == cabecera)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.ant == cabecera)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el primero. Su anterior es la CABECERA.");
            }
            else
            {
                Console.WriteLine("El nodo anterior a '" + datoBuscado + "' es '" + Q.ant.Dato + "' en la posición " + (posicion - 1) + ".");
            }

            RecorridoDerecha();
        }

        // Busca el nodo siguiente a un dato específico
        public void BuscarNodoSiguiente(string datoBuscado)
        {
            if (cabecera.sig == cabecera)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo Q = cabecera.sig;
            int posicion = 1;

            while (Q != cabecera && Q.Dato != datoBuscado)
            {
                Q = Q.sig;
                posicion++;
            }

            if (Q == cabecera)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.sig == cabecera)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el último. Su siguiente es la CABECERA (circular).");
            }
            else
            {
                Console.WriteLine("El nodo siguiente a '" + datoBuscado + "' es '" + Q.sig.Dato + "' en la posición " + (posicion + 1) + ".");
            }

            RecorridoDerecha();
        }

       
    }
}

