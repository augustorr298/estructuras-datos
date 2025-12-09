using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo sig { get; set; }

        // Constructor para nodo de datos.
        public Nodo(String dato)
        {
            Dato = dato;
            sig = null;
        }

        // Constructor para la cabecera.
        public Nodo()
        {
            Dato = null;
            sig = null;
        }
    }
}
