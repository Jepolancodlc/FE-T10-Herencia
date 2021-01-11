using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Television:Electrodomestico
    {
        //Atributos
        double resolucion, DEF_PULGADAS = 20;
        bool tdt, DEF_TDT=false;
        
        //constructores
        public Television():base()
        {
            this.resolucion = DEF_PULGADAS;
            this.tdt = DEF_TDT;
        }

        public Television(double precioBase,double peso):base(precioBase,peso)
        {
            this.resolucion = DEF_PULGADAS;
            this.tdt = DEF_TDT;
        }

        public Television(double pulgadas, bool tdt, double precioBase,string color, char consumo, double peso)
            :base(precioBase,color,consumo,peso)
        {
            this.resolucion = pulgadas;
            this.tdt = tdt;
        }

        //Getters
        public double Pulgadas { get => resolucion;}
        public bool Tdt { get => tdt; }

        //metodos
        public double precioFinal()
        {
            double plus = base.precioFinal();

            if (resolucion > 40)
            {
                plus += precioBase * 0.3;
            }
            if (tdt)
            {
                plus += 50;
            }
            return plus;
        }

    }
}
