using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Alumno :Persona
    {
        static Random r = new Random();
        int nota = r.Next(10);

        public Alumno():base()
        {
            this.Edad = r.Next(12, 16);
            this.Nota = nota;
        }

        public int Nota { get => nota; set => nota = value; }

        public override void disponibilidad()
        {
            Random random = new Random();
            int prob = random.Next(100);

            if (prob < 50)
            {
               base.Asistencia=false;
            }
            else
            {
               base.Asistencia=true;
            }

        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} | Sexo: {1} | Nota: {2}", Nombre,Sexo,nota);
        }
    }
}
