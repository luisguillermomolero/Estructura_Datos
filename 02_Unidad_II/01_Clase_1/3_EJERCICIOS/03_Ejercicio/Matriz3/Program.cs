﻿using System;

//Escribe un programa que llene una matriz de 5 x 5 y que almacene la diagonal principal en un vector. Imprimir el vector resultante.

namespace AplicacionBase

{
	class Program
	{
		static void Main(string[] args)
		{
			int FILAS_MATRIZ = 3;
			int COLUMNAS_MATRIZ = 3;
			int[,] Matriz = new int[FILAS_MATRIZ, COLUMNAS_MATRIZ];
			int[] diagonalVector = new int[FILAS_MATRIZ+1];
			
			// Introduccion de numeros para cargar la matriz 5*5

			for (int f = 0; f < FILAS_MATRIZ; f++){
				for (int c = 0; c < COLUMNAS_MATRIZ; c++){
					Console.Write($"Digite un numero para la posicion {f},{c} : " );
					Matriz[f,c] = int.Parse(System.Console.ReadLine());
					// Diagonal del vector
					if (c == f)
						diagonalVector[f] = Matriz[f,c];
				}
			}
			// Imprimir matriz//
			Console.WriteLine("\nLa matriz resultado es : ");
			for (int c = 0; c < COLUMNAS_MATRIZ; c++){
				for (int f = 0; f < FILAS_MATRIZ; f++){
					Console.Write(Matriz[f,c] + " ");
				}
				Console.WriteLine(" ");		
			}
			Console.WriteLine("");
			Console.WriteLine("La diagonal del vector es: ");
           	for (int f = 0; f < FILAS_MATRIZ; f++){
				Console.WriteLine(diagonalVector[f]);
			}
		}
	}
}