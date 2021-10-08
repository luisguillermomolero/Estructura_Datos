using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos una matriz, cada string tiene sus espacios
            string[] saludo = { "hola  ", "sean ", "bienvenidos ", "a ",
                        "este  ", "programa " };

            // Los juntamos y mostramos
            Console.WriteLine(string.Concat(saludo));
            
        }
    }
}
