using System;

namespace AplicacionBase
{
    public class Program
    {

        static void Main(string[] args)
        {

            mostraMedicion(-4);  // Salida: El valor medido es -4; fuera de un rango aceptable.
            mostraMedicion(50);  // Salida: el valor medido es 50.
            mostraMedicion(132); // Salida: El valor medido es 132; fuera de un rango aceptable.

            void mostraMedicion(int Medicion)
            {
                switch (Medicion)
                {
                    case < 0:
                    case > 100:
                        Console.WriteLine($"El valor medido es {Medicion}; fuera de un rango aceptable.");
                        break;

                    default:
                        Console.WriteLine($"El valor medido es {Medicion}.");
                        break;
                }
            }
        }
    }
}