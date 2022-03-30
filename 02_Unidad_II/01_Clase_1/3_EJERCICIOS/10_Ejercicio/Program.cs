using System;

//Escribir un programa que cambien los elementos de dos matrices. Todos los elementos de la primera matriz pasarán a la segunda matriz y todos los elementos de la segunda matriz pasarán a la primera matriz.

namespace AplicacionBase
{
    class Program
    {
        private static int[,] MatrizA;
        private static int[,] MatrizB;
        private static int[,] MatrizIntermedia;

        static void Main(string[] args)
        {
            int filasMatriz = 0;
            int columnasMatriz = 0;

            // Capturar la dimensión de la matriz en filas
            Console.Write("Cuantas filas tienen las Matrices: ");
            filasMatriz = int.Parse(System.Console.ReadLine());

            // Capturar la dimensión de la matriz en columnas
            Console.Write("Cuantas columnas tienen las Matrices: ");
            columnasMatriz = int.Parse(System.Console.ReadLine());

            // Definir la longitud en filas y columnas de la matriz
            MatrizA = new int[filasMatriz, columnasMatriz];
            MatrizB = new int[filasMatriz, columnasMatriz];
            MatrizIntermedia = new int[filasMatriz, columnasMatriz];

            // Cargar la matriz
            for (int f = 0; f < MatrizA.GetLength(0); f++){

                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 1: ");
                    MatrizA[f,c] = int.Parse(System.Console.ReadLine());
                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 2: ");
                    MatrizB[f,c] = int.Parse(System.Console.ReadLine());
                }
            }

            // Imprimir las matriz original "A"
            Console.WriteLine("\nlas matrices ingresadas fueron:");

            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    Console.Write($" [{MatrizA[f, c]}] ");
                }
                Console.WriteLine("");
            }
            
            // Imprimir las matriz original "B"
            Console.WriteLine("");
            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizB.GetLength(0); c++){
                    Console.Write($" [{MatrizB[f, c]}] ");
                }
                Console.WriteLine("");
            }

            // Cambiar los valores de las matrices
            Console.WriteLine("Cambiando los valores entre matrices");
            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    MatrizIntermedia[f,c] = MatrizA[f,c];
                    MatrizA[f,c] = MatrizB[f,c];
                    MatrizB[f,c] = MatrizIntermedia[f,c];
                }
            }

            // Imprimir la nueva matriz A
            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    Console.Write($" [{MatrizA[f, c]}] ");
                }
                Console.WriteLine("");
            }
            
            // Imprimir la nueva matriz B
            Console.WriteLine("");
            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizB.GetLength(0); c++){
                    Console.Write($" [{MatrizB[f, c]}] ");
                }
                Console.WriteLine("");
            }
        }
    }
}