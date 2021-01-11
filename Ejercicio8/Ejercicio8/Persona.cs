using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    abstract class Persona
    {
        static Random r = new Random();
        string nombre;
        int edad;
        char sexo;
        bool asistencia = false;
        string[] nombreChico={"Juan","David","Jean","Fernando","Marcos","Kevin","Adrian","Alberto","Luan", "Diego","Dan"}; 
        string[] nombreChica={"Maria","Sahara","Mar","Lucia","Joana","Camila","Alicia", "Laura", "Anais", "Teresa", "Elena"};
        string[] apellido = { "Ruiz", "Tevez", "Castillo", "Perez", "Rodriguez", "Fernandez", "Arias", "Bravo", "Garcia", "Cantera" };
        public Persona()
        {
            int esSexo = r.Next(10);
            
            if (esSexo >5 )
            {
                this.nombre = nombreChico[r.Next(nombreChico.Length)] +" "+ apellido[r.Next(apellido.Length)];
                this.sexo = 'H';
            }
            
            else
            {
                this.nombre = nombreChica[r.Next(nombreChica.Length)] + " " + apellido[r.Next(apellido.Length)];
                this.sexo = 'M';
            }
            disponibilidad();
        }

    
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }

        public abstract void disponibilidad();
    }
    }
