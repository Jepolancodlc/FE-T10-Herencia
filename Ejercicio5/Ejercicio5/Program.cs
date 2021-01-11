using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Videojuegos[] ArrayVid = new Videojuegos[5];
            Serie[] ArraySerie = new Serie[5];

            ArraySerie[0] = new Serie();
            ArraySerie[1] = new Serie("Mr. Robot", "Sam Esmail");
            ArraySerie[2] = new Serie("Carnival Row", "Fantasia", "Travis Beacham", 2);
            ArraySerie[3] = new Serie("American Gods", "Accion", "Alguien", 5);
            ArraySerie[4] = new Serie("Big Bang Theory", "Chuck Lorre");

            ArrayVid[0] = new Videojuegos("Uncharted", 55);
            ArrayVid[1] = new Videojuegos("The last of us 2", "Naughty Dog", "Propaganda",65);
            ArrayVid[2] = new Videojuegos("The legend of zelda", 40);
            ArrayVid[3] = new Videojuegos("God of War", "Sony Santa Monica", "Accion",45);
            ArrayVid[4] = new Videojuegos("GTA: San Andreas", "Rockstar", "Accion", 100);

            ArraySerie[4].entregar();   ArraySerie[1].entregar();     ArraySerie[2].entregar();
            ArrayVid[0].entregar();     ArrayVid[3].entregar();       ArrayVid[2].entregar();

            int entregadosSer = 0, entregadosVid = 0;

            for (int i = 0; i < ArraySerie.Length; i++)
            {
                if (ArraySerie[i].isEntregado())
                {
                    entregadosSer++;
                    ArraySerie[i].devolver();

                }
                if (ArrayVid[i].isEntregado())
                {
                    entregadosVid++;
                    ArrayVid[i].devolver();
                }
            }
            Console.WriteLine("Hay un total de {0} series y {1} videojuegos entregados", entregadosSer, entregadosVid);

            Serie serieMayor = ArraySerie[0];
            Videojuegos videojuegoMayor = ArrayVid[0];

            for (int i = 1; i < ArraySerie.Length; i++)
            {
                if (ArraySerie[i].compareTo(serieMayor) == Serie.MAYOR)
                {
                    serieMayor = ArraySerie[i];
                }
                if (ArrayVid[i].compareTo(videojuegoMayor) == Videojuegos.MAYOR)
                {
                    videojuegoMayor = ArrayVid[i];
                }
            }

          Console.WriteLine(videojuegoMayor);
          Console.WriteLine(serieMayor);
        }
    }
}
