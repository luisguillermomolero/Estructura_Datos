using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int ganador = 0;

            Console.WriteLine("por favor ingrese el cuantos competidores van a estar");
            n = Convert.ToInt32(Console.ReadLine());

            //definiendo el array
            int[] tamaño = new int[n];


            //introduciendo los numero y guardandolos
            for (int i = 0; i < tamaño.Length; i++)
            {
                Console.WriteLine("por favor ingrese el dato numero: " + (i + 1));
                tamaño[i] = Convert.ToInt32(Console.ReadLine());
            }

            ganador = tamaño[0];
            for (int i = 0; i < tamaño.Length; i++)
            {
                //guardando dato mayor y el dato menor
                if (tamaño[i] > ganador)
                    ganador = tamaño[i];
            }
            Console.WriteLine("el ganador es el del tiempo de: " + ganador);
        }
    }
}
