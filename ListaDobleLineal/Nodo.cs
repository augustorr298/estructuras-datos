using System;

namespace ListaDobleLineal
{
    // Clase Nodo para lista doblemente enlazada.
    // Cada nodo tiene referencias al nodo anterior y al siguiente.
    internal class Nodo
    {
        // Propiedades del nodo
        public string Dato { get; set; }
        public Nodo Sig { get; set; }  // Puntero al siguiente nodo
        public Nodo Ant { get; set; }  // Puntero al nodo anterior

        // Constructor para nodos con dato
        // El dato a almacenar en el nodo
        public Nodo(string dato)
        {
            Ant = null;
            Dato = dato;
            Sig = null;
        }

        // Constructor para el nodo cabecera (sin dato)
        public Nodo()
        {
            Ant = null;
            Dato = null;
            Sig = null;
        }
    }
}
