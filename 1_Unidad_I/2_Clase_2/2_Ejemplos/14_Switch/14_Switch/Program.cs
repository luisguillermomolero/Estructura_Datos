//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

using System;

namespace AplicacionBase
{
    class Program
    {

        static void Main(string[] args)
        {

            mostrarMedicion(3, 4);  // Resultado: la primera medida es 3, la segunda medida es 4.
            mostrarMedicion(5, 5);  // Salida: Ambas medidas son válidas e iguales a 5.

            void mostrarMedicion(int a, int b)
            {
                switch ((a, b))
                {
                    case ( > 0, > 0) when a == b:
                        Console.WriteLine($"Ambas medidas son válidas e iguales a {a}.");
                        break;

                    case ( > 0, > 0):
                        Console.WriteLine($"La primera medida es {a}, la segunda medida es {b}.");
                        break;

                    default:
                        Console.WriteLine("Una o ambas medidas no son válidas.");
                        break;
                }
            }
        }
    }
}