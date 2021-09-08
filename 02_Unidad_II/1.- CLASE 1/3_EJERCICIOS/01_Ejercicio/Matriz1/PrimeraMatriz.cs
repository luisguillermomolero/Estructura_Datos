using System;

namespace AplicacionBase
{
    class PrimeraMatriz
    {
        private int[,] Matriz;
        int DIMENSION_FILAS_MATRIZ = 3;
        int DIMENSION_COLUMNAS_MATRIZ = 2;
        // Primer método: Cargar la matriz
        public void CargarMatriz()
        {
            // Definimos la matriz de 5*6

            Matriz = new int[DIMENSION_FILAS_MATRIZ, DIMENSION_COLUMNAS_MATRIZ];

            // Procedemos a llenar la matriz

            for (int f = 0; f < DIMENSION_FILAS_MATRIZ; f++){
                for (int c = 0; c < DIMENSION_COLUMNAS_MATRIZ; c++){
                    Console.Write("Ingrese el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                     //
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void ImprimirMatrizResultado()
        {
            Console.WriteLine(" La matriz resultante es ");

            for (int f = 0; f < DIMENSION_FILAS_MATRIZ; f++){
                for (int c = 0; c < DIMENSION_COLUMNAS_MATRIZ; c++){
                    Console.Write("    " + Matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PrimeraMatriz matriz = new PrimeraMatriz();
            matriz.CargarMatriz();
            matriz.ImprimirMatrizResultado();
        }
    }
}
