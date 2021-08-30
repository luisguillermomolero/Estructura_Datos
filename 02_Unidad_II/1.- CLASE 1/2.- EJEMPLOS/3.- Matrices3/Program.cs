using System;

namespace AplicacionBAse
{
    // Programa que permite llenar una matriz de f*c y mostrar al final el mayor valor contenido en la matriz

    class MayorElementoMatriz
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


        public void ImprimirMayor()
        {
            int ELEMENTO_MAYOR = Matriz[0, 0];
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int f = 0; f < Matriz.GetLength(0); f++){
                for (int c = 0; c < Matriz.GetLength(1); c++){
                    if (Matriz[f, c] > ELEMENTO_MAYOR){
                        ELEMENTO_MAYOR = Matriz[f, c];
                        filaMayor = f;
                        columnaMayor = c;
                    }
                }
            }
            Console.WriteLine("El elemento mayor de la matriz de [" + Matriz.GetLength(0) + "] x ["  + Matriz.GetLength(1) + "] es : [" + ELEMENTO_MAYOR + "]");
            Console.WriteLine("Se encuentra en la fila: [" + (filaMayor + 1) + "] columna: [" + (columnaMayor + 1) + "]" );
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            MayorElementoMatriz mayorElementoMatriz = new MayorElementoMatriz();
            mayorElementoMatriz.CargarMatriz();
            mayorElementoMatriz.ImprimirMayor();
        }
    }
}
