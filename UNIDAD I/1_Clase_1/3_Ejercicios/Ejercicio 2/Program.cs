using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            float PI = 3.14f;
            int Radio = 0;
            float Area = 0;

            string entrada = "";

            Console.WriteLine("vamos a calcular el area de un circulo");
            Console.WriteLine("");

            Console.WriteLine("Digita el radio del circulo");
            entrada = Console.ReadLine();
            Radio = Convert.ToInt32(entrada);

            Area = PI*(Radio*Radio);

            Console.WriteLine("El area de la circunferencia es " + Area);
        }
    }
}
