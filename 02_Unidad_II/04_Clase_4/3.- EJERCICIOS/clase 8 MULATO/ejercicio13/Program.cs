using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "XXXXX";
            Console.WriteLine("Cadena vieja: " + str);

            str = str.Replace('X', 'Y').Replace('Y', 'Z').Replace('Z', 'A');
            Console.WriteLine("Nueva cadena: " + str);
        }
    }
}
