using System;

namespace aplicacionBase
{
    // Programa que permite llenar una matriz de 3 filas y 5 columnas y mostrarla al final

    class PrimeraMatriz
    {
        /* Para definir una matriz debemos disponer una coma dentro de los corchetes, de esta forma 
        * el compilador de C# puede diferenciar los vectores de las matrices. */

        // Definimos la matriz de 3*5
        int[,] Matriz = new int[3, 5];
        int LONGITUD_FILA_MATRIZ = 3;
        int LONGITUD_COLUMNA_MATRIZ = 5;

        // Primer método: Cargar la matriz

        public void CargarMatriz()
        {
            // Cargar la matriz

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write($"Ingrese el elemento {f+1}, {c+1} del la matriz: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("\nLa matriz resultante es");

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrimeraMatriz matriz = new PrimeraMatriz();
            matriz.CargarMatriz();
            matriz.ImprimirMatriz();
        }
    }
}