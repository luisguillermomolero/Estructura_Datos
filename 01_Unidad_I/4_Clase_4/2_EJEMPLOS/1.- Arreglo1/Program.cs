using System;

namespace AplicacionBase
{
    class Program
    {
        /* Programa que permite calcular la nota de un estudiante utilizando un vector
         * y determinar cual es la calificaciòn menor y la calificación mayor
         */

        static void Main(string[] args)
        {
            int cantidadCalificaciones = 0;
            float sumaCalificaciones = 0.0F;
            float promedioCalificaciones = 0.0F;
            float CALIFICACION_MINIMA = 10.0F;
            float calificacionMinima = 0.0F;
            float calificacionMaxima = 0.0F;


            Console.Write("Ingrese la cantidad de calificaciones del alumnos: ");
            cantidadCalificaciones = int.Parse(System.Console.ReadLine());

            // Declaracion del vector
            float[] Calificaciones = new float[cantidadCalificaciones];

            // Ciclo para cargar el vector

            for (int n = 0; n < Calificaciones.Length; n++)
            {
                Console.Write($"Regalame la calificación {n+1} : ");
                Calificaciones[n] = float.Parse(System.Console.ReadLine());
                sumaCalificaciones += Calificaciones[n];
            }

            // Calculo del promedio de calificaciones

            promedioCalificaciones = sumaCalificaciones/cantidadCalificaciones;

            // Ciclo para conseguir la calificación mínima y máxima

            for (int n = 0; n < Calificaciones.Length; n++)
            {
                if (Calificaciones[n] < CALIFICACION_MINIMA)
                {
                    CALIFICACION_MINIMA = Calificaciones[n];
                    calificacionMinima = CALIFICACION_MINIMA;
                }
                    
                if (Calificaciones[n] > calificacionMaxima)
                    calificacionMaxima = Calificaciones[n];
            }

            // Mostrar resultados

            Console.WriteLine($"El promedio de calificaciones es {promedioCalificaciones}"); 
            Console.WriteLine($"La calificación mínima es {calificacionMinima}");
            Console.WriteLine($"La calificación máxima es {calificacionMaxima}");
        }
    }
}
