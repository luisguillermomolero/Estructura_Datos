using System;

namespace AplicacionBase
{
	class Program
	{
		static void Main(string[] args)
		{
			int FILAS_MATRIZ = 2;
			int COLUMNAS_MATRIZ = 2;
			int[,] Matriz = new int[FILAS_MATRIZ+1, COLUMNAS_MATRIZ+1];
			int[] diagonalVector = new int[FILAS_MATRIZ+1];
			
			// Introduccion de numeros para rellenar la matriz 5*5

			for (int f = 0; f <= FILAS_MATRIZ; f++){
				for (int c = 0; c <= COLUMNAS_MATRIZ; c++){
					Console.Write($"Digite un numero para la posicion {f},{c} : " );
					Matriz[f,c] = int.Parse(System.Console.ReadLine());
					// Diagonal del vector
					if (c == f)
						diagonalVector[f] = Matriz[f,c];
				}
			}
			// Imprimir matriz//
			Console.WriteLine("\nLa matriz resultado es : ");
			for (int c = 0; c <= COLUMNAS_MATRIZ; c++){
				for (int f = 0; f <= FILAS_MATRIZ; f++){
					Console.Write(Matriz[f,c] + " ");
				}
				Console.WriteLine(" ");		
			}
			Console.WriteLine("");
			Console.WriteLine("La diagonal del vector es: ");
           	for (int f = 0; f <= FILAS_MATRIZ; f++){
				Console.WriteLine(diagonalVector[f]);
			}
		}
	}
}