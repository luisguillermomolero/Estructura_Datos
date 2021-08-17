using System;

namespace AplicacionBase
{
    //Programa para el calculo de notas de N alumnos
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int cantidadAlumnos;
            float Calificacion = 0.0f;
            float AcumuladorCalificacion = 0.0f;

            Console.Write("Ingrese la cantidad calificaciones de alumnos a registrar: ");
            cantidadAlumnos = int.Parse(System.Console.ReadLine());

            for (n = 1; n <= cantidadAlumnos; n++)
            {
                Console.Write($"Ingrese por favor la calificación del alumno {n}/{cantidadAlumnos}: ");
                Calificacion = int.Parse(System.Console.ReadLine());
                AcumuladorCalificacion += Calificacion;
            }
            Console.Write($"El promedio de calificaciones de {cantidadAlumnos} alumnos es: {AcumuladorCalificacion/cantidadAlumnos}");
        }
    }
}
