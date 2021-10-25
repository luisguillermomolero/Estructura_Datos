using System;

namespace AplicacionBase
{

    class CocheSimple
    {
        private int VelocMax;
        private string Marca;
        private string Modelo;

        // Constructor

        public CocheSimple()
        {
            this.VelocMax = 0;
            this.Marca = "??";
            this.Modelo = "??";
        }
        public CocheSimple(string marca, string mod, int velMax)
        {
            this.VelocMax = velMax;
            this.Marca = marca;
            this.Modelo = mod;
        }

        public void MuestraCoche()
        {
            Console.WriteLine(this.Marca + " " + this.Modelo + "  (" + this.VelocMax + " Km/h)");
        }

    }

    class Taxi : CocheSimple
    {
        private string CodLicencia;

        public Taxi() { }

        public Taxi(string marca, string mod, int vel, string lic) : base(marca, mod, vel)
        {
            this.CodLicencia = lic;
        }
        public string Licencia
        {
            get { return this.CodLicencia; }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            CocheSimple MiCoche = new CocheSimple("Citröen", "Xsara Picasso", 220);
            CocheSimple TuCoche = new CocheSimple("Opel", "Corsa", 190);
            CocheSimple UnCoche = new CocheSimple();

            Console.Write("Mi coche: ");
            MiCoche.MuestraCoche();
            Console.Write("El tuyo: ");
            TuCoche.MuestraCoche();
            Console.Write("Un coche sin identificar: ");
            UnCoche.MuestraCoche();

            Console.WriteLine();

            Taxi ElTaxiDesconocido = new Taxi();
            Console.Write("Un taxi sin identificar: ");
            ElTaxiDesconocido.MuestraCoche();

            Taxi NuevoTaxi = new Taxi("Citröen", "C5", 250, "GR1234");
            Console.Write("Un taxi nuevo: ");
            NuevoTaxi.MuestraCoche();
            Console.Write("   Licencia: {0}", NuevoTaxi.Licencia);

            Console.ReadLine();

        }

    }

}
