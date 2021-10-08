using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "porque-no";
            char pad = '.';
            char rel = 's';


            //rellenamos los espacios que faltan finalizando
            Console.WriteLine(str.PadRight(15, pad));
            Console.WriteLine(str.PadRight(18, rel));
        }
    }
}
