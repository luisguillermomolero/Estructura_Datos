using System;

//Escribe un programa que llene una matriz de 10 x10 y que almacene en la diagonal principal el menor de ese renglón.

namespace AplicacionBase
{
    class Program
    {
		static void Main(string[] args)
		{
			int FILAS_MATRIZ = 2;
			int COLUMNAS_MATRIZ = 2;
			int numeroMenor = 1;
			int[,] Matriz = new int[FILAS_MATRIZ, COLUMNAS_MATRIZ];
			int[] diagonalVector = new int[FILAS_MATRIZ];

			Console.WriteLine("Ingrese valores a la primera matriz");

				for (int f = 0; f < FILAS_MATRIZ; f++){
					for (int c = 0; c < COLUMNAS_MATRIZ; c++){
						Console.Write($"Digite un numero para la posicion {f+1},{c+1} : " );
						Matriz[f,c] = int.Parse(System.Console.ReadLine());

					  if (Matriz[f,c] <= numeroMenor)
						   numeroMenor = Matriz[f,c];
					}
				}

			Console.WriteLine("");
			Console.WriteLine("La matriz resultado es: ");
			for (int f = 0; f < FILAS_MATRIZ; f++){
					for (int c = 0; c < COLUMNAS_MATRIZ; c++){
						Console.Write(Matriz[f,c] + " ");
					}
					Console.WriteLine("");
				}
				Console.WriteLine("");
				Console.WriteLine("El número menor dentro de la diagonal es : " + numeroMenor);
		}

	}

}