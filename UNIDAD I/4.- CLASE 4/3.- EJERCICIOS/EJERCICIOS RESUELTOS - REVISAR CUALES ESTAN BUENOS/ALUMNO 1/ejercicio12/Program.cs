using System;

namespace ejercicio12
{
    class Program
    {
		static void Main(string[] args)
		{
			int i;
			int estu;
			// Pedimos el tamaño del arreglo
			Console.WriteLine("buenas tardes profesor porfavor digite el numero de estudiantes");
			estu = int.Parse(Console.ReadLine());


			// Creamos los arreglos
			int[] numeros_aleatorios = new int[estu];
			double[] contadores = new double[4];

			Random aleatorios = new Random();
			// Recooremos el arreglo
			for (i = 0; i <= estu - 1; i++)
			{
				numeros_aleatorios[i] = aleatorios.Next(0, 20);
				Console.WriteLine("el estudiante " + (i + 1) + " tiene la siguente nota: " + numeros_aleatorios[i]);

				// Segun el valor, añadimos uno mas al arreglo 
				if (numeros_aleatorios[i] >= 0 && numeros_aleatorios[i] <= 5)
					contadores[0] = contadores[0] + 1;

				else
				{
					if (numeros_aleatorios[i] >= 6 && numeros_aleatorios[i] <= 10)
						contadores[1] = contadores[1] + 1;

					else
					{
						if (numeros_aleatorios[i] >= 11 && numeros_aleatorios[i] <= 15)
							contadores[2] = contadores[2] + 1;

						else
						{
							if (numeros_aleatorios[i] >= 16 && numeros_aleatorios[i] <= 20)
								contadores[3] = contadores[3] + 1;

						}
					}
				}
			}
			// Mostramos los valores
			for (i = 0; i <= 3; i++)
			{
				switch (i)
				{
					case 0:
						Console.WriteLine("Deficientes (0-5): " + contadores[i]);
						break;
					case 1:
						Console.WriteLine("Regulares (6-10): " + contadores[i]);
						break;
					case 2:
						Console.WriteLine("Buenos (11-15): " + contadores[i]);
						break;
					case 3:
						Console.WriteLine("Excelentes (16-20): " + contadores[i]);
						break;
				}
			}
		}
	}
}
