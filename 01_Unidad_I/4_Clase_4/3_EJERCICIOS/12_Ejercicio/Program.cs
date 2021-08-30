using System;

namespace AplicacionBase
{
    class Program
    {
		static void Main(string[] args)
		{
			int cantidadEstudiantes;

			Console.Write("Digite el numero de estudiantes: ");
			cantidadEstudiantes = int.Parse(System.Console.ReadLine());

			int[] Calificacion = new int[cantidadEstudiantes];
			double[] vectorCategoriaEstudiante = new double[4];

			Random aleatorios = new Random();

			for (int i = 0; i < cantidadEstudiantes; i++)
			{
				Calificacion[i] = aleatorios.Next(0, 20);
				Console.WriteLine($"El estudiante {i+1} tiene la siguente calificación {Calificacion[i]}");

				// Segun el valor, añadimos uno mas al arreglo 
				if (Calificacion[i] >= 0 && Calificacion[i] <= 5)
					vectorCategoriaEstudiante[0] += 1;

				else
				{
					if (Calificacion[i] >= 6 && Calificacion[i] <= 10)
						vectorCategoriaEstudiante[1] += 1;

					else
					{
						if (Calificacion[i] >= 11 && Calificacion[i] <= 15)
							vectorCategoriaEstudiante[2] += 1;

						else
						{
							if (Calificacion[i] >= 16 && Calificacion[i] <= 20)
								vectorCategoriaEstudiante[3] += 1;

						}
					}
				}
			}
			// Mostramos los valores
			for (int i = 0; i <= 3; i++)
			{
				switch (i)
				{
					case 0:
						Console.WriteLine($"Deficientes (0-5): {vectorCategoriaEstudiante[i]}");
						break;
					case 1:
						Console.WriteLine($"Regulares (6-10): {vectorCategoriaEstudiante[i]}");
						break;
					case 2:
						Console.WriteLine($"Buenos (11-15): {vectorCategoriaEstudiante[i]}");
						break;
					case 3:
						Console.WriteLine($"Excelentes (16-20): {vectorCategoriaEstudiante[i]}");
						break;
				}
			}
		}
	}
}
