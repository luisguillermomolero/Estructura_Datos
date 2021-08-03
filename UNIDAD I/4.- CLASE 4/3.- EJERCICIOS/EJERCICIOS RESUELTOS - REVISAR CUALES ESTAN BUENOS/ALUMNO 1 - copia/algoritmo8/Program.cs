using System;

//Estos alumnos se guarden en un tercer vector y que sea el que se muestre. También
//indica el número de alumnos que se repiten.
namespace Ejercicio_8
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
            //con este tercer arreglo nos va a decir cuantos numeros se repiten en las msimas ubicaciones de los vectores
            int[] Repetidos = new int[Clase_A.Length];
            int Co = 0;
            int f = 0;
            if (Clase_A[i] == Clase_An[i])
            {
                Co++;
                f = Co + 1;
                Console.WriteLine("Son iguales " + f);
            }
        }
    }
}