using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
                //inicializamos la lista
            String[] strings = { "esto es una lista.", "como va", "nada.",
                           "claro que si.", "tiempo" };


            //verificamos si es v o f si termina en .
            foreach (var valor in strings)
            {
                bool terpun = valor.EndsWith(".");
                Console.WriteLine("'{0}' finaliza en punto {1}",
                                  valor, terpun);
            }
        }
    }
}
