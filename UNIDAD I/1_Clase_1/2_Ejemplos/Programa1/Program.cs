using System; //https://docs.microsoft.com/es-es/dotnet/api/system?view=dotnet-plat-ext-3.1
using System.Linq; //https://docs.microsoft.com/es-es/dotnet/api/system.linq?view=netcore-3.1
using System.Text;  //https://docs.microsoft.com/es-es/dotnet/api/system.text?view=netcore-3.1
using System.Collections;  //https://docs.microsoft.com/es-es/dotnet/api/system.collections?view=netcore-3.1
using System.Collections.Generic;  //https://docs.microsoft.com/es-es/dotnet/api/system.collections.generic?view=dotnet-plat-ext-3.1

//El "namespace" organiza las clases y evitar duplicidad dentro de un entorno, agrupándo las clases de un modo más lógico y jerárquico.

// **********  Para ejecutar: dotnet run **********

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