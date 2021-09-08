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

            Console.WriteLine("Este ejericio permite sumar una matriz (M1) con una matriz (M2) y mostrar el resultado en una tercera Matriz (MR)\n");

            Console.Write("Cuantas filas tienen las Matrices: ");
            filasMatriz = int.Parse(System.Console.ReadLine());

            Console.Write("Cuantas columnas tienen las Matrices: ");
            columnasMatriz =int.Parse(System.Console.ReadLine());

            //Cargar la primera matriz
            PrimeraMatriz = new int[filasMatriz, columnasMatriz];
            SegundaMatriz = new int[filasMatriz, columnasMatriz];
            MatrizResultado = new int[filasMatriz, columnasMatriz];
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
