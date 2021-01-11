using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular)
        {
            this.Titular = titular;
        }

        public Cuenta(string titular, double cantidad) : this(titular)
        {
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public void ingresar(double cantidad) 
        {
            if (cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            { 
                this.cantidad += cantidad;
            }
        }

        public void retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }
        }

        public override string ToString()
        {
            return String.Format("El titular {0} contiene {1}$ en su cuenta",this.titular,cantidad);
        }
    }
}
