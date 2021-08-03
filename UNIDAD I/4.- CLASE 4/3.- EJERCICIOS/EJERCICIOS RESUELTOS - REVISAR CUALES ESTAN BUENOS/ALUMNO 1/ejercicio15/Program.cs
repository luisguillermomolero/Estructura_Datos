using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int mayor = 0;
            int menor = 0;
            int prom = 0;
            int completos = 0;

            Console.WriteLine("por favor ingrese el tamaño del array si es tan amable");
            n = Convert.ToInt32(Console.ReadLine());

            //definiendo el array
            int[] tamaño = new int[n];


            //introduciendo los numero y guardandolos
            for (int i = 0; i< tamaño.Length; i++)
            {
                Console.WriteLine("por favor ingrese el dato numero: "+(i+1));
                tamaño[i] = Convert.ToInt32(Console.ReadLine());

                completos = completos + tamaño[i];
            }

            mayor = menor = tamaño[0];
            prom = completos / n;

            for (int i  = 0; i < tamaño.Length; i++)
            {
                //guardando dato mayor y el dato menor
                if (tamaño[i] > mayor)
                    mayor = tamaño[i];

                if (tamaño[i] < menor)
                    menor = tamaño[i];
            }


            Console.WriteLine("el promedio de los numeros indicados es de: " + prom);
            Console.WriteLine("el numero mayor indicado es: " + mayor);
            Console.WriteLine("el numero menor indicado es: " + menor);
        }
    }
}
