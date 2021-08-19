using System;

namespace AplicacionBase
{
    class Program
    {
        /* Programa que permite calcular la nota de un estudiante utilizando un vector
         * y determina cual es la calificaciòn menor y la calificaciòn mayor
         */

        static void Main(string[] args)
        {
            int cantidadAlumnos = 0;
            float sumaCalificaciones = 0.0F;
            float promedioCalificaciones = 0.0F;
            int n = 0;
            float CALIFICACION_MINIMA = 10.0F;
            float calificacionMinima = 0.0F;
            float calificacionMaxima = 0.0F;


            Console.WriteLine("Ingrese la cantidad de calificaciones del alumnos");
            cantidadAlumnos = int.Parse(System.Console.ReadLine());

            // Declaracion del vector
            float[] Calificaciones = new float[cantidadAlumnos];

            // Ciclo para cargar el vector

            for (n = 0; n < Calificaciones.Length; n++)
            {
                Console.Write($"Regalame la calificación {n+1} : ");
                Calificaciones[n] = float.Parse(System.Console.ReadLine());
                sumaCalificaciones += Calificaciones[n];
            }

            // Calculo del promedio de calificaciones

            promedioCalificaciones = sumaCalificaciones/cantidadAlumnos;

            // Ciclo para conseguir la calificación mínima y máxima

            for (n = 0; n < Calificaciones.Length; n++)
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
