using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
			double i;
			double num_alumnos_comunes;
			int tamanio;
			tamanio = 4;
			string[] algebra = new string[tamanio];
			string[] analisis = new string[tamanio];
			string[] comunes = new string[tamanio];

			rellenararreglo(algebra, tamanio - 1, "Algebra");

			rellenararreglo(analisis, tamanio - 1, "Analisis");

			num_alumnos_comunes = buscarelementos(algebra, analisis, comunes, tamanio - 1);

			Console.WriteLine("Hay " + num_alumnos_comunes + " comunes");

			for (i = 0; i <= num_alumnos_comunes; i++)
			{
				Console.WriteLine(i);
			}
		}

		static double buscarelementos(string algebra, string analisis, string comunes, double tamanio)
		{
			double comunes_contador;
			double contador;
			double i;
			double j;
			contador = 0;
			for (i = 0; i <= tamanio; i++)
			{
				for (j = 0; j <= tamanio; j++)
				{
					if (i == j)
					{
						comunes_contador = i;
						contador = contador + 1;
					}
				}
			}
			return contador;
		}

		static void rellenararreglo(string arreglo, double tamanio, string materia)
		{
			double i;
			for (i = 0; i <= tamanio; i++)
			{
				Console.WriteLine("Inserta el ID del alumno de la materia " + materia + " en la posicion " + i);
				i = Double.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
    }
}
