using System;

namespace PruebaVector
{
    // Realizar un programa que Reste dos vectores y los almacene en un tercer vector 
    class PruebaVector
    {
        // Declaramos los vectores "A", "B" y "C"

        private int[] VectorA;
        private int[] VectorB;
        private int[] VectorC;
        int longitudVectores;


        public void CargarVectores()
        {
            Console.Write("Ingrese la longitud de los dos vectores a restar: ");
            longitudVectores = int.Parse(System.Console.ReadLine());
            VectorA = new int[longitudVectores];
            VectorB = new int[longitudVectores];
            VectorC = new int[longitudVectores];

            for (int i = 0; i < VectorA.Length; i++)
            {
                Console.Write($"Ingrese el elemento {i+1} del vector A: ");
                VectorA[i] = int.Parse(System.Console.ReadLine());

                Console.Write($"Ingrese el elemento {i+1} del vector B: ");
                VectorB[i] = int.Parse(System.Console.ReadLine());

                // Cargar el VectorC
                VectorC[i] = VectorA[i] - VectorB[i];
            }
        }

        public void VisualizarVectorC()
        {
            Console.WriteLine("\nLa resta de los vectores A y B es: ");
            for (int i = 0; i < VectorA.Length; i++)
            {
                Console.WriteLine($"El valor de la posición {i+1} es {VectorC[i]}");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.CargarVectores();
            pv.VisualizarVectorC();
        }
    }
}