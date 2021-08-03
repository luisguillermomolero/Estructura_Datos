using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            do
            {
                int alum = 0;
                int peso = 0;
                int menos4 = 0;
                int mas4 = 0;
                int mas5 = 0;
                int mas6 = 0;


                Console.WriteLine("vamos saber el peso de los alumnos");
                Console.WriteLine("");
                Console.WriteLine("digete la cantidad de alumnos");
                alum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < alum; i++)
                {
                    Console.WriteLine("cual es tu pero 1: menos de 40kg, 2:entre 40 y 50kg, 3: mas de 50 y menos de 60kg, 4: mas o igual a 60kg");
                    peso = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    switch (peso)
                    {
                        case 1:
                            Console.WriteLine("elegiste menos de 40kg");
                            menos4++;
                            break;
                        case 2:
                            Console.WriteLine("elegiste entre 40 y 50kg");
                            mas4++;
                            break;
                        case 3:
                            Console.WriteLine("elegiste  mas de 50 y menos de 60kg");
                            mas5++;
                            break;
                        case 4:
                            Console.WriteLine("elegiste mas o igual a 60kg");
                            mas6++;
                            break;

                    }


                }

                Console.WriteLine("la cantidad de alumnos que pesan menos de 40kg son: " + menos4);
                Console.WriteLine("la cantidad de alumnos que pesan entre 40 y 50kg: " + mas4);
                Console.WriteLine("la cantidad de alumnos que pesan mas de 50 y menos de 60kg: " + mas5);
                Console.WriteLine("la cantidad de alumnos que pesan mas o igual a 60kg: " + mas6);

                Console.WriteLine("deseas continual ejecutando la aplicacion? (s/n)");
                s1 = Console.ReadLine();

            } while (s1 == "s");
        }
    }
}
