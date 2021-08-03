using System;

//Pediremos los IDs (números) de alumnos de dos clases, álgebra y análisis. Queremos
//mostrar todos los alumnos comunes en las dos asignaturas.
namespace Ejercicio_7
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos alumnos son en la clase de lagebra?");
            int a = int.Parse(Console.ReadLine());

            int[] Clase_A = new int[a];
            for (int i = 0; i < Clase_A.Length; i++)
            {
                Console.WriteLine("Digite el ID del alumno #" + (i + 1));
                Clase_A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("¿Cuantos alumnos son en la clase de Analisis?");
            int b = int.Parse(Console.ReadLine());
            int[] Clase_An = new int[b];
            for (int i = 0; i < Clase_An.Length; i++)
            {
                Console.WriteLine("Digite el ID del alumno #" + (i + 1));
                Clase_An[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
