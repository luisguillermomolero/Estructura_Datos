using System;

namespace AplicacionBase
{
    class EvaluacionMatriz
    {
        int[,] Matriz;
        int FILAS_MATRIZ = 2;
        int COLUMNAS_MATRIZ = 2;
            
        public void CargarMatriz()
        {
            Matriz = new int[FILAS_MATRIZ, COLUMNAS_MATRIZ];

            Console.WriteLine("Ejercicio que permite cargar una matriz 3x3 e imprimir cuantos numeros son ceros, cuantos positivos y cuantos negativos\n");

            for (int f = 0; f < FILAS_MATRIZ; f++){
                for (int c = 0; c < COLUMNAS_MATRIZ; c++){
                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1}: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void EvaluarMatriz()
        {
            int contadorCeros = 0, contadorPositivos = 0, contadorNegativos = 0;

            for (int f = 0; f < FILAS_MATRIZ; f++){
                for (int c = 0; c < COLUMNAS_MATRIZ; c++){
                    if (Matriz[f,c] == 0)
                        contadorCeros = contadorCeros + 1;
                    else if (Matriz[f, c] > 0)
                        contadorPositivos = contadorPositivos + 1; 
                    else
                        contadorNegativos = contadorNegativos + 1;
                }
            }
            Console.WriteLine($"Usted dijito {contadorCeros} ceros, {contadorPositivos} numeros positivos y {contadorNegativos} numeros negativos");
        }

        static void Main(string[] args)
        { 
            EvaluacionMatriz evaluacionMatriz = new EvaluacionMatriz();
            evaluacionMatriz.CargarMatriz();
            evaluacionMatriz.EvaluarMatriz();
        }
    }
}
