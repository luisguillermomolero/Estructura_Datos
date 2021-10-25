using System;

namespace AplicacionBase
{
    class Dado
    {
        private int valor;

        public int Valor
        {
            get
            {
                return valor;
            }
            private set
            {
                valor = value;
            }
        }

        private static Random aleatorio;

        public Dado()
        {
            aleatorio = new Random();
        }

        public void Tirar()
        {
            Valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es:" + Valor);
        }
    }

    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }

        public void Jugar()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();
            if (dado1.Valor == dado2.Valor && dado1.Valor == dado3.Valor)
            {
                Console.WriteLine("Ganó");
            }
            else
            {
                Console.WriteLine("Perdió");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeDados j = new JuegoDeDados();
            j.Jugar();
            j.Jugar();
            j.Jugar();
            j.Jugar();
        }
    }

}
