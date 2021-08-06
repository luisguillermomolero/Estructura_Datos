using System;

namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            

            Console.WriteLine("digite el tamaño del array si es tan amable ");
            tamaño = Convert.ToInt32(Console.ReadLine());



            int[] array = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Por favor escriba cada numero para saber si es multiplo de 7 gracias");
                array[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("el numero "+array[i]);
            }
        }
    }
}
