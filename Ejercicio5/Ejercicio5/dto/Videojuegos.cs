using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Videojuegos : iEntregable
    {   
        //atributos
        string titulos=" ", genero=" ", compañia=" ";
        double horasEstimadas=10;
        bool entregado=false;

        //Constructores
        public Videojuegos()
        {
        }

        public Videojuegos(string titulos, double horasEstimadas)
        {
            this.Titulos = titulos;
            this.HorasEstimadas = horasEstimadas;
        }

        public Videojuegos(string titulos, string genero, string compañia, double horasEstimadas)
        {
            this.Titulos = titulos;
            this.Genero = genero;
            this.Compañia = compañia;
            this.HorasEstimadas = horasEstimadas;
        }

        //getters and setters
        public string Titulos { get => titulos; set => titulos = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Compañia { get => compañia; set => compañia = value; }
        public double HorasEstimadas { get => horasEstimadas; set => horasEstimadas = value; }

        //ToString
        public override string ToString()
        {
            return $"{{{nameof(Titulos)}={Titulos}, {nameof(Genero)}={Genero}, {nameof(Compañia)}={Compañia}, {nameof(HorasEstimadas)}={HorasEstimadas.ToString()}h}}";
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


        public static int MENOR = -1,MAYOR=1,IGUAL=0;
        public int compareTo(Object a)
        {
            int estado = MENOR;

            Videojuegos vid= (Videojuegos)a;
            if (horasEstimadas > vid.HorasEstimadas)
            {
                estado = MAYOR;
            }
            else if (horasEstimadas == vid.HorasEstimadas)
            {
                estado = IGUAL;
            }

            return estado;
        }

        
    }





}
