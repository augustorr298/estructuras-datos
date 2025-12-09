using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class NodoArbolB
    {
        public int Dato { get; set; }

        public NodoArbolB izq { get; set; }

        public NodoArbolB der { get; set; }

        public NodoArbolB(int dato)
        {
            Dato = dato;
            izq = null;
            der = null;
        }
    }
}
