using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Serie : iEntregable
    {
        //Atributos
		private string titulo=" ", genero=" ", creador=" ";
		private int temporadas=3;
		private bool entregado=false;

        //Constructores
        public Serie()
        {
        }

        public Serie(string titulo, string creador )
        {
            this.Titulo = titulo;
            this.Creador = creador;
        }

        public Serie(string titulo, string genero, string creador, int temporadas)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Creador = creador;
            this.Temporadas = temporadas;
          
        }
        //Getters and setters
        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }
        public int Temporadas { get => temporadas; set => temporadas = value; }


        //ToString
        public override string ToString()
        {
            return $"{{{nameof(Titulo)}={Titulo}, {nameof(Genero)}={Genero}, {nameof(Creador)}={Creador}, {nameof(Temporadas)}={Temporadas.ToString()}}}";
        }

     
        //
        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = true;
        }
        public bool isEntregado()
        {
            return entregado;
        }


       public static int MENOR = -1, MAYOR = 1, IGUAL = 0;
        public int compareTo(Object a)
        {
            int estado = MENOR;

            Serie ser = (Serie)a;
            if (temporadas > ser.Temporadas)
            {
                estado = MAYOR;
            }
            else if (temporadas == ser.Temporadas)
            {
                estado = IGUAL;
            }

            return estado;
        }

    }
}
