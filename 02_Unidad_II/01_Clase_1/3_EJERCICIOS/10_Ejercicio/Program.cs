using System;

//Escribir un programa que cambien los elementos de dos matrices. Todos los elementos de
//la primera matriz pasarán a la segunda matriz y todos los elementos de la segunda matriz
//pasarán a la primera matriz.

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

            Console.Write("Cuantas filas tienen las Matrices: ");
            filasMatriz = int.Parse(System.Console.ReadLine());

            Console.Write("Cuantas columnas tienen las Matrices: ");
            columnasMatriz = int.Parse(System.Console.ReadLine());

            MatrizA = new int[filasMatriz, columnasMatriz];
            MatrizB = new int[filasMatriz, columnasMatriz];
            MatrizIntermedia = new int[filasMatriz, columnasMatriz];

            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 1: ");
                    MatrizA[f,c] = int.Parse(System.Console.ReadLine());
                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 2: ");
                    MatrizB[f,c] = int.Parse(System.Console.ReadLine());
                }
            }

            Console.WriteLine("\nlas matrices ingresadas fueron:");

            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    Console.Write($" [{MatrizA[f, c]}] ");
                }
                Console.WriteLine("");
            }
            
            Console.WriteLine("");
            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizB.GetLength(0); c++){
                    Console.Write($" [{MatrizB[f, c]}] ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Cambiando los valores entre matrices");
            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    MatrizIntermedia[f,c] = MatrizA[f,c];
                    MatrizA[f,c] = MatrizB[f,c];
                    MatrizB[f,c] = MatrizIntermedia[f,c];
                }
            }

            for (int f = 0; f < MatrizA.GetLength(0); f++){
                for (int c = 0; c < MatrizA.GetLength(0); c++){
                    Console.Write($" [{MatrizA[f, c]}] ");
                }
                Console.WriteLine("");
            }
            
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