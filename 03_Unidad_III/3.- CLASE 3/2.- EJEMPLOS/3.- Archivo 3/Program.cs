using System;
using System.IO;

namespace AplicacionBase
{
    // Escribiendo en un archive de texto

    class Program
    {
        static void Main(string[] args)
        {
            // Se declara una variable con la ruta y nombre del archivo "txt"
            string fileName = "c:\\sample\\Ejercicio3.txt";

            /* A traves de la clase "FileStream" se define un objeto (Stream) que tiene 
             * 3 sobracargas: a) Ruta y nombre del archivo, b) abrir el archivo y c) acceso
             * para lectura */
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

            /*  Escribir en el archivo.  Recuerde que el nuevo texto se escribira desde la 
             *  posición 1 del archivo y se sobrepondra sobre el texto allí existente */

            StreamWriter writer = new StreamWriter(stream);

            // El siguiente texto sera escrito dentro del archivo
            writer.WriteLine("Esta es la primera línea dentro del archivo y sobreescribira el texto ya existente");
            writer.Close();

            Console.WriteLine("Ya el archivo fue escrito, presione cualquier tecla para cerrar la consola");
            Console.ReadKey();
        }
    }
}