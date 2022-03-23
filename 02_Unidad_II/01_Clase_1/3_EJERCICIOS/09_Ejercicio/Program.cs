using System;

// Programa que copia todos los elementos de una matriz "A" en otra matriz "B".

namespace AplicacionBase
{
    class Program
    {
        private static int[,] MatrizA;
        private static int[,] MatrizB;
     
        static void Main(string[] args)
        {
            {
                int filasMatriz;
                int columnasMatriz;

                // Cargar la matriz

                Console.WriteLine("Programa que copia todos los elementos de una matriz \"A\" en otra matriz \"B\"\n");

                Console.Write("Cuantas filas tienen las Matrices: ");
                filasMatriz = int.Parse(System.Console.ReadLine());

                Console.Write("Cuantas columnas tienen las Matrices: ");
                columnasMatriz =int.Parse(System.Console.ReadLine());

                MatrizA = new int[filasMatriz, columnasMatriz];
                MatrizB = new int[filasMatriz, columnasMatriz];

                for (int f = 0; f < MatrizA.GetLength(0); f++){
                    for (int c = 0; c < MatrizA.GetLength(1); c++){
                        Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 1: ");
                        MatrizA[f,c] = int.Parse(System.Console.ReadLine());
                    }
                }

                Console.WriteLine("\nla matriz ingresada fue:");

                for (int f = 0; f < MatrizA.GetLength(0); f++){
                    for (int c = 0; c < MatrizA.GetLength(1); c++){
                        Console.Write($" [{MatrizA[f, c]}] ");
                    }
                    Console.WriteLine("");
                }
                
                Console.Write("La nueva matriz es:\n");

                for (int f = 0; f < MatrizB.GetLength(0); f++){
                    for (int c = 0; c < MatrizB.GetLength(1); c++){
                        MatrizB[f,c] = MatrizA[f,c];
                        Console.Write($" [{MatrizB[f, c]}] ");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
