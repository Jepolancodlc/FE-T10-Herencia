using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Electrodomestico
	{
		protected double precioBase;
		protected string color;
		protected char consumo;
		protected double peso;

		//Constantes por defecto
		protected string COLOR_DEF = "Blanco";
		protected double PRECIO_DEF = 100;
		protected char CONSUMO_DEF = 'F';
		protected double PESO_DEF = 5;
        internal double _PrecioBase;

        public Electrodomestico()
		{
			this.PrecioBase = PRECIO_DEF;
			this.Color = COLOR_DEF;
			this.Consumo = CONSUMO_DEF;
			this.Peso = PESO_DEF;
		}

		public Electrodomestico(double precioBase, double peso)
		{

			this.PrecioBase = precioBase;
			this.Peso = peso;
			this.Color = COLOR_DEF;
			this.Consumo = CONSUMO_DEF;

		}

		public Electrodomestico(double precioBase, string color, char consumo, double peso)
		{

			this.PrecioBase = precioBase;
			this.Color = elegirColor(color);
			this.Consumo = elegirEnergia(consumo);
			this.Peso = peso;

		}

        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public string Color { get => elegirColor(color); set => color = value; }
        public char Consumo { get => elegirEnergia(consumo); set => consumo = value; }
        public double Peso { get => peso; set => peso = value; }

        private string elegirColor(string elcolor)
		{
			elcolor = elcolor.ToLower();

			switch (elcolor)
			{
				case "blanco":
					return "Blanco";
				case "negro":
					return "Negro";
				case "rojo":
					return "Rojo";
				case "azul":
					return "Azul";
				case "gris":
					return "Gris";

				default:
					Console.WriteLine("El color por defecto es Blanco, por favor doubleroduzca un color correcto ");
					break;
			}
			return elcolor;
		}

		private char elegirEnergia(char tipoDeEnergia)
		{
			

			switch (tipoDeEnergia)
			{
				case 'A':
					return 'A';
				case 'B':
					return 'B';
				case 'C':
					return 'C';
				case 'D':
					return 'D';
				case 'E':
					return 'E';
				case 'F':
					return 'F';
				default:
					Console.WriteLine("El consumo por defecto es F, por favor seleccione un consumo energetico correcto");
					break;
			}
			return tipoDeEnergia;
		}

		public double precioFinal()
        {
			double plus = 0;
			switch (consumo)
			{
				case 'A':
					plus += 100;
					break;
				case 'B':
					plus += 80;
					break;
				case 'C':
					plus += 60;
					break;
				case 'D':
					plus += 50;
					break;
				case 'E':
					plus += 30;
					break;
				case 'F':
					plus += 10;
					break;
				default:
					break;
			}

            if (peso>=0 && peso <19)
            {
				plus += 10;
            }
            else if(peso >= 20 && peso < 49)
            {
				plus += 10;
			}
			return plus+precioBase;
		}
	}
}
