using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="porque-si";
            char pad = '.';
            
            // rellenamos con un punto desde el inicio para hacer 15 espacios completos
            Console.WriteLine(str.PadLeft(15, pad));

            // no llenamos nada por que ya hay mas de 2 espacios llenos 

            Console.WriteLine(str.PadLeft(2, pad));
        }
    }
}
