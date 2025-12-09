using System;

namespace ListaDobleLineal
{
    internal class ListaDobleEnlazada
    {
        private Nodo P;

        public ListaDobleEnlazada()
        {
            P = new Nodo();
        }

        public void RecorridoFrenteAFinal()
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Console.Write("Lista: [P] <--> ");
            Nodo Q = P.Sig;
            
            while (Q != null)
            {
                Console.Write("[" + Q.Dato + "]");
                
                if (Q.Sig != null)
                    Console.Write(" <--> ");
                
                Q = Q.Sig;
            }
            Console.WriteLine(" --> NULL");
        }

    public void RecorridoFinalAFrente()
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Nodo Q = P.Sig;
            while (Q.Sig != null)
            {
                Q = Q.Sig;
            }

            Console.Write("Lista (inversa): NULL <-- ");
            while (Q != P)
            {
                Console.Write("[" + Q.Dato + "]");
                
                if (Q.Ant != P)
                    Console.Write(" <--> ");
                
                Q = Q.Ant;
            }
            Console.WriteLine(" <--> [P]");
        }

        #region OPERACIONES DE INSERCIÓN

        // Inserta un nodo al inicio (después de la cabecera P)
        public void InsertarInicio(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            
            // El nuevo nodo apunta al que era el primero
            nuevoNodo.Sig = P.Sig;
            nuevoNodo.Ant = P;

            // Si había un nodo después de P, su anterior ahora es el nuevo
            if (P.Sig != null)
                P.Sig.Ant = nuevoNodo;

            // P ahora apunta al nuevo nodo
            P.Sig = nuevoNodo;

            Console.WriteLine("Nodo '" + dato + "' insertado al inicio.");
            RecorridoFrenteAFinal();
        }

        // Inserta un nodo al final de la lista
        public void InsertarFinal(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);

            // Buscar el último nodo
            Nodo Q = P;
            while (Q.Sig != null)
            {
                Q = Q.Sig;
            }

            // Insertar al final
            nuevoNodo.Ant = Q;
            nuevoNodo.Sig = null;
            Q.Sig = nuevoNodo;

            Console.WriteLine("Nodo '" + dato + "' insertado al final.");
            RecorridoFrenteAFinal();
        }

        // Inserta un nodo después de un dato específico
        public void InsertarDespuesDe(string dato, string datoBuscado)
        {
            Nodo Q = P.Sig;

            // Buscar el nodo de referencia
            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.Sig;

            if (Q != null)
            {
                Nodo nuevoNodo = new Nodo(dato);
                
                nuevoNodo.Sig = Q.Sig;
                nuevoNodo.Ant = Q;

                // Si hay un nodo después, actualizar su anterior
                if (Q.Sig != null)
                    Q.Sig.Ant = nuevoNodo;

                Q.Sig = nuevoNodo;

                Console.WriteLine("Nodo '" + dato + "' insertado después de '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }

            RecorridoFrenteAFinal();
        }

        // Inserta un nodo antes de un dato específico
        public void InsertarAntesDe(string dato, string datoBuscado)
        {
            Nodo Q = P.Sig;

            // Buscar el nodo de referencia
            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.Sig;

            if (Q != null)
            {
                Nodo nuevoNodo = new Nodo(dato);
                Nodo anterior = Q.Ant;

                nuevoNodo.Sig = Q;
                nuevoNodo.Ant = anterior;

                anterior.Sig = nuevoNodo;
                Q.Ant = nuevoNodo;

                Console.WriteLine("Nodo '" + dato + "' insertado antes de '" + datoBuscado + "'.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }

            RecorridoFrenteAFinal();
        }

        #endregion

        #region OPERACIONES DE ELIMINACIÓN

        // Elimina el primer nodo (después de la cabecera)
    public void EliminarPrimero()
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
            return;
        }            Nodo nodoEliminar = P.Sig;
            P.Sig = nodoEliminar.Sig;

            // Si hay un nodo después del eliminado, actualizar su anterior
            if (nodoEliminar.Sig != null)
                nodoEliminar.Sig.Ant = P;

            Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado del inicio.");
            RecorridoFrenteAFinal();
        }

        // Elimina el último nodo de la lista
    public void EliminarUltimo()
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
            return;
        }            // Buscar el penúltimo nodo
            Nodo Q = P;
            while (Q.Sig != null && Q.Sig.Sig != null)
                Q = Q.Sig;

            string datoEliminado = Q.Sig.Dato;
            Q.Sig = null;

            Console.WriteLine("Nodo '" + datoEliminado + "' eliminado del final.");
            RecorridoFrenteAFinal();
        }

        // Elimina un nodo por su dato
    public void EliminarPorDato(string datoBuscado)
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía. No hay nodos que eliminar.");
            return;
        }            Nodo Q = P.Sig;

            // Buscar el nodo a eliminar
            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.Sig;

            if (Q != null)
            {
                Nodo anterior = Q.Ant;
                anterior.Sig = Q.Sig;

                if (Q.Sig != null)
                    Q.Sig.Ant = anterior;

                Console.WriteLine("Nodo '" + datoBuscado + "' eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo '" + datoBuscado + "'.");
            }

            RecorridoFrenteAFinal();
        }

        // Elimina el nodo anterior a un dato específico
    public void EliminarAntesDe(string datoBuscado)
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Nodo Q = P.Sig;

            // Buscar el nodo de referencia
            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.Sig;

            if (Q == null)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.Ant == P)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el primero. No hay nodo antes para eliminar.");
            }
            else
            {
                Nodo nodoEliminar = Q.Ant;
                Nodo anterior = nodoEliminar.Ant;

                anterior.Sig = Q;
                Q.Ant = anterior;

                Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado (estaba antes de '" + datoBuscado + "').");
            }

            RecorridoFrenteAFinal();
        }

        // Elimina el nodo después de un dato específico
    public void EliminarDespuesDe(string datoBuscado)
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Nodo Q = P.Sig;

            // Buscar el nodo de referencia
            while (Q != null && Q.Dato != datoBuscado)
                Q = Q.Sig;

            if (Q == null)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.Sig == null)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el último. No hay nodo después para eliminar.");
            }
            else
            {
                Nodo nodoEliminar = Q.Sig;

                Q.Sig = nodoEliminar.Sig;

                if (nodoEliminar.Sig != null)
                    nodoEliminar.Sig.Ant = Q;

                Console.WriteLine("Nodo '" + nodoEliminar.Dato + "' eliminado (estaba después de '" + datoBuscado + "').");
            }

            RecorridoFrenteAFinal();
        }

        #endregion

        #region OPERACIONES DE BÚSQUEDA

        // Busca un nodo por su dato
    public void BuscarNodo(string datoBuscado)
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Nodo Q = P.Sig;
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
                Q = Q.Sig;
                posicion++;
            }

            if (!encontrado)
            {
                Console.WriteLine("Nodo '" + datoBuscado + "' no encontrado en la lista.");
            }

            RecorridoFrenteAFinal();
        }

        // Busca el nodo anterior a un dato específico
    public void BuscarNodoAnterior(string datoBuscado)
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Nodo Q = P.Sig;
            int posicion = 1;

            while (Q != null && Q.Dato != datoBuscado)
            {
                Q = Q.Sig;
                posicion++;
            }

            if (Q == null)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.Ant == P)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el primero. No tiene nodo anterior (solo la cabecera P).");
            }
            else
            {
                Console.WriteLine("El nodo anterior a '" + datoBuscado + "' es '" + Q.Ant.Dato + "' en la posición " + (posicion - 1) + ".");
            }

            RecorridoFrenteAFinal();
        }

        // Busca el nodo siguiente a un dato específico
    public void BuscarNodoSiguiente(string datoBuscado)
    {
        if (P.Sig == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }            Nodo Q = P.Sig;
            int posicion = 1;

            while (Q != null && Q.Dato != datoBuscado)
            {
                Q = Q.Sig;
                posicion++;
            }

            if (Q == null)
            {
                Console.WriteLine("No se encontró el nodo de referencia '" + datoBuscado + "'.");
            }
            else if (Q.Sig == null)
            {
                Console.WriteLine("El nodo '" + datoBuscado + "' es el último. No tiene nodo siguiente.");
            }
            else
            {
                Console.WriteLine("El nodo siguiente a '" + datoBuscado + "' es '" + Q.Sig.Dato + "' en la posición " + (posicion + 1) + ".");
            }

            RecorridoFrenteAFinal();
        }

        #endregion

        // Cuenta el número de nodos en la lista
        public int ContarNodos()
        {
            int contador = 0;
            Nodo Q = P.Sig;

            while (Q != null)
            {
                contador++;
                Q = Q.Sig;
            }

            return contador;
        }

        // Vacía completamente la lista
        public void VaciarLista()
        {
            P.Sig = null;
            Console.WriteLine("La lista ha sido vaciada.");
        }
    }
}
