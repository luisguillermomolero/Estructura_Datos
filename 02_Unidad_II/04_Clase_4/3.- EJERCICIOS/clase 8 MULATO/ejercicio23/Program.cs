using System;
using System.Collections;

namespace ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push("Bienvenida");
            st.Push("a");
            st.Push("Age");
            st.Push("For");
            st.Push("Age");

            Console.WriteLine("El tipo de st antes " +
                     "metodo Method: " + st.GetType());

            Console.WriteLine("Después del método ToString: ");

            foreach (string str in st)
            {
                Console.WriteLine(str.ToString());
            }

            Console.WriteLine("El tipo de st después " +
                "metodo Method: " + st.ToString().GetType());
        }
    }
}
