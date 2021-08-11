using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distancia, Tiempo;
            double Costo;

            Console.Write("Ingresar Distancia del Viaje programado: ");
            Distancia = int.Parse(Console.ReadLine());
            Console.Write("Ingresar Tiempo de Estancia del vieje: ");
            Tiempo = int.Parse(Console.ReadLine());

            if (Distancia > 800 && Tiempo > 7)
            {

                Costo = (Distancia * 2.5) * 0.30;
                Console.WriteLine("El Boleto tiene descuento ya que es por mas de 800Km y 7 días de estancia");
                Console.WriteLine("El precio del boleto es de: $" + Costo);

            }
            else
            {
                Costo = Distancia * 2 * 2.5;
                Console.WriteLine("El Boleto no tiene descuento ya que no es por mas de 800Km y 7 días de estancia");
                Console.WriteLine("El Costo del boleto es: $" + Costo);
            }
        }
    }
}
