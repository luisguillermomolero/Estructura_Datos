using System;

namespace AplicacionBase
{
    class program
    {
        static void Main(string[] args)
        {
            int filasMatriz = 0;
            int columnasMatriz = 0;
            int[,] PrimeraMatriz;
            int[,] SegundaMatriz;
            int[,] MatrizResultado;

            Console.WriteLine("Programa que permite sumar una matriz (M1) con una matriz (M2) y mostrar el resultado en una tercera Matriz (MR)\n");

            // Introducir dimensión/filas matriz
            Console.Write("Cuantas filas tienen las Matrices: ");
            filasMatriz = int.Parse(System.Console.ReadLine());

            // Introducir dimensión/columnas matriz
            Console.Write("Cuantas columnas tienen las Matrices: ");
            columnasMatriz =int.Parse(System.Console.ReadLine());

            // Se instancian las 3 matrices
            PrimeraMatriz = new int[filasMatriz, columnasMatriz];
            SegundaMatriz = new int[filasMatriz, columnasMatriz];
            MatrizResultado = new int[filasMatriz, columnasMatriz];
            
            // Se cargan las 2 matrices y se genere la matriz resultado
            Console.WriteLine("Cargar las matrices 1 y 2");
            for (int f = 0; f < filasMatriz; f++){
                for (int c = 0; c < columnasMatriz; c++){
                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 1: ");
                    PrimeraMatriz[f,c] = int.Parse(System.Console.ReadLine());

                    Console.Write($"Digite el elemento de la posicion {f+1}:{c+1} de la matriz 2: ");
                    SegundaMatriz[f, c] = int.Parse(System.Console.ReadLine());

                    MatrizResultado[f,c] = PrimeraMatriz[f,c]+SegundaMatriz[f,c];
                }
            }
            
            // Se imprime la matriz resultado
            Console.WriteLine("La matriz resultado es: ");
            
            for (int f = 0; f < filasMatriz; f++){
                for (int c = 0; c < columnasMatriz; c++){
                    Console.Write("    " + MatrizResultado[f,c] + " ");
                }
                Console.WriteLine();
            }
        }   
    }
}
