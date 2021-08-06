using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{

    // Realizar un programa que Reste dos vectores y los almacene en un tercer vector 


    class PruebaVector
    {
        // Declaramos los vectores "A", "B" y "C"

        private int[] A;
        private int[] B;
        private int[] C;

        public void Cargar()
        {
            Console.Write("Ingrese la longitud de los vectores a restar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];

            Console.WriteLine("Ingrese los valores del vector A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese el elemento del vector [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingrese los valores del vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese el elemento del vector [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
            }

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] - B[i];
            }
        }

        public void Visualizar()
        {
            Console.WriteLine("La resta de los vectores A y B es: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("El valor de la posición " + (i + 1) + " del vector es [" + C[i] + "] ");
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