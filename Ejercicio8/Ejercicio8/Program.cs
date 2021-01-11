using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula aula = new Aula();

            //Indicamos si se puede dar la clase
            if (aula.darClase())
            {
                aula.notas();
            }
        }
    }
}
