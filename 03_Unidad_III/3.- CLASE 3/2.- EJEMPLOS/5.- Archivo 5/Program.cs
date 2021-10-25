using System;
using System.IO;

namespace AplicacionBase
{
    //Insertando texto en un archivo

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "c:\\sample\\Ejercicio5.txt";

                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);

                writer.WriteLine("Este es el texto adicionado.");
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Ya el archivo fue escrito, presione cualquier tecla para cerrar la consola");
            Console.ReadKey();
        }
    }
}