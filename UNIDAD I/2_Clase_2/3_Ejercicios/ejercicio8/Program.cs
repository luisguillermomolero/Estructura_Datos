using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dia;
            int Mes;
            int Anio;

            string entrada = "";


            Console.WriteLine("digita la fechas para darte la del siguiente");
            Console.WriteLine("");

            Console.WriteLine("digita el Dia");
            entrada = Console.ReadLine();
            Dia = Convert.ToInt32(entrada);

            Console.WriteLine("digita el Mes");
            entrada = Console.ReadLine();
            Mes = Convert.ToInt32(entrada);

            Console.WriteLine("digita el Anio");
            entrada = Console.ReadLine();
            Anio = Convert.ToInt32(entrada);


            if ((Dia == 31) && (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11) || (Dia == 30) || (Dia == 29) && (Mes == 2))
            {
                Dia = 1;
                Mes = Mes+1;
                Console.WriteLine("la fecha del Dia siguiente es: " + Dia + "/" + Mes + "/" + Anio);
            }
            else if ((Mes == 12) && (Dia == 31))
            {
                Dia = 1;
                Mes = 1;
                Anio = Anio+1;
                Console.WriteLine("la fecha del Dia siguiente es: " + Dia + "/" + Mes + "/" + Anio);
            }
            else
            {
                Dia = Dia+1;
                Console.WriteLine("la fecha del Dia siguiente es: " + Dia + "/" + Mes + "/" + Anio);
            }
                


        }
    }
}
