using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Comparacion de la palabra file con mayusculas y minusculas

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string compar = "File";
            string[] otros = { compar.ToLower(), compar, compar.ToUpper(), "fIle" };
            foreach (string otro in otros)
            {
                if (compar.Equals(otro))
                    Console.WriteLine("{0} = {1}",compar, otro);
                else
                    Console.WriteLine("{0} {1} {2}", compar, '\u2260', otro);
            }
        }
    }
}
