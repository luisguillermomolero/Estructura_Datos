using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "el perro puede volar como un avion";
            string palabra = "volar";

            //aseguramos que la palabra se encuentre en la frase 
            bool b = frase.Contains(palabra);
            Console.WriteLine("'{0}' esta en la frase '{1}': {2}",
                palabra, frase, b);

            //mostramos en  la posicion en la que se encuentra la palabra
            if (b)
            {
                int posicion = frase.IndexOf(palabra);
                if (posicion >= 0)
                    Console.WriteLine("'{0} la palabra se encuentra en el espacio {1}",
                                  palabra, posicion + 1);
            }

        }
    }
}
