using System;
using System.Globalization;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.Calcular la nota media por alumnos de una clase de n alumnos.
            Cada alumno podrá tener m notas distintas.*/

            int numal, numnot, i, j;
            float nota;
            string entrada;

            Console.WriteLine("¿Cuántos alumnos hay en la clase?");
            entrada = Console.ReadLine();
            numal = Convert.ToInt32(entrada);
           
            for (i = 1; i <= numal; i++)
            {
                float acumntas = 0, prom;

                Console.WriteLine("___________________________________________");
                Console.WriteLine("\n¿Cuántas notas tiene el alumno numero {0}?", i);
                entrada = Console.ReadLine();
                numnot = Convert.ToInt32(entrada);
                
                for (j = 1; j <= numnot; j++)
                {                    
                    Console.WriteLine("\nPor favor digite la nota numero {0} del alumno {1}", j, i);
                    entrada = Console.ReadLine();
                    nota = Convert.ToSingle(entrada);

                    acumntas = acumntas + nota;                     
                }
                prom = acumntas / numnot;
                Console.WriteLine("\nla nota media del alumno {0} es: {1}\n\n\n", i,prom);
            }
            
        }
    }
}
