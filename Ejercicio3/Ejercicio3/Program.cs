using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el tamaño del array: ");
            int tamArray = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIntroduzca el tamaño de la contraseña: ");
            int longContraseña = Convert.ToInt32(Console.ReadLine());

            Password[] arrayPWD = new Password[tamArray];
            bool[] esFuertePWD = new bool[tamArray];

            for (int i = 0; i < arrayPWD.Length; i++)
            {
                arrayPWD[i] = new Password(longContraseña);
                esFuertePWD[i] = arrayPWD[i].esFuerte();
                Console.WriteLine("{0} {1}",arrayPWD[i].Contraseña,esFuertePWD[i]);
            }

        }
    }
}
