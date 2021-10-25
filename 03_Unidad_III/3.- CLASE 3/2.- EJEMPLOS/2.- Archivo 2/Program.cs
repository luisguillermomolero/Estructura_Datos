using System;
using System.IO;

namespace AplicacionBase
{
    // Leer desde un archivo de texto

    class Program
    {
        /* Para este ejemplo se debe crear un archivo llamado "Ejercicio2.txt" dentro
         * de una carpeta en la raiz de "C" llamado "sample", es decir, 
         * la ruta debe ser "C:\sample\Ejercicio2.txt */

        static void Main(string[] args)
        {
            // Se declara una variable con la ruta y nombre del archivo "txt"
            string fileName = "c:\\sample\\Ejercicio2.txt"; 

            /* A traves de la clase "FileStream" se define un objeto (Stream) que tiene 
             * 3 sobracargas: a) Ruta y nombre del archivo, b) abrir el archivo y c) acceso
             * para lectura */

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            
            // Leer el archivo
            StreamReader reader = new StreamReader(stream);

            // Ciclo para imprimir todo el contenido del archivo por pantalla

            while (reader.Peek() > -1) 
                Console.WriteLine("Bytes conseguidos: \n\n" + reader.ReadLine());
            reader.Close();

            Console.ReadKey();
        }
    }
}
