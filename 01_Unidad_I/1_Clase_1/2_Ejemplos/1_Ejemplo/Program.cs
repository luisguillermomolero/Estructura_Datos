using System;

//El "namespace" organiza las clases y evitar duplicidad dentro de un entorno, agrupándo las clases de un modo más lógico y jerárquico.

// ********* Para crear el entorno del programa, abra una consola en la carpeta donde se encuentra el
// archivo .cs y escriba lo siguiente:
// dotnet new console -o Program 
// (donde Program será el nombre de la carpeta donde se guarde todo el proyecto), finalmente, borre el archivo .cs

// Video del SDK:
// https://www.youtube.com/watch?v=FfZu7jNk-2I

// *********  Para ejecutar: dotnet run *********

namespace AplicacionBase
{
    //Aplicación para hacer un pastel

    //Declaración de la clase principal
    class Program
    {
        //Declaración de la clase donde inicia la aplicación

        static void Main(string[] args)
        {
            //Mostrar mensajes por pantalla a traves del método Console.Writeline() o console.Write()
            
            Console.WriteLine("1.- Precalentar el horno");
            Console.WriteLine("2.- Batir la margarina y azucar");
            Console.WriteLine("3.- Agregar huevos");
            Console.WriteLine("4.- Cernir harina");
            Console.WriteLine("5.- Agregar a la mescla y leche");
            Console.WriteLine("6.- Hornear por 40 minutos");
            Console.WriteLine("7. Decorar y comer");
        }

    }
}