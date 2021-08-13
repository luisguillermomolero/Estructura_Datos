using System;

namespace AplicacionBase
{
    public class Program
    {

        static void Main(string[] args)
        {

            mostrarMedicion(45);  // Salida: el valor de medición es 45
            mostrarMedicion(-3);  // Salida: Advertencia: ¡valor no aceptable! El valor de medición es -3

            void mostrarMedicion(double value)
            // Operadores lógicos: && Y; ||	O; ! No
            {
                if (value < 0 || value > 100)
                    Console.Write("Advertencia: ¡valor no aceptable!");

                Console.WriteLine($"El valor de la medida es {value}");
            }
        }
    }

}