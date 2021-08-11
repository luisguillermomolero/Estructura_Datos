using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Primero = 0;
            int Segundo = 0;
            int Tercero = 0;
            string Entrada = "";


            Console.WriteLine("escribe tres numeros diferentes");
            Console.WriteLine("");

            Console.WriteLine("escribe el primer numero ");
            Entrada = Console.ReadLine();
            Primero = Convert.ToInt32(Entrada);

            Console.WriteLine("escribe el segundo numero ");
            Entrada = Console.ReadLine();
            Segundo = Convert.ToInt32(Entrada);

            Console.WriteLine("escribe el tercero numero ");
            Entrada = Console.ReadLine();
            Tercero = Convert.ToInt32(Entrada);

            if (((Primero < Segundo) && (Primero > Tercero)) || ((Primero < Tercero) && (Primero > Segundo)))
            
                Console.WriteLine("el numero del medio es: " + Primero);
            
            else if (((Segundo < Tercero) && (Segundo > Primero)) || ((Segundo < Primero) && (Segundo > Tercero)))
            
                Console.WriteLine("el numero del medio es: " + Segundo);
            
            else 
             
                 Console.WriteLine("el numero del medio es: " + Tercero);
            
        }
    }
}
