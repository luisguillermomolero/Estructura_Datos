using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;


namespace Ejer4
{
	class Program
	{
		static void MostrArarray(string num, double tamanio)
		{
			int i;

			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine(num[i - 1]);
			}

			MostrArarray(num, tamanio);
		}
		static void Main(string[] args)
		{
			// Declaramos variables
			int num_multiplo;
			int tamanio;

			// Definimos el tamaño del vector por teclado 
			Console.WriteLine("Introduce el tamaño del array");
			tamanio = int.Parse(Console.ReadLine());

			// Definimos el vector
			int[] num = new int[tamanio];

			// Definimos el numero con el que rellenaremos el vector con sus multiplos
			Console.WriteLine("Introduce el numero con el que rellenar");
			num_multiplo = int.Parse(Console.ReadLine());

				int i;

				for (i = 1; i <= tamanio; i++)
				{
					num[i-1] = num_multiplo * i;
				Console.WriteLine("los multiplos de "+ num_multiplo + " son " + num[i - 1]);
			}

		}
	}
}