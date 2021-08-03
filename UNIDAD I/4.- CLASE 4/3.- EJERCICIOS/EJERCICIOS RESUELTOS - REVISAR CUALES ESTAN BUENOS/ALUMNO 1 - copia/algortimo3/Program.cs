using System;

//Crea un vector unidimensional con un tamaño de 10, inserta los valores numéricos
//que desees de la manera que quieras y muestra por pantalla la media de valores del
//array
namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este arreglo define cuantos vertores va a llevar, en este caso son 10
            int[] n = new int[10];

            n[0] = 55;
            n[1] = 100;
            n[2] = 5;
            n[3] = 1;
            n[4] = 50000;
            n[5] = 57;
            n[6] = 20;
            n[7] = 60;
            n[8] = 530;
            n[9] = 111;

            //Este for nos va  amostrar la lista en pantalla
            for (int a = 0; a < n.Length; a++)
            {
                Console.WriteLine("#" + (a + 1) + ": " + n[a]);
            }
            //Declaramos una variable para el contador
            int b = 0;
            //Este for va hacer la suma de todos los vectores
            for (int a = 0; a < n.Length; a++)
            {
                b = b + n[a];
            }
            //Aqui nos imprimme el resultato en pantalla
            Console.WriteLine("La medida es de: " + (b / 10));
        }
    }
}
