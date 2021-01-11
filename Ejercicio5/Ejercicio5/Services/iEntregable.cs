using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    interface iEntregable
    {
        public void entregar();
        public void devolver();
        public bool isEntregado();
        public int compareTo(object a);

    }
}
