//Aplicación que permite generar una factuara
using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor, Cantidad, Descuento, calculoIVA, Total, Precio2;
            string whileLoop ="";
            double IVA = 0.11F;
            double PORCENTAJE_DESCUENTO = 0.065f;

            do{

                Console.Write("  Digite el valor del producto: ");
                Valor = double.Parse(Console.ReadLine());
                Console.Write("  Digite la Cantidad del producto: ");
                Cantidad = double.Parse(Console.ReadLine());

                calculoIVA = (Valor * Cantidad) * IVA;
                Precio2 = (Valor * Cantidad) + IVA;


                if (Precio2 > 500)
                {
                    Descuento = Precio2 * PORCENTAJE_DESCUENTO;
                    Total = Precio2 - Descuento;
                    Console.WriteLine("");
                    Console.WriteLine("     El cliente compro {0} productos a un costo c/u de {1} pesos", Cantidad, Valor);
                    Console.WriteLine("     El IVA de la compra es de {0} ", calculoIVA);
                    Console.WriteLine("     Descuento por comprar mayor a 500 pesos {0} ", Descuento);
                    Console.WriteLine("     EL total a pagar es de: " + Total);
                }
    
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("     El cliente compro {0} productos a un costo c/u de {1} pesos", Cantidad, Valor);
                    Console.WriteLine("     El IVA de la compra es de {0} ", calculoIVA);
                    Console.WriteLine("     El total a pagar es de: " + Precio2);
                }

                Console.WriteLine("Desea salir ? ");
                whileLoop = Console.ReadLine();


            }while(whileLoop!="s");
        }
    }
}
