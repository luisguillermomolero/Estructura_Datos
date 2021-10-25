using System;
using System.Text;
using System.IO;

namespace AplicacionBase
{
    // programa que permite Leer desde un archivo usando BufferedStream

    class Program
    {
        /* Para este ejemplo se debe crear un archivo llamado "Ejemplo1.xml" dentro
         * de una carpeta en la raiz de "C" llamado "sample", es decir, 
         * la ruta debe ser "C:\sample\Ejemplo1.xml */

        
        static void Main(string[] args)
        {
            /* Se crea una variable local de tipo "path" que es igual a la
             * la ruta donde se encuentra el archivo "Ejemplo1.xml" */

            string path = "c:\\sample\\Ejercicio1.xml";

            /* Se usa la clase "Stream" de la biblioteca "System.IO" para definir
             * una variable tipo "instream" para leer un archivo */

            Stream instream = File.OpenRead(path); // Clase "File" con método "OpenRead" para leer un archivo existente.

            // crear buffer para abrir el archivo (objeto Stream) y leerlo

            BufferedStream bufin = new BufferedStream(instream);
            byte[] bytes = new byte[1024]; //Crea un arreglo tipo "byte" para leer hasta 1024 bytes

            // leer los primeros 1024 bytes del archivo
            bufin.Read(bytes, 0, 1024);

            // Imprime por pantalla 
            Console.WriteLine("Bytes conseguidos:  \n\n"
                + Encoding.ASCII.GetString(bytes)); /* Decodifica la secuencia de bytes en formato ASCII que se 
                                                     * encuentra en el arreglo "bytes" */
            Console.ReadKey();
        }
    }
}
