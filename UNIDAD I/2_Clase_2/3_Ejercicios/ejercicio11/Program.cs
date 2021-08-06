using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            int alum = 0;
            int peso = 0;
            int menos4 = 0;
            int mas4 = 0;
            int mas5 = 0;
            int mas6 = 0;


            Console.WriteLine("  *** Estadisticas de peso de un grupo de alumnos *** ");
            Console.WriteLine("");
            Console.WriteLine("      ** Digite -99 para salir del sistema ** ");
            Console.WriteLine("");
            Console.Write("      Por favor, digite la cantidad de alumnos: ");
            alum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= alum; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("      1: Peso menor de 40kg");
                Console.WriteLine("      2: Peso entre 40 y 50kg");
                Console.WriteLine("      3: Peso entre 50 y 59kg");
                Console.WriteLine("      4: Peso igual o mayor a 60kg");

                Console.WriteLine("");
                Console.Write("                     Seleccione el peso del estudiante {0} : ", i);
                peso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (peso)
                {
                    case 1:
                        Console.WriteLine("          Seleccionó un peso menor de 40kg");
                        menos4++;
                        break;
                    case 2:
                        Console.WriteLine("          Seleccionó un peso entre 40 y 49kg");
                        mas4++;
                        break;
                    case 3:
                        Console.WriteLine("          Seleccionó un peso entre 50 y menos de 59kg");
                        mas5++;
                        break;
                    case 4:
                        Console.WriteLine("          Seleccionó un peso mayor a 60kg");
                        mas6++;
                        break;

                }


            }

            Console.WriteLine("la cantidad de alumnos que pesan menos de 40kg son: " + menos4);
            Console.WriteLine("la cantidad de alumnos que pesan entre 40 y 50kg: " + mas4);
            Console.WriteLine("la cantidad de alumnos que pesan mas de 50 y menos de 60kg: " + mas5);
            Console.WriteLine("la cantidad de alumnos que pesan mas o igual a 60kg: " + mas6);
        }
    }
}
