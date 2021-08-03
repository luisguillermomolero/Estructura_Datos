using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int primer = 0;
            int segund = 0;
            int tercer = 0;
            string entrada = "";


            Console.WriteLine("escribe tres numeros diferentes");
            Console.WriteLine("");

            Console.WriteLine("escribe el primer numero ");
            entrada = Console.ReadLine();
            primer = Convert.ToInt32(entrada);

            Console.WriteLine("escribe el segundo numero ");
            entrada = Console.ReadLine();
            segund = Convert.ToInt32(entrada);

            Console.WriteLine("escribe el tercero numero ");
            entrada = Console.ReadLine();
            tercer = Convert.ToInt32(entrada);

            if (((primer < segund) && (primer > tercer)) || ((primer < tercer) && (primer > segund)))
            
                Console.WriteLine("el numero del medio es: " + primer);
            
            else if (((segund < tercer) && (segund > primer)) || ((segund < primer) && (segund > tercer)))
            
                Console.WriteLine("el numero del medio es: " + segund);
            
            else 
             
                 Console.WriteLine("el numero del medio es: " + tercer);
            
        }
    }
}
