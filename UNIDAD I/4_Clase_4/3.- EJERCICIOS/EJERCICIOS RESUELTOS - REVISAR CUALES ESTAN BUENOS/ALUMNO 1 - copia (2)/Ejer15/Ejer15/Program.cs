using System;

namespace Ejer15
{
	class Program
	{
		static void Main(string[] args)
		{
			int i;
			int suma;
			//double prom;
			int tamanio;
			// Declaramos variables 

			Console.WriteLine("Ingrese cuantos numero naturales desea digitar");
			tamanio = int.Parse(Console.ReadLine());
			// Definimos el array
			int[] num = new int[tamanio];
			// Introducimos valores

			double prom;

			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Digite un numero " + i);
				num[i - 1] = int.Parse(Console.ReadLine());

				suma = 0;
				prom = (suma + num[i - 1]) / tamanio;
				Console.WriteLine("El promedio de los numeros es " + prom);
				if (num[i - 1] >= 5)
				{
					Console.WriteLine("El numero mayor es " + num[i - 1]);
				}
				else
				{
					Console.WriteLine("El numero menor es " + num[i - 1]);
				}

			}

		}

	}

}

