using System;

namespace ListaDobleCircular
{
    // Clase Nodo para lista doblemente enlazada circular.
    // Cada nodo tiene referencias al nodo anterior y al siguiente.
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo sig { get; set; }  // Puntero al siguiente nodo
        public Nodo ant { get; set; }  // Puntero al nodo anterior

        // Constructor para nodos con dato
        public Nodo(string dato)
        {
            ant = null;
            Dato = dato;
            sig = null;
        }

        // Constructor para el nodo cabecera (sin dato)
        public Nodo()
        {
            ant = null;
            Dato = null;
            sig = null;
        }
    }
}