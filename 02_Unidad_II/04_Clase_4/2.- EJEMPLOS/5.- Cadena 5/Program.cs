using System;

public class StringExample
{
    public static void Main(string[] args)
    {
        /*Devuelve una nueva cadena de una longitud especificada en la 
         * que el final de la cadena actual se rellena con espacios o 
         * con un carácter Unicode especificado. */

        // cadena con longitud de 5 caracteres
        string s1 = "Hello";
        char pad = 'o';

        /* Uso del método PadRight() para adicionar el caracter "o" luego de la palabra 
         * "Hello" en una relación de 10 repeticiones */

        string s2 = s1.PadRight(15, pad);

        // Muestro la palabra resultado

        Console.Write(s2);

        // se escribirá después de 7 espacios en blanco
        Console.Write(" How are u");


        string s3 = "ello";
        char pad2 = 'e';

        // Uso del método PadLeft()
        string s4 = s3.PadLeft(14, pad2);

        // Relleno en el lado izquierdo (14-4 = 10)
        Console.WriteLine("");
        Console.Write("H");
        Console.Write(s4);

        // se escribirá después de 7 espacios en blanco
        Console.Write(" How are u");
    }
}