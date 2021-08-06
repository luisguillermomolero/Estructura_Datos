using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingresar;
            int numcompets,i;
            float men = 99999;

            Console.WriteLine("¿A cuántos competidores les va a ingresar el tiempo?");
            ingresar = Console.ReadLine();
            numcompets = Convert.ToInt32(ingresar);

            Console.WriteLine("\n");
            float [] tcompts= new float[numcompets];
            for (i = 0; i < numcompets; i++)
            {
                Console.WriteLine("Digite el tiempo en minutos del competidor numero {0}", i);
                ingresar = Console.ReadLine();
                tcompts[i] = Convert.ToSingle(ingresar);
                
                if (tcompts[i] < men)
                {
                    men = tcompts[i];
                }
            }
            Console.WriteLine("\n\nEl competidor que que gano por terminar la carrera en el menor tiempo fue el que tardo {0} minutos", men);
        }
    }
}
