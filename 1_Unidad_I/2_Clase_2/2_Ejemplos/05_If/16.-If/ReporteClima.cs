using System;

namespace AplicacionBase
{
    class ReporteClima
    {
        static void Main(string[] args)
        {
            mostrarReporteClima(15.0);  // Salida: Frio!..
            mostrarReporteClima(24.0);  // Salida: Prefecto!..

            void mostrarReporteClima(double temperaturaCelsius)
            {

                if (temperaturaCelsius < 20.0)
                {
                    Console.WriteLine("Frio!..");
                }
                else
                {
                    Console.WriteLine("Perfecto!..");
                }
            }
        }
    }
}