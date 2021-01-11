using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class Raices
    {
        private double a, b, c;
     
      
        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        
        private void obtenerRaices()
        {

            double x1 = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);
            double x2 = (-b - Math.Sqrt(getDiscriminante())) / (2 * a);

           Console.WriteLine("Solucion 1: {0}", x1);
           Console.WriteLine("Solucion 2: {0}", x2);
        }

        
        private void obtenerRaiz()
        {

            double x = (-b) / (2 * a);

           Console.WriteLine("Unica solucion");
           Console.WriteLine(x);

        }

        
        private double getDiscriminante()
        {
            return Math.Pow(b, 2) - (4 * a * c);
            
        }

       
        private bool tieneRaices()
        {
            return getDiscriminante() > 0;
        }

        private bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }

       
        public void calcular()
        {

            if (tieneRaices())
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("No tiene soluciones");
            }
        }
    }
}
