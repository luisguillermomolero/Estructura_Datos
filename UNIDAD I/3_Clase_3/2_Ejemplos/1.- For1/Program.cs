using System;

namespace AplicacionBase
{
    //programa para sacar el Promedio de las calificaciones para tres alumnos.

    class Program
    {
        static void   Main(string[] args)
        {
            float Calificacion1 = 0.0f;
            float Calificacion2 = 0.0f;
            float Calificacion3 = 0.0f;
            float Promedio = 0.0f;

            Console.Write("Ingrese la primera calificación: ");
            Calificacion1 = int.Parse(System.Console.ReadLine());

            Console.Write("Ingrese la segunda calificación: ");
            Calificacion2 = int.Parse(System.Console.ReadLine());

            Console.Write("Ingrese la tercera calificación: ");
            Calificacion3 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("\nEl Promedio es {0}",  (Calificacion1 + Calificacion2 + Calificacion3) / 3);

            //Usando el FOR

            int n = 0;  // Valor de control ciclo for
            int Acumulador = 0;
            int Calificacion = 0;
            int CANTIDAD_ESTUDIANTES = 3;

            Console.WriteLine("\nUtilizando el ciclo for");

            for (n = 0; n < CANTIDAD_ESTUDIANTES; n++){
                Console.Write($" Ingrese la calificación {n+1}/{CANTIDAD_ESTUDIANTES} ");
                Calificacion = int.Parse(System.Console.ReadLine());
                Acumulador += Calificacion;
            }
            Console.WriteLine($"\nEl promedio es: {Acumulador/CANTIDAD_ESTUDIANTES}");
        }
    }
}
