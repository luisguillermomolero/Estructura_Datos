using System;

namespace AplicacionBase
{
    // Programa que permite llenar una matriz de "n" * "m", muestra la matriz completa y luego la última fila
    
    class OperarMatriz
    {
        /* Para definir una matriz debemos disponer una coma dentro de los corchetes, de esta forma 
         * el compilador de C# puede diferenciar los vectores de las matrices. */

        private int[,] Matriz;
        int longitudFilaMatriz, longitudColumnaMatriz;

        // Primer método: Cargar la matriz

        public void CargarMatriz()
        {
            // Capturamos la cantidad de filas de la matriz
            
            Console.Write("Cuantas filas tiene la matriz: ");
            int longitudFilaMatriz = int.Parse(System.Console.ReadLine());

            // Capturamos las columnas de la matriz

            Console.Write("Cuantas columnas tiene la matriz: ");
            int longitudColumnaMatriz = int.Parse(System.Console.ReadLine());

            // Una vez obtenidos los valores de las filas y columnas de la matriz, la declaramos

            Matriz = new int[longitudFilaMatriz,longitudColumnaMatriz];

            // Cargar la matriz
            for (int f = 0; f < longitudFilaMatriz; f++){
                for (int c = 0; c < longitudColumnaMatriz; c++){
                    Console.Write($"Ingrese el elemento [{f+1},{c+1}] de la matriz: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("La matriz resultante es -> ");

            for (int f = 0; f < Matriz.GetLength(0); f++){
                for (int c = 0; c < Matriz.GetLength(1); c++){
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirUltimaFila()
        {
            Console.WriteLine("La última fila es ->");

            for (int c = 0; c < Matriz.GetLength(1); c++){
                Console.Write("    [" + Matriz[Matriz.GetLength(0) - 1, c] + "] ");
            }
        }

        static void Main(string[] args)
        {
            OperarMatriz operarMatriz = new OperarMatriz();
            operarMatriz.CargarMatriz();
            operarMatriz.ImprimirMatriz();
            operarMatriz.ImprimirUltimaFila();
        }
    }
}
