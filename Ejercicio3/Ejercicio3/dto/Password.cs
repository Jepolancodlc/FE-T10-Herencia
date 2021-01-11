using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Password
    {
        //atributos
        private int longitud=0;
        private string contraseña = "";


        //Constructores
        public Password()
        {
        }

        public Password(int longitud)
        {
            this.Longitud = longitud;
            this.contraseña = generarPassword();
        }

        //Getters and setters
        public int Longitud { get => longitud; set => longitud = value; }
        public string Contraseña { get => contraseña;}


        //Metodos
        private String generarPassword() //Genera una contraseña aleatoria
        {
            Random rnd = new Random();
            string pwd = "";
            string caracter = " !#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            char letra;

            for (int i = 0; i < longitud; i++)
            {
                letra = caracter[rnd.Next(caracter.Length)];
                pwd += letra.ToString();
            }
            return pwd;
        }

        public bool esFuerte()//Indica si es fuerte a partir de las peticiones del ejercicio
        {

            char caracter;
            int cuentanumeros = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;

            for (int i = 0; i < contraseña.Length; i++)
            {
                caracter = contraseña[i];

                if (char.IsUpper(caracter))
                {
                    cuentamayusculas++;
                }
                else if (char.IsLower(caracter))
                {
                    cuentaminusculas++;
                }
                else if (char.IsDigit(caracter))
                {
                    cuentanumeros++;
                }
            }

            if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2 )
            {
                return true;
            }
            else
            {
                return  false;
            }
        }
    }
}
