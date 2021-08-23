using System;

namespace AplicacionBase
{
    /* Realizar un programa que ingrese un vector de "n" elementos e imprima el 
     * menor valor ademas de un mensaje si ese número se repite dentro del vector.
     */
    class PruebaVector
    {
        // Declaracion del vector
        private int[] Vector;

        //Declaracion de variables
        private int menorValor;
        private int longitudVector;


        public void CargarVector()
        {
            Console.Write("Ingrese la longitud del Vector: ");
            longitudVector = int.Parse(System.Console.ReadLine());

            Vector = new int[longitudVector];

            // Cargar el Vector
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write($"Ingrese el elemento {f} del Vector: ");
                Vector[f] = int.Parse(System.Console.ReadLine());
            }
        }

        public void MenorElemento()
        {
            menorValor = Vector[0];

            for (int f = 1; f < Vector.Length; f++)
            {
                if (Vector[f] < menorValor)
                    menorValor = Vector[f];
            }
            Console.WriteLine($"El elemento menor es {menorValor}");
        }

        public void RepiteMenor()
        {
            int contadorRepeticiones = 0;

            for (int f = 0; f < Vector.Length; f++)
            {
                if (Vector[f] == menorValor)
                    contadorRepeticiones++;
            }
            if (contadorRepeticiones > 1)
            {
                Console.WriteLine($"El {menorValor} se repite {contadorRepeticiones} veces");
            }
            else
            {
                Console.WriteLine("El elemento menor no se repite");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.CargarVector();
            pv.MenorElemento();
            pv.RepiteMenor();
        }
    }
}