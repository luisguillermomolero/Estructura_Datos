using System;


namespace Aplicacionbase
{
    // Definimos la clase "Cliente"
    class Cliente
    {
        // Definimos los atributos del cliente

        private string nombre;
        private int monto;

        /* Definimos nuestro método "Constructor" "Inicializador" llamado "Cliente".
         * Este método solo me va a instanciar cada atributo de un cliente. */

        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        // Definimos nuestro método "Operador" "Depositar"

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        // Definimos nuestro método "Operador" "Extraer"

        public void Extraer(int m)
        {
            monto = monto - m;
        }

        // Definimos nuestro método "Getter" "RetornarMonto"

        public int RetornarMonto()
        {
            return monto;
        }

        // Definimos nuestro método "Visualizador" "Imprimir"

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }

    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        // Definimos nuestro método "Constructor" "Inicializador" "Banco"

        public Banco()
        {
            cliente1 = new Cliente("Juan");
            cliente2 = new Cliente("Ana");
            cliente3 = new Cliente("Pedro");
        }

        /* Definimos nuestro método "Setter" para definir los valores iniciales
         * del atributo "depositar" de cada cliente */

        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(150);
            cliente3.Depositar(200);
            cliente3.Extraer(150);
            cliente1.Depositar(900);
            cliente3.Extraer(50);
        }

        /* Definimos nuestro método "Getter" para mostrar los valores
         * del método "RetornarMonto" de cada cliente y imprimir los 
         * datos de cada cliente */

        public void DepositosTotales()
        {
            int t = cliente1.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        /* Solo falto explicar el mètodo "Destructor", "Sobrecarga" y
         * "Sobregarca de constructores" */


        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}