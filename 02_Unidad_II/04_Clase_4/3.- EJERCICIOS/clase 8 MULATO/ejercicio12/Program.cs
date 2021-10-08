using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hola---mundo";
           
            // vamos a remover los indices indicados 
            Console.WriteLine("1)     {0}", s);
            Console.WriteLine("2)     {0}", s.Remove(4));
            Console.WriteLine("3)     {0}", s.Remove(4, 3));
        }
    }
}
