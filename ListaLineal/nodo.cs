using System;

namespace ListaLineal
{
    // Clase Nodo para lista enlazada simple.
    // Solo tiene referencia al siguiente nodo (sig).
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo sig { get; set; }  // Puntero al siguiente nodo

        // Constructor para nodos con dato
        public Nodo(string dato)
        {
            Dato = dato;
            sig = null;
        }

        // Constructor para el nodo cabecera (sin dato)
        public Nodo()
        {
            Dato = null;
            sig = null;
        }
    }
}
