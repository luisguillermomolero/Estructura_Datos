using System;

namespace Ejer10
{
	class Program
	{
			static void Main(string[] args)
			{
				int i;
				int impar;
				int pos_central;
				// Validamos que el numero sea impar
				do
				{
					Console.WriteLine("Digite un numero impar");
					impar = int.Parse(Console.ReadLine());

				} 
				while (impar % 2 != 1);

				// Creamos el arreglo
				int[] numeros_aleatorios = new int[impar];

				// Rellenamos con numeros aleatorios
				for (i = 1; i <= impar; i++)
				{
					Random rnd = new Random();
					numeros_aleatorios[i - 1] = rnd.Next(0, 20);
					Console.WriteLine(numeros_aleatorios[i - 1]);
				}

				// Espacio
				Console.WriteLine("");

				// Valor de la posicion central
				pos_central = (impar / 2);
				Console.WriteLine("Posicion central: " + numeros_aleatorios[pos_central - 1]);
			}

		}
	}

