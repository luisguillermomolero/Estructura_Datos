using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distancia, Tiempo;
            double Costo;
            int DISTANCIA_PROMOCION = 800;
            int TIEMPO_PROMOCION = 7;

            Console.Write("Ingresar Distancia del Viaje programado: ");
            Distancia = int.Parse(Console.ReadLine());
            Console.Write("Ingresar Tiempo de Estancia del vieje: ");
            Tiempo = int.Parse(Console.ReadLine());

            if (Distancia > DISTANCIA_PROMOCION && Tiempo > TIEMPO_PROMOCION)
            {

                Costo = (Distancia * 2.5) * 0.30;
                Console.WriteLine("El Boleto tiene descuento del 30 % ya que la distancia es superior a 800Km y tiene 7 días de estancia");
                Console.WriteLine("El precio del boleto es de: $" + Costo);

            }
            else
            {
                Costo = Distancia * 2.5;
                Console.WriteLine("El Costo del boleto es: $" + Costo);
            }
        }
    }
}
