using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Profesor : Persona
    {
        static Random r = new Random();
        static string[] materiasDadas = new String[3] { "fisica", "Filosofia", "Matematicas" };

        string materias= materiasDadas[r.Next(3)];

        public Profesor() : base()
        {
            this.Edad = r.Next(25, 60);
            this.Materias = materias;
        }

        public string Materias { get => materias; set => materias = value; }

        public override void disponibilidad()
        {
            int prob = r.Next(100);

            if (prob < 20)
            {
                base.Asistencia = false;
            }
            else
            {
                base.Asistencia = true;
            }

        }
    }
}
