using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor;
            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza): ");
                Valor = int.Parse(System.Console.ReadLine());

                if (Valor >= 100)
                    Console.WriteLine($"{Valor} tiene 3 dígitos.");
                else
                {
                    if (Valor >= 10)
                        Console.WriteLine($"{Valor} tiene 2 dígitos.");
                    else
                        Console.WriteLine($"{Valor} tiene 1 dígito.");
                }
            } while (Valor != 0);
        }
    }
}