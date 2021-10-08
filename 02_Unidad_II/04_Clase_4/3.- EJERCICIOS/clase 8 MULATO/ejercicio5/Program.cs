using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = { "Nombre: Felica Walker", "Titulo: Mz.",
                   "años: 47", "pais: Paris", "sexo: F"};
            int encontrar = 0;

            Console.WriteLine("Los valores iniciales de la matriz son:");
            foreach (string s in info)
                Console.WriteLine(s);

            Console.WriteLine("recuperacion de la informacion clave");
            foreach (string s in info)
            {
                encontrar = s.IndexOf(": ");
                Console.WriteLine("   {0}", s.Substring(encontrar + 2));
            }
        }
    }
}
