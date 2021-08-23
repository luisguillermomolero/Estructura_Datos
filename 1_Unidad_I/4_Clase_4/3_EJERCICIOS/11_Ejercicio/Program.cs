using System;

namespace AplicacionBase
{
    class Program
    { 
        static void Main(string[] args)
        {
            int cantidadEstudiantes;
            double alumnosAprobados = 0.0F;
            double alumnosReprobados = 0.0F;
            double totalAprobados = 0.0F;
            double totalReprobados = 0.0F;

            Console.Write("Digite la cantidad de estudiantes para calculo de indice de aprobados/reprobados: ");
            cantidadEstudiantes = int.Parse(System.Console.ReadLine());

            int[] Calificacion = new int[cantidadEstudiantes];

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write($"Digite la calificación del estudiante #{i+1}: ");
                Calificacion[i] = int.Parse(System.Console.ReadLine());

                if (Calificacion[i] >= 3)
                {
                    alumnosAprobados += Calificacion[i];
                    totalAprobados += 1;
                }
                else
                {
                    alumnosReprobados += Calificacion[i];
                    totalReprobados += 1;
                }
            }

            Console.WriteLine($"Promedio de aprobados: {(totalAprobados/cantidadEstudiantes)*100}%");
            Console.WriteLine($"Promedio de reprobados: {(totalReprobados/cantidadEstudiantes)*100}%");
            Console.WriteLine($"Cantidad de aprovados: {totalAprobados}");
            Console.WriteLine($"Cantidad de reprovados: {totalReprobados}");


        }
    }
}
