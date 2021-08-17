using System;
using System.Globalization;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.Calcular la nota media por alumnos de una clase de n alumnos.
            Cada alumno podrá tener m notas distintas.*/

            int cantidadAlumnos = 0;
            int cantidadNotas = 0;
            int i, j;
            float Nota;

            Console.Write("¿Cuántos alumnos hay en la clase: ");
            cantidadAlumnos = int.Parse(System.Console.ReadLine());
           
            for (i = 1; i <= cantidadAlumnos; i++)
            {
                float acumuladorNotas = 0.0F;
                float Promedio = 0.0F;

                Console.WriteLine("___________________________________________");
                Console.Write($"\n¿Cuántas notas tiene el alumno numero {i}: ");
                cantidadNotas = int.Parse(System.Console.ReadLine());
                
                for (j = 1; j <= cantidadNotas; j++)
                {                    
                    Console.Write($"Por favor digite la nota numero {j} del alumno {i}: ");
                    Nota = float.Parse(System.Console.ReadLine());
                    acumuladorNotas += Nota;
                }
                Promedio = acumuladorNotas/cantidadNotas;
                Console.Write($"La nota media del alumno {i} es: {Promedio}\n");
            }
            
        }
    }
}
