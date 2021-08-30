using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Temperatura = 0; 

            Console.Write("Regalame la temperatura actual: ");
            Temperatura = int.Parse(System.Console.ReadLine());

            while (Temperatura > 20)
            {
                Temperatura = Temperatura-1;
                Console.WriteLine($"Temperatura->{Temperatura}");
            }
            Console.WriteLine($"La temperatura final es {Temperatura}");
        }
    }
}
