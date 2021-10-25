using System;
using System.IO;

namespace AplicacionBase
{
    /* Creando un archivo y escribiendo dentro de él. Este ejemplo usa el método 
     * CreateText() el cual crea un nuevo "archivo" y retorna un objeto streamWriter 
     * que escribe a un archivo usando formato UTF-8. */
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "c:\\sample\\ejercicio4.txt";
            StreamWriter writer = File.CreateText(fileName);

            writer.WriteLine("Este es mi Nuevo archivo creado.");
            writer.Close();

            Console.WriteLine("Ya el archivo se creo y se escribio, presione cualquier tecla para cerrar la consola");
            Console.ReadKey();
        }
    }

}