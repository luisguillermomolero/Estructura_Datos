using System;

//Pedir valores numéricos en dos vectores distintos y almacenar el resultado de los
//valores de cada posición (posición 0 del arreglo 1 + posición 0 del arreglo 2) y mostrar
//el contenido de los 3 vectores de esta forma. valor pos 0 arreglo 1 + valor pos 0
//arreglo 2 = valor pos 0 arreglo 3 valor pos 1 vector 1 + valor pos 1 arreglo 2 = valor
//pos 1 arreglo 3 …
namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Cuantos numeros va a sumar: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite la primera linea a sumar: ");
            //Declaramos un arreglo tipo int ya que vamos a usar nuemnros enteros
            int[] Vector_A = new int[a];
            // los 3 for van a recibir los balores ingesados el numero de veces pedidos los va a sumar y los muestra en pantalla
            for (int i = 0; i < Vector_A.Length; i++)
            {
                Console.WriteLine("Digite el valor #" + (i + 1) + ": ");
                Vector_A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite la segunda linea a sumar: ");
            int[] Vector_B = new int[a];
            for (int i = 0; i < Vector_B.Length; i++)
            {
                Console.WriteLine("Digite el valor #" + (i + 1) + ": ");
                Vector_B[i] = int.Parse(Console.ReadLine());
            }

            //Este arreglo nos muestra la suma
            int[] Vector_C = new int[a];
            for (int i = 0; i < Vector_A.Length; i++)
            {
                Vector_C[i] = Vector_A[i] + Vector_B[i];
            }

            for (int i = 0; i < Vector_A.Length; i++)
            {
                Console.WriteLine("la suma del verctor " + (i + 1) + " es: " + Vector_C[i]);
            }
        }
    }
}