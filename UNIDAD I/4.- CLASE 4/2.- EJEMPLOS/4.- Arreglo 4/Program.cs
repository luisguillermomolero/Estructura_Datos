using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{
    // Realizar un programa que sume dos vectores y los almacene en un tercer vector 

    class PruebaVector
    {
        // Declaramos los vectores "A", "B" Y "C"

        private int[] A;
        private int[] B;
        private int[] C;

        public void Cargar()
        {
        
            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];

            Console.WriteLine("Ingrese los valores del vector A");
            
            // Ciclo para cargar los vectores "A"

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese el elemento [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            
            Console.WriteLine("Ingrese los valores del vector B");

            // Ciclo para cargar los vectores "A"

            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese el elemento [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
            }

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }
        }

        public void Visualizar()
        {
            Console.WriteLine("La suma de los vectores A y B es: ");
            for (int i = 0; i < A.Length; i++)
            {
                //Console.Write("[" + C[i] + "] ");

                Console.WriteLine("El valor de la posición "+ (i + 1) + " del vector es [" + C[i] + "] ");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.Visualizar();
        }
    }
}