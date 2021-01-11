using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] elecArray = new Electrodomestico[10];
            elecArray[0] = new Electrodomestico();
            elecArray[1] = new Electrodomestico(500,120);
            elecArray[2] = new Electrodomestico(660,"Negro",'B',100);
            elecArray[3] = new Electrodomestico(220,"rojo",'C',68);
            elecArray[4] = new Television();
            elecArray[5] = new Television(200,40);
            elecArray[6] = new Television(1000,true,1200,"Blanco",'A',72);
            elecArray[7] = new Lavadora();
            elecArray[8] = new Lavadora(443,130);
            elecArray[9] = new Lavadora(232,"Azul",'F',122,10);

            double totalLavadora = 0;
            double totalTV = 0;
            double totalElectrodomestico = 0;

            for (int i = 0; i < elecArray.Length; i++)
            {
                Electrodomestico o = elecArray[i];
                o.precioFinal();

                if (o.GetType() == typeof(Lavadora))
                {
                    totalLavadora = totalLavadora + o.PrecioBase;
                }
                if (o.GetType() == typeof(Television))
                {
                    totalTV = totalTV + o.PrecioBase;
                }
                totalElectrodomestico = totalElectrodomestico + o.PrecioBase;
            }

            Console.WriteLine("Precio total de los electrodomesticos es: {0}$", totalElectrodomestico);
            Console.WriteLine("Precio total de las lavadoras: {0}$", totalLavadora);
            Console.WriteLine("Precio total de las televisiones: {0}$", totalTV);
        }
    }
}
