using System;

//Modifica el ejercicio anterior para que insertes los valores numéricos
//con leer mediante un bucle y los muestre por pantalla.
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramosla variabla que vamos a ustilizar mas adelante
            string a;

            Console.WriteLine("Digite los 5 número: ");

            // este arreglo tipo float nos ayuda usar el listado 5 quito pedido
            float[] Numero = new float[5];

            //Con este bucle repetira el numero de veces peidido este caso 5
            for (int i = 0; i < Numero.Length; i++)
            {
                //Aqui pedira el numero 5 veces y mostrara en pantalla
                a = Console.ReadLine();
                Numero[i] = Convert.ToSingle(a);


            }
            for(int i = 0; i < Numero.Length; i++)
            {
                //aqui los muestra por la pantalla
                Console.WriteLine("#" + (i + 1) + " es: " + Numero[i]);
            }

        }
    }
}