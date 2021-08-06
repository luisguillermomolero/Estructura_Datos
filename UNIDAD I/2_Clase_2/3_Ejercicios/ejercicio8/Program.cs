using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;

            string entrada = "";


            Console.WriteLine("digita la fechas para darte la del siguiente");
            Console.WriteLine("");

            Console.WriteLine("digita el dia");
            entrada = Console.ReadLine();
            dia = Convert.ToInt32(entrada);

            Console.WriteLine("digita el mes");
            entrada = Console.ReadLine();
            mes = Convert.ToInt32(entrada);

            Console.WriteLine("digita el año");
            entrada = Console.ReadLine();
            año = Convert.ToInt32(entrada);


            if ((dia == 31) && (mes == 4 || mes == 6 || mes == 9 || mes == 11) || (dia == 30) || (dia == 29) && (mes == 2))
            {
                dia = 1;
                mes = mes+1;
                Console.WriteLine("la fecha del dia siguiente es: " + dia + "/" + mes + "/" + año);
            }
            else if ((mes == 12) && (dia == 31))
            {
                dia = 1;
                mes = 1;
                año = año+1;
                Console.WriteLine("la fecha del dia siguiente es: " + dia + "/" + mes + "/" + año);
            }
            else
            {
                dia = dia+1;
                Console.WriteLine("la fecha del dia siguiente es: " + dia + "/" + mes + "/" + año);
            }
                


        }
    }
}
