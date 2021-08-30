using System;

namespace AplicacionBase
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declaracion de variables
			int Multiplos;
			int longitudVector;

			// Definir del tamaño del vector por teclado
			Console.Write("Introduce la longitud del vector: ");
			longitudVector = int.Parse(System.Console.ReadLine());

			// Definir vector
			int[] Vector = new int[longitudVector];

			// Cargar vector con un valor para luego calcular sus multiplos
			Console.Write("Introduce el número para cargar el vector: ");
			Multiplos = int.Parse(System.Console.ReadLine());

			for (int i = 0; i < longitudVector; i++)
			{
				Vector[i] = Multiplos * (i+1);
				Console.WriteLine($"los multiplos de {Multiplos} son -> {Vector[i]}");
			}
		}
	}
}