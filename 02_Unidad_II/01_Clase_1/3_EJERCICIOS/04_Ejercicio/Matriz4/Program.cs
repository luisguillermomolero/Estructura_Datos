using System;

namespace AplicacionBase
{
    class Program
    {
		static void Main(string[] args)
		{
			int FILAS_MATRIZ = 2;
			int COLUMNAS_MATRIZ = 2;
			int numeroMenor = 1;
			int[,] Matriz = new int[FILAS_MATRIZ+1, COLUMNAS_MATRIZ+1];
			int[] diagonalVector = new int[FILAS_MATRIZ+1];

			Console.WriteLine("Ingrese valores a la primera matriz");

				for (int f = 0; f <= FILAS_MATRIZ; f++){
					for (int c = 0; c <= COLUMNAS_MATRIZ; c++){
						Console.Write($"Digite un numero para la posicion {f},{c} : " );
						Matriz[f,c] = int.Parse(System.Console.ReadLine());

					  if (Matriz[f,c] <= numeroMenor)
						   numeroMenor = Matriz[f,c];
					}
				}

			Console.WriteLine("");
			Console.WriteLine("La matriz resultado es: ");
			for (int f = 0; f <= FILAS_MATRIZ; f++){
					for (int c = 0; c <= COLUMNAS_MATRIZ; c++){
						Console.Write(Matriz[c,f] + " ");
					}
					Console.WriteLine("");
				}
				Console.WriteLine("");
				Console.WriteLine("El número menor dentro de la diagonal es : " + numeroMenor);
		}

	}

}