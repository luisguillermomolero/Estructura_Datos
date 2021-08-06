using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{

    /* Realizar un programa que ingrese un vector de n elementos e imprimir el 
     * menor y un mensaje si se repite dentro del vector dicho numero. */


    class PruebaVector
    {

        //Declaramos un vector
        private int[] vector;

        //Declaramos la variable privada entera "menor"
        private int menor;


        public void Cargar()
        {
            Console.Write("Ingrese la longitud del vector: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);


            vector = new int[n];

            // Cargando el vector
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese el elemento del vector número [" + (f + 1) + "]: ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void MenorElemento()
        {
            menor = vector[0];
            for (int f = 1; f < vector.Length; f++)
            {
                if (vector[f] < menor)
                {
                    menor = vector[f];
                }
            }
            Console.WriteLine("El elemento menor es: " + menor);
        }

        public void RepiteMenor()
        {
            int cant = 0;

            for (int f = 0; f < vector.Length; f++)
            {
                if (vector[f] == menor)
                {
                    cant++;
                }
            }
            if (cant > 1)
            {
                Console.WriteLine("Se repite el numero.");
            }
            else
            {
                Console.WriteLine("No se repite el menor.");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.MenorElemento();
            pv.RepiteMenor();
        }
    }
}