using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            String original = "aaappp";
            Console.WriteLine("el original: '{0}'", original);

            //con este vamos a insertar un espacio en el indice 3
            String modified = original.Insert(3, " ");
            Console.WriteLine("el modificado con insert '{0}'", modified);
        }
    }
}
