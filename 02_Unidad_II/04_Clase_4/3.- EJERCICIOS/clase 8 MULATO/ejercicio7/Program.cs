using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string copi = "pero";
            char[] desti = { 'h', 'o', 'l', 'a', ' ', 'c','o','m','o',' ','h', 'a', 'c', 'e' };

            Console.WriteLine(desti);

            // cambiamos el como por pero de desti
            copi.CopyTo(0, desti, 5, copi.Length);


            //mostramos el resultado
            Console.WriteLine(desti);
        }
    }
}
