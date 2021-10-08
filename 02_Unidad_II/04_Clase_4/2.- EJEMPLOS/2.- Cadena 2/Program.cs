using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        public static void Main()
        {
            /*El siguiente ejemplo define una matriz de palabras de cuatro letras y almacena 
             * sus letras individuales en una matriz de cadenas para codificarlas. Luego llama 
             * al método Concat (String, String, String, String) para volver a ensamblar las palabras codificadas.*/


            const int WORD_SIZE = 4;

            // Defina algunas palabras de 4 letras para codificar.

            string[] words = { "home", "food", "game", "rest" };
            // Defina dos matrices iguales al número de letras de cada palabra.

            double[] keys = new double[WORD_SIZE];
            string[] letters = new string[WORD_SIZE];

            // Inicializa el generador de números aleatorios.

            Random rnd = new Random();

            // Mezcla cada palabra.
            foreach (string word in words)
            {
                for (int ctr = 0; ctr < word.Length; ctr++)
                {
                    // Completa la matriz de claves con números aleatorios.

                    keys[ctr] = rnd.NextDouble();

                    // Asignar una letra a la matriz de letras.

                    letters[ctr] = word[ctr].ToString();
                }

                // Ordena la matriz.

                Array.Sort(keys, letters, 0, WORD_SIZE, Comparer.Default);

                // Muestra la palabra codificada.

                string scrambledWord = String.Concat(letters[0], letters[1], letters[2], letters[3]);

                Console.WriteLine("{0} --> {1}", word, scrambledWord);
            }
            Console.ReadKey();
        }
    }


}

