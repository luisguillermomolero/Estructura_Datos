using System;

//Crea un vector unidimensional donde tú le indiques el tamaño por teclado y crear
//una función que rellene el vector con los múltiplos de un numero pedido por
//teclado. Por ejemplo, si defino un array de tamaño 5 y elijo un 3 en la función, el
//array contendrá 3, 6, 9, 12, 15.
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables declaradas
            int d = 0;
            float c = 0.0f;
            int b;
            string a;

            // Pide la informacion
            Console.WriteLine("Digite la cantidad de digitos quiere que aparezca: ");
            b = Convert.ToInt32(Console.ReadLine());
            float[] Arreglo = new float[b];

            Console.WriteLine("Digite cual tabal quieres realizar: ");
            d = Convert.ToInt32(Console.ReadLine());

            //el bucle se repite el numero de  veces que diga b
            Console.WriteLine("La tabal es: ");
            for (int i = 0; i < b; i++)
            {
                //Mostrara los numeros impares
                c = d * (i + 1);
                Console.WriteLine("" + c);
            }
        }
    }
}