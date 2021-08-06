using System;

namespace algoritmo1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 1;
            int mitad = i / 2;
                
               
            Console.WriteLine("acontinuacion una serie de numeros impares ");//se realiza la serie de numeros impares 
            for( i = 1; i < 100; i += 2)

            {
                Console.WriteLine("{0}", i);// operacion para saber cual es el centro del vector 
                mitad = i / 2;
                
            }
            Console.WriteLine("el valor que ocupa el centro del vector es : {0}", mitad);
        }

    }
}
