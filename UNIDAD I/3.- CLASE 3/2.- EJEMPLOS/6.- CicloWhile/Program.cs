using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura   =  0; string valor = "";

            Console.WriteLine("Regalame la temperatura actual:");
            valor =  Console.ReadLine();
            temperatura   =  Convert.ToInt32(valor);

            while   (temperatura  >  20)
            {
                temperatura --;
                Console.WriteLine("Temperatura->{0}", temperatura);
            }
            Console.WriteLine("La temperatura final es {0}", temperatura);
        }
    }
}
