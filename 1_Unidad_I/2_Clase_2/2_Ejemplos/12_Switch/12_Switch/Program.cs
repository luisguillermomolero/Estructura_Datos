using System;

namespace AplicacionBase
{
    public class Program
    {
        static void Main(string[] args)
        {

            mostratMedicion(-4); // Salida: El valor medido es -4; demasiado baja.
            mostratMedicion(5);  // Salida: el valor medido es 5.
            mostratMedicion(30);  // Salida: El valor medido es 30; demasiado alto.
            mostratMedicion(double.NaN);  // Salida: medición fallida.

            void mostratMedicion(double Medicion)
            {
                switch (Medicion)
                {
                    case < 0.0:
                        Console.WriteLine($"El valor medido es {Medicion}; demasiado baja.");
                        break;

                    case > 15.0:
                        Console.WriteLine($"El valor medido es {Medicion}; demasiado alto.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Medicion fallida.");
                        break;

                    default:
                        Console.WriteLine($"El valor medido es {Medicion}.");
                        break;
                }
            }
        }
    }
}