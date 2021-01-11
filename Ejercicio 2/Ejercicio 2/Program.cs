using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Introduzca el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nIntroduzca la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIntroduzca el sexo: ");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("\n[Recuerde utilizar la coma, Ejemplo: 80,31]  \nIntroduzca el peso [KG] :");
            double peso= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\n[Recuerde utilizar la coma, Ejemplo: 1,78] \nIntroduzca la altura [CM] : ");
            double altura = Convert.ToDouble(Console.ReadLine());
        
            Persona p1 = new Persona(nombre,edad,sexo,peso,altura); 
            Persona p2 = new Persona("Marco",12,'H');
            Persona p3 = new Persona();
       
            p3.Nombre = "Mar";
            p3.Edad = 29;
            p3.Sexo = 'M';
            p3.Peso = 40.7;
            p3.Altura = 1.70;

            void ImpEsMayor(Persona person){

                if (person.esMayorEdad() == true)
                {
                    Console.Write("Es mayor de edad | ");
                }
                else
                {
                    Console.Write("No es mayor de edad | ");
                }
            }

            void ImpIMC(Persona persona)
            {
                int imc = persona.calcularIMC();
           
                switch (imc)
                {
                    case  1 : Console.WriteLine("Sobrepeso");
                        break;
                    case -1:
                        Console.WriteLine("Peso ideal");
                        break;
                    case 0:
                        Console.WriteLine("Bajo el peso");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine(p1);
            ImpEsMayor(p1);
            ImpIMC(p1);
            Console.WriteLine("");
            Console.WriteLine(p2);
            ImpEsMayor(p2);
            ImpIMC(p2);
            Console.WriteLine("");
            Console.WriteLine(p3);
            ImpEsMayor(p3);
            ImpIMC(p3);
        }
    }
}
