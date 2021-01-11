using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Lavadora:Electrodomestico
    {
        //Atributos
        double carga, DEF_CARGA = 5;

        //Constructores
        public Lavadora() :base()
        {
            this.carga = DEF_CARGA;
        }

        public Lavadora (double precioBase , double peso) : base( precioBase, peso)
        {
            this.carga = DEF_CARGA;
        }

        public Lavadora(double precioBase, string color, char consumo, double peso ,double carga) : base(precioBase,color,consumo,peso)
        {
            this.carga = DEF_CARGA;
        }


        //Getter
        public double Carga { get => carga; }


        //metodos
        public double precioFinal()
        {
            double plus = base.precioFinal();

            if (carga > 30)
            {
                plus += 50;
            }

            return plus;
        }


    }
}
