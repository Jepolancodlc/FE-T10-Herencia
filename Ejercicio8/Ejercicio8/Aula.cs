using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio8
{
    class Aula
    {
        string id;
        int maxAlumnos = 20;
        Profesor profesor;
        Alumno[] alumnos;
        static Random r = new Random();
        static string[] materiasDadas = new String[3] { "fisica", "Filosofia", "Matematicas" };
        string materia;


        public Aula()
        {
            id = r.Next(100).ToString().PadLeft(3, '0');
            profesor = new Profesor();
            alumnos = new Alumno[maxAlumnos];
            creaAlumnos();
            materia = materiasDadas[r.Next(3)];
        }


        private void creaAlumnos()
        {

            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = new Alumno();
            }

        }

        private bool asistenciaAlumnos()
        {
            int cuentaAsistencias = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {

                if (alumnos[i].Asistencia)
                {
                    cuentaAsistencias++;
                }
            }

            Console.WriteLine("Hay {0} alumnos en clase", cuentaAsistencias);
            return cuentaAsistencias >= ((int)(alumnos.Length / 2));
        }

        public void notas()
        {
            int chicosApro = 0, chicasApro = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i].Nota >= 5)
                {
                    if (alumnos[i].Sexo == 'H')
                    {
                        chicosApro++;
                    }
                    else
                    {
                        chicasApro++;
                    }
                    Console.WriteLine(alumnos[i].ToString());
                }
            }
            Console.WriteLine("Hay {0}  chicos y {1} chicas aprobados/as", chicosApro, chicasApro);
        }


        public bool darClase()
        {
            if (!profesor.Asistencia)
            {
                Console.WriteLine("El profesor no esta, no se puede dar clase");
                return false;
            }
            else if (!profesor.Materias.Equals(materia))
            {
                Console.WriteLine("La materia del profesor y del aula no es la misma, no se puede dar clase");
                return false;
            }
            else if (!asistenciaAlumnos())
            {
                Console.WriteLine("La asistencia no es suficiente, no se puede dar clase");
                return false;
            }

            Console.WriteLine("Se puede dar clase");
            return true;

        }
    }
}
