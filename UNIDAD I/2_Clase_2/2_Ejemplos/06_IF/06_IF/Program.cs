using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 dígitos.");
                }
                else
                {
                    if (valor >= 10)
                    {
                        Console.WriteLine("Tiene 2 dígitos.");
                    }
                    else
                    {
                        Console.WriteLine("Tiene 1 dígito.");
                    }
                }
            } while (valor != 0);
        }
    }
}