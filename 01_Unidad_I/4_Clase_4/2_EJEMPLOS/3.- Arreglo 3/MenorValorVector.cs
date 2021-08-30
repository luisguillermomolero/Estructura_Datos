using System;

namespace AplicacionBase
{
    /* programa que ingrese un vector de "n" elementos e imprima el menor valor 
     *  ademas de un mensaje si ese número se repite dentro del vector.
     */

    class MenorValorVector
    {
        // Declaracion del vector
        int[] Vector;
        //Declaracion de variables
        int menorValor = 0;
        int longitudVector;

        // Método (Comportamiento) para cargar el Vector
        public void CargarVector()
        {
            // Capturar la longitud de elementos del vector
            Console.Write("Ingrese la longitud del Vector: ");
            longitudVector = int.Parse(System.Console.ReadLine());

            // Instanciar el vector a "longitudVector" elementos
            Vector = new int[longitudVector];

            // Cargar el Vector de "longitudVector" elementos
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write($"Ingrese el elemento {f+1} del Vector: ");
                Vector[f] = int.Parse(System.Console.ReadLine());
            }
        }

        // Método (Comportamiento) para evaluar el menor valor del Vector
        public void MenorElemento()
        {
            int MENOR_VALOR = 10; // Constante para comparar el menor valor del Vector

            for (int f = 1; f < Vector.Length; f++)
            {
                if (Vector[f] < MENOR_VALOR){
                    MENOR_VALOR = Vector[f]; 
                    menorValor = MENOR_VALOR;
                }
            }
            Console.WriteLine($"El elemento menor es {menorValor}");
        }

        // Método (Comportamiento) para evaluar si un valor del Vector se repite y lo muestre por pantalla
        public void RepiteMenor()
        {
            int contadorRepeticiones = 0;

            for (int f = 0; f < Vector.Length; f++)
            {
                if (Vector[f] == menorValor)
                    contadorRepeticiones++;
            }
            if (contadorRepeticiones > 1){
                Console.WriteLine($"El {menorValor} se repite {contadorRepeticiones} veces");
            }else{
                Console.WriteLine("El elemento menor no se repite");
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            // Instanciar (Crear objeto) la clase "MenorValorVector"
            MenorValorVector menorValorVector = new MenorValorVector();
            // Llamar los métodos de la clase "MenorValorVector" desde el objeto "menorValorVector"
            menorValorVector.CargarVector();
            menorValorVector.MenorElemento();
            menorValorVector.RepiteMenor();
        }
    }
}