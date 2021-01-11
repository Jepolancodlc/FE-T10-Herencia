using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_2
{
    class Persona
    {
        private string nombre,dni;
        private int edad;
        private char sexo;
        private double peso, altura;

        //Constantes por defecto
        private string NOMBRE_DEF="", DNI_DEF="00000000A";
        private int EDAD_DEF=0;
        private char SEXO_DEF='H';
        private double PESO_DEF=0, ALTURA_DEF=0;

        //Constructores

         public Persona()
        {
            this.sexo = SEXO_DEF;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = generaDNI();
            this.sexo = sexo;
            comprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }

        //Setters
        public string Nombre {  set => nombre = value; }
        public int Edad {  set => edad = value; }
        public char Sexo { set => sexo = value; }
        public double Peso {  set => peso = value; }
        public double Altura { set => altura = value; }

        //Metodos
        public int calcularIMC()
        {
            double x = peso / (Math.Pow(altura, 2));

            if (x >= 20 && x <= 25)
            {
                return -1;
            }
            else if (x < 20)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public bool esMayorEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comprobarSexo(char sexo)
        {
            if (sexo != 'H' && sexo != 'M')
            {
                this.sexo = SEXO_DEF;
            }
        }

        private char calcularLetra(int n)
        {
            string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            return (char)cadena[n % 23];
        }

        private string generaDNI()
        {
            Random r = new Random();

            var GenerarNumDNI = r.Next(0, 100000000).ToString("D8");
            var numDNI = Convert.ToInt32(GenerarNumDNI);

            var letra = calcularLetra(numDNI);

            string dni = GenerarNumDNI + letra;

            return dni;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} | DNI: {1} | Edad: {2} | Sexo: {3} | Peso: {4}kg| Altura: {5}cm|",nombre,dni,edad,sexo,peso,altura);
        }
    }
}
