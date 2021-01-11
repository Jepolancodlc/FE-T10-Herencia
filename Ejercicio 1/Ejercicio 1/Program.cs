using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("Pedro");
            Cuenta c2 = new Cuenta("Juan", 500);

            c.ingresar(200);
            c2.ingresar(100);

            c.retirar(250);
            c2.retirar(200);

            Console.WriteLine(c);
            Console.WriteLine(c2);
        }
    }
}
