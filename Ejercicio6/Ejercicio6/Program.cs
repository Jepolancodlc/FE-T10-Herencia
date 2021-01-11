
using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l1 = new Libro(984651565, 640, "Origen","Dan Brown");
            Libro l2 = new Libro(894651133, 332,"La divina Comedia", "Dante Alighieri");

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine();

            if (l1.NumPaginas > l2.NumPaginas)
            {
                Console.WriteLine("El libro {0} tiene mas paginas que el libro {1}", l1.Titulo,l2.Titulo);
            }
            else
            {
                Console.WriteLine("El libro '{0}' tiene mas paginas que el libro '{1}'", l2.Titulo, l1.Titulo);
            }
        }
    }
}
